﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Configuracion;
namespace Configuracion
{
    public class DatabaseConnection
    {
        private string _connectionString;

        private const string DefaultServerName = "localhost";
        private const string DefaultDatabase = "DBVotacionJugadores_Nueva";
        private const string DefaultUsername = "sa";
        private const string DefaultPassword = "123456";
        private const string DefaultPort = "1433";

        public DatabaseConnection(
            string serverName = DefaultServerName,
            string database = DefaultDatabase,
            string username = DefaultUsername,
            string password = DefaultPassword,
            string port = DefaultPort)
        {
            _connectionString = $"Server={serverName};Database={database};Integrated Security = true";

        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public GetSetConexion TestConnection()
        {
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    return new GetSetConexion
                    {
                        IsSuccess = true,
                        Message = $"Conexión exitosa a base: {connection.Database}"
                    };
                }
                catch (Exception ex)
                {
                    return new GetSetConexion
                    {
                        IsSuccess = false,
                        Message = $"Error de conexión: {ex.Message}"
                    };
                }
            }
        }
    }
}
