using MySql.Data.MySqlClient;
using MySqlConnector;
using System;
using System.Data;
using MySqlCommand = MySql.Data.MySqlClient.MySqlCommand;
using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;
using MySqlDataAdapter = MySql.Data.MySqlClient.MySqlDataAdapter;

namespace FormularioSimple.DataAccess
{
    internal class Conection
    {
        public bool try_Conection(string cad_Connection) 
        {
            try
            {
                using (var connection = new MySqlConnection(cad_Connection))
                {
                    connection.Open();
                    return true;
                }
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable get_Data(string cad_Connection)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var connection = new MySqlConnection(cad_Connection))
                {
                    connection.Open();
                    string query = "SELECT * FROM CatPersonal";
                    using (var command = new MySqlCommand(query, connection))
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error to get information", ex.Message);
            }
            return dt;
        }

    }
}
