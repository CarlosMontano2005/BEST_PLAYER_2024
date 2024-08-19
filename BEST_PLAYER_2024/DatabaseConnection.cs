using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BEST_PLAYER_2024
{
    class DatabaseConnection
    {
        private string _connectionString;

        public DatabaseConnection(string serverName, string database, string username = "sa")
        {
            _connectionString = $"Server={serverName};Database={database};Integrated Security = true";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public string TestConnection()
        {
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    return "Conexión exitosa a base : "+ connection.Database;
                }
                catch (Exception ex)
                {
                    return "Error de conexión: " + ex.Message;
                }
            }
        }
    }
}
