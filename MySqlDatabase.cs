using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace ImportadorRemisiones
{
    class MySqlDatabase
    {
        public string Connstring { get; set; }

        public MySqlDatabase()
        {
            string server = string.Format(ConfigurationManager.AppSettings["Server"]);
            string database = string.Format(ConfigurationManager.AppSettings["Database"]);
            string user = string.Format(ConfigurationManager.AppSettings["Username"]);
            string password = string.Format(ConfigurationManager.AppSettings["Password"]);

            Connstring = "Server=" + server + ";Database=" + database + ";Uid=" + user + ";Pwd=" + password +
                         ";persistsecurityinfo=True;";
        }

        public void NoResultQuery(string query)
        {
            MySqlConnection conn = new MySqlConnection(Connstring);

            try
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();

                conn.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error: " + e.ToString());
            }
        }

        public DataTable ResultQuery(string query)
        {
            DataSet ds = new DataSet();

            try
            {
                MySqlConnection conn = new MySqlConnection(Connstring);
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                adapter.Fill(ds);

                conn.Close();

                return ds.Tables[0];
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error: " + e.ToString());
            }
            return null;
        }

        public void InsertarTc(string tc)
        {
            string query = "UPDATE tipo_cambio set tipo_cambio=@tc, fecha_creacion=@fecha WHERE Id=1";

            using (MySqlConnection connection = new MySqlConnection(Connstring))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tc", tc);
                    command.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy-MM-dd"));
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }
        }

        public float GetTc()
        {
            string query = "SELECT tipo_cambio FROM tipo_cambio WHERE Id=1 LIMIT 1";
            float tc = 0;

            using (MySqlConnection connection = new MySqlConnection(Connstring))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    float.TryParse(command.ExecuteScalar().ToString(), out tc);

                    connection.Close();
                }
            }

            return tc;
        }
    }
}
