using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConexionDB
{
    public partial class frmClientes : Form
    {

        private SqlConnection conexion;

        public frmClientes()
        {
            InitializeComponent();
            conexion = new SqlConnection("server=SYN\\SQLEXPRESS;database=base1;integrated security=true;MultipleActiveResultSets=True");
            conexion.Open();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            SqlCommand query = new SqlCommand();
            query.Connection = conexion;
            //query.CommandText = "insert into Clientes values('"+txtCed.Text+ "','" + txtNom.Text + "','" + txtApe.Text + "','" + dtpFec.Text + "','" + cmbGen.Text + "','" + txtBarrio.Text + "')";
            query.CommandText = "insert into Clientes values(@ced,@nom,@ape,@fec,@gen,@bar)";
            query.Parameters.Add("@ced", SqlDbType.VarChar).Value= txtCed.Text;
            query.Parameters.Add("@nom", SqlDbType.VarChar).Value = txtNom.Text;
            query.Parameters.Add("@ape", SqlDbType.VarChar).Value= txtApe.Text;
            query.Parameters.Add("@gen", SqlDbType.VarChar).Value= cmbGen.Text;
            query.Parameters.Add("@fec", SqlDbType.Date).Value= dtpFec.Value;
            query.Parameters.Add("@bar", SqlDbType.VarChar).Value= txtBarrio.Text;
            //query.Parameters.AddWithValue("@c", txtCed.Text);
            query.ExecuteNonQuery();
            txtApe.Clear();
            txtBarrio.Clear();
            txtCed.Clear();
            txtNom.Clear();
            txtCed.Select();
            MessageBox.Show("Cliente agregado correctamente");
 
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lsbClientes.Items.Clear();
            SqlCommand query = new SqlCommand();
            query.Connection = conexion;
            query.CommandText = "select * from Clientes";
            //Recibir los datos de la consulta: select...
            SqlDataReader datos = query.ExecuteReader();
            while (datos.Read())
            {
                lsbClientes.Items.Add(datos["nombre"]+" "+datos["apellido"]);            
            }
 
            
        }

        private void frmClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            conexion.Close();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlCommand consultaCiente = new SqlCommand();
            consultaCiente.Connection = conexion;
            //consultaCiente.CommandText = "select * from Clientes where cedula='" + txtBuscarCed.Text + "'";
            consultaCiente.CommandText = "select * from Clientes where cedula=@ced";
            consultaCiente.Parameters.Add("@ced", SqlDbType.VarChar);
            consultaCiente.Parameters["@ced"].Value = txtBuscarCed.Text;
            SqlDataReader datos = consultaCiente.ExecuteReader();
            if (datos.Read())
            {

                var cuadrosdeTexto = groupBox1.Controls.OfType<TextBox>();

                foreach (TextBox txt in cuadrosdeTexto)
                {
                    txt.Enabled = true;
                }
                dtpEditFec.Enabled = true;
                cmbEditGen.Enabled = true;
                txtEditNom.Text = datos["nombre"].ToString();
                txtEditApe.Text = datos["apellido"].ToString();
                txtEditBar.Text = datos["barrio"].ToString(); 
                DateTime fecha = (DateTime)datos["fechaNacimiento"];
                dtpEditFec.Text = fecha.ToString("yyyy-MM-dd");
                cmbEditGen.Text = datos["genero"].ToString();
                /*if (datos["genero"].ToString().Equals("M"))
                {
                    cmbEditGen.Text = "Masculino";
                }
                else 
                {
                    cmbEditGen.Text = "Femenino";
                }
                */
                btnBorrar.Enabled = true;
                btnActualizar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No existe ningún cliente con la cedula ingresada");
                var cuadrosdeTexto = groupBox1.Controls.OfType<TextBox>();

                foreach (TextBox txt in cuadrosdeTexto)
                {
                    txt.Enabled = false;
                }
            }


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta =  MessageBox.Show("¿Está seguro que desea borrar este dato?", "Confirmación borar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (respuesta == DialogResult.Yes)
            {
                SqlCommand borrarCliente = new SqlCommand();
                borrarCliente.Connection = conexion;
                borrarCliente.CommandText = "delete from Clientes where cedula=@ced";
                borrarCliente.Parameters.Add("@ced", SqlDbType.VarChar).Value = txtCed.Text;
                int totalDatos = borrarCliente.ExecuteNonQuery();
                if (totalDatos==1)
                {
                    MessageBox.Show("Dato borrado correctamnete");
                    //limpiar textbox...
                }
                else
                {
                    MessageBox.Show("No existe ningún cliente con la cedula ingresada");

                }

            }
            else if (respuesta == DialogResult.No) 
            {
                btnBorrar.Enabled = false;
                btnActualizar.Enabled = false;
                //lblNom.Visible = false;
                txtBuscarCed.Clear();
                txtBuscarCed.Select();
            }

        }

        private void lsbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea actualizar este dato?", "Confirmación actualizar:" + txtEditNom.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (respuesta == DialogResult.Yes)
            {
                SqlCommand cambiarCliente = new SqlCommand();
                cambiarCliente.Connection = conexion;
                cambiarCliente.CommandText = "update Clientes set nombre = @nom,apellido = @ape,fechaNacimiento = @fec,genero = @gen,barrio = @bar where cedula = @ced;";
                cambiarCliente.Parameters.Add("@nom", SqlDbType.VarChar).Value = txtEditNom.Text;
                cambiarCliente.Parameters.Add("@ape", SqlDbType.VarChar).Value = txtEditApe.Text;
                cambiarCliente.Parameters.Add("@fec", SqlDbType.VarChar).Value = dtpEditFec.Text;
                cambiarCliente.Parameters.Add("@gen", SqlDbType.VarChar).Value = cmbEditGen.Text;
                cambiarCliente.Parameters.Add("@bar", SqlDbType.VarChar).Value = txtEditBar.Text;
                cambiarCliente.Parameters.Add("@ced", SqlDbType.VarChar).Value = txtBuscarCed.Text;
                int totalDatos = cambiarCliente.ExecuteNonQuery();
                if (totalDatos == 1)
                {
                    MessageBox.Show("Dato actualizado correctamnete");
                    //limpiar textbox...
                }
            }
            else 
            {
                //limpiar textbox...
            }
        }
    }
}
