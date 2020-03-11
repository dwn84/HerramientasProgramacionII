using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploDatagrid
{
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text;
            int cantidad = int.Parse(txtCantidad.Text);
            double precio = double.Parse(txtPrecio.Text);
            double total = cantidad * precio;
            dgvProductos.Rows.Add(new Object[] {descripcion,precio ,cantidad,total} );
            txtPrecio.Clear();
            txtDescripcion.Clear();
            txtCantidad.Clear();

        }
    }
}
