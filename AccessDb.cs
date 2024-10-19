using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace ImportadorRemisiones
{
    internal class AccessDb
    {
        static readonly string ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\tipocambio.accdb;Persist Security Info=False;";
        
        public static void InsertarTc(string tc)
        {
            // string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\tipocambio.accdb;Persist Security Info=False;";

            string query = "UPDATE tipo_cambio set tipo_cambio=@tc, fecha_creacion=@fecha WHERE Id=1";

            using (OleDbConnection connection = new OleDbConnection(ConnString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tc", tc);
                    command.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("dd/MM/yyyy"));
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static string GetTc()
        {
            // string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\tipocambio.accdb;Persist Security Info=False;";
            
            string query = "SELECT tipo_cambio FROM tipo_cambio WHERE Id=1";
            string tc = string.Empty;

            using (OleDbConnection connection = new OleDbConnection(ConnString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    connection.Open();
                    tc = command.ExecuteScalar().ToString();
                }
            }

            return tc;
        }

    }
}
