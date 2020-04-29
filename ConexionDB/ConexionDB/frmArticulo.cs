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

        public frmArticulo()
        {
            InitializeComponent();
            conexion = new SqlConnection("server=SYN\\SQLEXPRESS;database=base1;integrated security=true;MultipleActiveResultSets=True");
            conexion.Open();
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

            //llenar el datagridview
            SqlCommand consultaA = new SqlCommand();
            consultaA.Connection = conexion;
            consultaA.CommandText = "select A.CodigoArticulo 'Código Artículo', A.Descripcion, A.precio, A.CodigoProv 'Código proveedor', P.NombreComercial 'Nombre proveedor', C.CodigoCategoria, C.NombreCategoria from Articulos A "+
                                    "join Proveedores P on P.CodigoProveedor = A.CodigoProv "+
                                    "join Categorias C on C.CodigoCategoria = A.CodigoCat";

            DataTable dtA = new DataTable();
            dtA.Load(consultaA.ExecuteReader());
            dgvArt.DataSource = dtA;
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
        }
    }
}
