using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SistemaCatalogoBiblioteca
{
    class ManipulacionBD
    {
        private SqlConnection con;

        public ManipulacionBD() {
            con = new SqlConnection("server=SYN\\SQLEXPRESS;integrated security=true;database=biblioteca; MultipleActiveResultSets=True");
            try
            {
                con.Open();
            }
            catch (Exception e) 
            {
                System.Windows.Forms.MessageBox.Show("Error en la conexión a la base de datos...");
            }
        }

        public DataTable ListarTodosLosLibros() {
            SqlCommand consultaA = new SqlCommand();
            consultaA.Connection = con;
            consultaA.CommandText = "select l.nombre, e.nombre editorial, l.edicion from libros l " +
                                    "join editorial e on l.ideditorial = e.id";                                    
            DataTable dtA = new DataTable();
            dtA.Load(consultaA.ExecuteReader());
            return dtA;
        }

        public DataTable ListarTodasLasEditoriales()
        {
            SqlCommand consultaA = new SqlCommand();
            consultaA.Connection = con;
            consultaA.CommandText = "select * from editorial";
            SqlDataAdapter registros = new SqlDataAdapter(consultaA);
            DataTable dt = new DataTable();
            registros.Fill(dt);
            return dt;
        }

        public DataTable ListarLibrosPorEditorial(String idEditorial)
        {
            SqlCommand consultaA = new SqlCommand();
            consultaA.Connection = con;
            consultaA.CommandText = "select l.nombre, e.nombre editorial, l.edicion from libros l " +
                                    "join editorial e on l.ideditorial = e.id " +
                                    "where e.nombre = @nomE";
            consultaA.Parameters.Add("@nomE", SqlDbType.VarChar).Value = idEditorial;
            DataTable dtA = new DataTable();
            dtA.Load(consultaA.ExecuteReader());
            return dtA;
        }

    }
}
