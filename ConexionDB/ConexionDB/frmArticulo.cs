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
    public partial class frmArticulo : Form
    {
        private SqlConnection conexion;
        private string codigooriginal;

        public frmArticulo()
        {
            InitializeComponent();
            try
            {
                conexion = new SqlConnection("server=SYN\\SQLEXPRESS;database=bas1;integrated security=true;MultipleActiveResultSets=True");
                conexion.Open();
            }
            catch (Exception e) {
                MessageBox.Show("Error, contacte al administrador");
                Application.Exit();
            }
            
        }

        private void actualizarDataGrid() {
            //llenar el datagridview
            SqlCommand consultaA = new SqlCommand();
            consultaA.Connection = conexion;
            consultaA.CommandText = "select A.CodigoArticulo 'Código Artículo', A.Descripcion, A.precio, A.CodigoProv 'Código proveedor', P.NombreComercial 'Nombre proveedor', C.CodigoCategoria, C.NombreCategoria from Articulos A " +
                                    "join Proveedores P on P.CodigoProveedor = A.CodigoProv " +
                                    "join Categorias C on C.CodigoCategoria = A.CodigoCat";

            DataTable dtA = new DataTable();
            dtA.Load(consultaA.ExecuteReader());
            dgvArt.DataSource = dtA;
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            //llenar el combobox de proveedores
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = conexion;
            consulta.CommandText = "select CodigoProveedor,NombreComercial from Proveedores";
            SqlDataAdapter registros = new SqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            registros.Fill(dt);
            cmbPro.DataSource = dt;
            cmbPro.DisplayMember = "NombreComercial";
            cmbPro.ValueMember = "CodigoProveedor";

            //llenar el combobox de categorias
            SqlCommand consultac = new SqlCommand();
            consultac.Connection = conexion;
            consultac.CommandText = "select * from Categorias";
            SqlDataAdapter registrosc = new SqlDataAdapter(consultac);
            DataTable dtc = new DataTable();
            registrosc.Fill(dtc);
            cmbCat.DataSource = dtc;
            cmbCat.DisplayMember = "NombreCategoria";
            cmbCat.ValueMember = "CodigoCategoria";

            actualizarDataGrid();
        }

        private void frmArticulo_FormClosing(object sender, FormClosingEventArgs e)
        {
            conexion.Close();            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand();
            query.Connection = conexion;
            query.CommandText = "insert into Articulos values(@cod,@des,@pre,@pro,@cat);";
            query.Parameters.Add("@cod", SqlDbType.VarChar).Value = txtCod.Text;
            query.Parameters.Add("@des", SqlDbType.VarChar).Value = txtDes.Text;
            query.Parameters.Add("@pre", SqlDbType.Float).Value = txtPre.Value;
            query.Parameters.Add("@pro", SqlDbType.VarChar).Value = cmbPro.SelectedValue;
            query.Parameters.Add("@cat", SqlDbType.VarChar).Value = cmbCat.SelectedValue;
            query.ExecuteNonQuery();
            txtCod.Clear();
            txtDes.Clear();
            txtPre.Value = 0;
            txtCod.Select();
            MessageBox.Show("Artículo agregado correctamente");
            SqlCommand consultaA = new SqlCommand();
            consultaA.Connection = conexion;
            consultaA.CommandText = "select A.CodigoArticulo 'Código Artículo', A.Descripcion, A.precio, A.CodigoProv 'Código proveedor', P.NombreComercial 'Nombre proveedor', C.CodigoCategoria, C.NombreCategoria from Articulos A " +
                                    "join Proveedores P on P.CodigoProveedor = A.CodigoProv " +
                                    "join Categorias C on C.CodigoCategoria = A.CodigoCat";

            DataTable dtA = new DataTable();
            
            SqlDataAdapter consultaEjecutada = new SqlDataAdapter(consultaA);
            consultaEjecutada.Fill(dtA);
            dgvArt.DataSource = dtA;
        }

        private void dgvArt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvArt.CurrentRow.Index;            
            txtCod.Text = dgvArt.Rows[i].Cells["Código Artículo"].Value.ToString();
            txtDes.Text = dgvArt.Rows[i].Cells["Descripcion"].Value.ToString();
            txtPre.Text = dgvArt.Rows[i].Cells["precio"].Value.ToString();
            cmbCat.Text = dgvArt.Rows[i].Cells["NombreCategoria"].Value.ToString();
            cmbPro.Text = dgvArt.Rows[i].Cells["Nombre proveedor"].Value.ToString();
            codigooriginal = txtCod.Text;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Visible = false;
        }


        private void dgvArt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SqlCommand cambiarArticulo = new SqlCommand();
            cambiarArticulo.Connection = conexion;
            cambiarArticulo.CommandText = "update Articulos set CodigoArticulo  = @ca,Descripcion = @de,precio  = @pe,CodigoProv  = @cp, CodigoCat  = @cc where CodigoArticulo  = @codOriginal;";
            cambiarArticulo.Parameters.Add("@ca", SqlDbType.VarChar).Value = txtCod.Text;
            cambiarArticulo.Parameters.Add("@de", SqlDbType.VarChar).Value = txtDes.Text;
            cambiarArticulo.Parameters.Add("@pe", SqlDbType.Float).Value =  txtPre.Text;
            cambiarArticulo.Parameters.Add("@cp", SqlDbType.VarChar).Value = cmbPro.SelectedValue;
            cambiarArticulo.Parameters.Add("@cc", SqlDbType.VarChar).Value = cmbCat.SelectedValue;
            cambiarArticulo.Parameters.Add("@codOriginal", SqlDbType.VarChar).Value = codigooriginal;
            cambiarArticulo.ExecuteNonQuery();
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Visible = true;
            txtCod.Clear();
            txtDes.Clear();
            txtPre.Value = 0;
            actualizarDataGrid();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            //abrir el formulario de gestion de categorias
            frmCategorias f = new frmCategorias(txtDes.Text, txtPre.Text, cmbCat.SelectedValue.ToString(),dgvArt);
            f.ShowDialog();

            //volver a ejecutar "select * from..."

            string mensaje = "";
            mensaje = f.datos.Rows[0].Cells[1].Value.ToString();
            MessageBox.Show(mensaje);

        }
    }
}


