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
        public frmCategorias()
        {
            InitializeComponent();
        }

        public frmCategorias(String nombre, String precio, String categoria)
        {
            InitializeComponent();
            NombreProducto = nombre;
            PrecioProducto = precio;
            CategorriaProducto = categoria;
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Datos recibido:" + NombreProducto + PrecioProducto + CategorriaProducto);
        }
    }
}
