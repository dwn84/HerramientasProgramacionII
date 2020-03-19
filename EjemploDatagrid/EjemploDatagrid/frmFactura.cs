using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//agregar libreria de depuracion
using System.Diagnostics;

namespace EjemploDatagrid
{
    public partial class frmFactura : Form
    {

        int filaSeleccionada;
        public frmFactura()
        {
            InitializeComponent();
        }


        private void Limpiar()
        {

            txtPrecio.Clear();
            txtDescripcion.Clear();
            txtCantidad.Clear();
            txtDescripcion.Focus();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (btnAgregar.Text == "Agregar")
            {
                if (txtCantidad.Text == "" || txtDescripcion.Text == "" || txtPrecio.Text == "")
                {
                    MessageBox.Show("Debe ingresar todos lo datos");
                }
                else
                {
                    btnEliminar.Enabled = true;
                    string descripcion = txtDescripcion.Text;
                    int cantidad = int.Parse(txtCantidad.Text);
                    double precio = double.Parse(txtPrecio.Text);
                    double total = cantidad * precio;
                    dgvProductos.Rows.Add(new Object[] { descripcion, precio, cantidad, total });
                    Limpiar();
                    
                    
                    /*
                     txtPrecio.Clear();
                     txtDescripcion.Clear();
                     txtCantidad.Clear();
                     txtDescripcion.Focus();
                     */
                    lblSubtotal.Text = CalcularSubtotal();
                }
            }
            else if (btnAgregar.Text=="Actualizar")
            {

                dgvProductos.Rows[filaSeleccionada].Cells["Cantidad"].Value = txtCantidad.Text;
                dgvProductos.Rows[filaSeleccionada].Cells["Descripcion"].Value = txtDescripcion.Text;
                dgvProductos.Rows[filaSeleccionada].Cells["PrecioU"].Value = txtPrecio.Text;
                dgvProductos.Rows[filaSeleccionada].Cells["Total"].Value = Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text);

                btnAgregar.Text = "Agregar";
                lblSubtotal.Text = CalcularSubtotal();
                Limpiar();
            }

           
        }

        private string CalcularSubtotal() 
        {
            //acumulador
            double sumatoria = 0;

            foreach (DataGridViewRow f in dgvProductos.Rows)
            {
                sumatoria+= Convert.ToDouble(f.Cells["Total"].Value);
            }

            return sumatoria.ToString();

            //otra alternativa para recorrer los datos en la tabla.
            //for (int i = 0; i < dgvProductos.Rows.Count; i++)
            //{
            //    sumatoria += Convert.ToDouble(dgvProductos.Rows[i].Cells["Total"].Value);
            //}

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            //
            int totalD = dgvProductos.Rows.Count;

            if (totalD > 0)
            {
                int x = dgvProductos.CurrentRow.Index;
                dgvProductos.Rows.RemoveAt(x);
//                dgvProductos.Columns.RemoveAt(2);
                lblSubtotal.Text = CalcularSubtotal();
                btnAgregar.Text = "Agregar";
                Limpiar();
            }
            else 
            {
                btnEliminar.Enabled = false;
            }
        //Monitorear o ver un objeto o variable
           //Debug.WriteLine("Indice de la fila actual" + x);
            Debug.WriteLine("Total de fila de la tabla" + totalD);

        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = dgvProductos.CurrentRow.Index;
            txtCantidad.Text = dgvProductos.Rows[filaSeleccionada].Cells["Cantidad"].Value.ToString();
            txtDescripcion.Text = dgvProductos.Rows[filaSeleccionada].Cells["Descripcion"].Value.ToString();
            txtPrecio.Text = dgvProductos.Rows[filaSeleccionada].Cells["PrecioU"].Value.ToString();
            btnAgregar.Text = "Actualizar";
        }
    }
}
