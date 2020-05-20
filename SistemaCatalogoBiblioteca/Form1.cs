using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaCatalogoBiblioteca
{
    public partial class Form1 : Form
    {

        ManipulacionBD biblioteca;

        public Form1()
        {
            InitializeComponent();
            biblioteca = new ManipulacionBD();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstEditorial.DataSource = biblioteca.ListarTodasLasEditoriales();
            lstEditorial.DisplayMember = "nombre";
            lstEditorial.ValueMember = "id";
            dgvLibros.DataSource = biblioteca.ListarTodosLosLibros();

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = "mostrar ejemplares";
            btn.HeaderText = "mostrar ejemplares";
            btn.Name = "btnEjemplares";
            btn.UseColumnTextForButtonValue = true;

            dgvLibros.Columns.Add(btn);

        }

        private void lstEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {

            dgvLibros.DataSource = biblioteca.ListarLibrosPorEditorial(lstEditorial.Text);
        }

        private void dgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3) {
                int i = dgvLibros.CurrentRow.Index;
                MessageBox.Show("Sigue mostrar los ejemplares de: " + dgvLibros.Rows[i].Cells["nombre"].Value.ToString());
            }
        }
    }
}
