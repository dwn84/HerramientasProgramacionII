using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionDB
{
    public partial class frmCategorias : Form
    {

        private String NombreProducto;
        private String PrecioProducto;
        private String CategorriaProducto;
        public DataGridView datos;
        public frmCategorias()
        {
            InitializeComponent();
        }

        public frmCategorias(String nombre, String precio, String categoria, DataGridView tabla)
        {
            InitializeComponent();
            NombreProducto = nombre;
            PrecioProducto = precio;
            CategorriaProducto = categoria;
            datos = tabla;
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Datos recibido:" + NombreProducto + PrecioProducto + CategorriaProducto);
            dataGridView1.Rows.Add(datos.Rows[0].Cells[1].Value);
            datos.Rows[0].Cells[1].Value = "asdf";
            
        }
    }
}
