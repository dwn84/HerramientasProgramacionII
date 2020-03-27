using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//agregar la libreria para gestion de base de datos: sql server
using System.Data.SqlClient;

namespace ConexionDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=SYN\\SQLEXPRESS;integrated security=true;database=base1");
            conexion.Open();
            //MessageBox.Show("Conexion satisfactoria a la base de datos");
           

            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("No se puede omitir la descripción");
            }
            else 
            {

                String sql = "insert into Articulos(Descripcion,Precio)  values('" + txtDescripcion.Text + "', " + txtPrecio.Text + "); ";
                
                SqlCommand ejecutarConsulta = new SqlCommand(sql, conexion);
                ejecutarConsulta.ExecuteNonQuery();
                MessageBox.Show("Dato agregado correctamente");

                txtDescripcion.Clear();
                txtPrecio.Clear();
                txtDescripcion.Focus();

            }

            conexion.Close();
        }
    }
}
