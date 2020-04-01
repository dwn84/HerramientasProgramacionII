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
            query.CommandText = "insert into Clientes values('"+txtCed.Text+ "','" + txtNom.Text + "','" + txtApe.Text + "','" + dtpFec.Text + "','" + cmbGen.Text + "','" + txtBarrio.Text + "')";
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
            SqlCommand consulltaCiente = new SqlCommand();
            consulltaCiente.Connection = conexion;
            consulltaCiente.CommandText = "select * from Clientes where cedula='" + txtBuscarCed.Text + "'";
            SqlDataReader datos = consulltaCiente.ExecuteReader();
            if (datos.Read())
            {
                lblNom.Visible = true;
                lblNom.Text = datos["nombre"].ToString();
                btnBorrar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No existe ningún cliente con la cedula ingresada");
                lblNom.Visible = false;
            }


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta =  MessageBox.Show("¿Está seguro que desea borrar este dato?", "Confirmación borar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (respuesta == DialogResult.Yes)
            {
                SqlCommand borrarCliente = new SqlCommand();
                borrarCliente.Connection = conexion;
                borrarCliente.CommandText = "delete from Clientes where cedula='" + txtBuscarCed.Text + "'";
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
                lblNom.Visible = false;
                txtBuscarCed.Clear();
                txtBuscarCed.Select();
            }

        }
    }
}
