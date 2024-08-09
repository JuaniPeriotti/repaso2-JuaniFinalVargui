using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace repaso2_JuaniFinalVargui
{
    public class conexionBD
    {
        OleDbCommand comando;
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        string cadena;

        public conexionBD(string connectionString)
        {
            conexion = new OleDbConnection(connectionString);
        }

        public void abrirConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Open();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cerrar la conexión: " + ex.Message);
    
            }
        }

        public conexionBD()
        {
            cadena = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./HELADITO.mdb;";
        }

        public List<Dictionary<string, string>> obtenerSaboresYTipos()
        {
            List<Dictionary<string,string>> listaDeSabores = new List<Dictionary<string,string>>();
            try
            {
                string query = "SELECT nombre, tipo FROM Gustos";
                OleDbCommand comando = new OleDbCommand(query, conexion);
                using(OleDbDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read()) 
                    {
                        Dictionary<string, string> diccionario = new Dictionary<string, string>
                        {
                            { "nombre", reader["nombre"].ToString() },
                            { "tipo", reader["tipo"].ToString() }
                        };
                        listaDeSabores.Add(diccionario);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener los sabores y tipos: " + ex.Message);
            }
            return listaDeSabores;
        }
    }
}
