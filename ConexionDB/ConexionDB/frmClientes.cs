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
        bool avanzar;
        public frmClientes()
        {
            InitializeComponent();
            avanzar = false;
            conexion = new SqlConnection("server=SYN\\SQLEXPRESS;database=base1;integrated security=true;MultipleActiveResultSets=True");
            conexion.Open();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (avanzar)
            {
                SqlCommand query = new SqlCommand();
                query.Connection = conexion;
                //query.CommandText = "insert into Clientes values('"+txtCed.Text+ "','" + txtNom.Text + "','" + txtApe.Text + "','" + dtpFec.Text + "','" + cmbGen.Text + "','" + txtBarrio.Text + "')";
                query.CommandText = "insert into Clientes values(@ced,@nom,@ape,@fec,@gen,@bar)";
                query.Parameters.Add("@ced", SqlDbType.VarChar).Value = txtCed.Text;
                query.Parameters.Add("@nom", SqlDbType.VarChar).Value = txtNom.Text;
                query.Parameters.Add("@ape", SqlDbType.VarChar).Value = txtApe.Text;
                query.Parameters.Add("@gen", SqlDbType.VarChar).Value = cmbGen.Text;
                query.Parameters.Add("@fec", SqlDbType.Date).Value = dtpFec.Value;
                query.Parameters.Add("@bar", SqlDbType.VarChar).Value = txtBarrio.Text;
                //query.Parameters.AddWithValue("@c", txtCed.Text);
                query.ExecuteNonQuery();
                txtApe.Clear();
                txtBarrio.Clear();
                txtCed.Clear();
                txtNom.Clear();
                txtCed.Select();
                MessageBox.Show("Cliente agregado correctamente");
            }
            else {
                MessageBox.Show("No se puede guardar el dato, corrija los errores");
            }

            

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
                lsbClientes.Items.Add(datos["nombre"] + " " + datos["apellido"]);
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
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea borrar este dato?", "Confirmación borar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (respuesta == DialogResult.Yes)
            {
                SqlCommand borrarCliente = new SqlCommand();
                borrarCliente.Connection = conexion;
                borrarCliente.CommandText = "delete from Clientes where cedula=@ced";
                borrarCliente.Parameters.Add("@ced", SqlDbType.VarChar).Value = txtCed.Text;
                int totalDatos = borrarCliente.ExecuteNonQuery();
                if (totalDatos == 1)
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

        private void txtCed_Validated(object sender, EventArgs e)
        {
            if (txtCed.Text == "")
            {
                cedulaErrorProvider.SetError(txtCed, "No se puede dejar la cédula en blanco");
                avanzar = false;
            }
            else if (txtCed.TextLength > 12)
            {
                cedulaErrorProvider.SetError(txtCed, "Cédula muy extensa, no se permiten más de 12 caracteres");
                avanzar = false;

            }
            else
            {
                cedulaErrorProvider.Clear();
                avanzar = true;
            }

            if (!avanzar) {
                txtCed.Select();
            }
        }

        private void txtCed_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNom_Validated(object sender, EventArgs e)
        {

            bool error = false;
            foreach (char c in txtNom.Text) 
            {
                if (!char.IsLetter(c)) {
                    error = true;
                    break;
                }
            }
            if (string.IsNullOrEmpty(txtNom.Text))
            {
                cedulaErrorProvider.SetError(txtNom, "No se puede dejar el nombre en blanco");
                avanzar = false;
            }

            if (txtNom.TextLength > 55)
            {
                nombreErrorProvider.SetError(txtNom, "Nombre muy extenso...");
                avanzar = false;

            }
            else if (error)
            {
                nombreErrorProvider.SetError(txtNom, "Solo se permiten letras.");
                avanzar = false;

            }
            else {
                nombreErrorProvider.SetError(txtNom, String.Empty);
                avanzar = true;

            }

            if (!avanzar) {
                txtNom.Select();
            }
        }

        private void dtpFec_Validated(object sender, EventArgs e)
        {
            var fechaReferencia = new DateTime(2002, 1, 1);

            if (dtpFec.Value < fechaReferencia)
            {
                FechaerrorProvider.SetError(dtpFec, "No se permiten personas nacidas antes del 2020");
                avanzar = false;
            }
            else
            {
                FechaerrorProvider.Clear();
                avanzar = true;
            }
            if (!avanzar) {
                dtpFec.Select();
            }
        }

        private void txtBarrio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar==(char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }
            else {
                e.Handled = true;
            }
        }
    }
}
