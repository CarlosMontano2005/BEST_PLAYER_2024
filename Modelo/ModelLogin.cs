﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Configuracion;

namespace Modelo
{
    public class ModelLogin
    {
        public static bool ValidarLogin(string correo, string clave,out int idUsuario, out string nombreUsuario,out string nivelUsuario, out byte[] fotoUsuario,out string message)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            DataTable data = new DataTable();
            nombreUsuario = string.Empty;
            nivelUsuario = string.Empty;
            fotoUsuario = null;
            idUsuario = 0;
            try
            {
                string query = "SELECT IdUsuario, NombreUsuario, Foto, Correo,  Nivel_Usuario ,Clave FROM Usuarios WHERE Correo = @Correo AND Clave = @Clave";/**/
                using (SqlConnection connection = dbConnection.GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Clave", clave);

                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idUsuario = Convert.ToInt32(reader["IdUsuario"].ToString());
                            correo = reader["Correo"].ToString();
                            nombreUsuario = reader["NombreUsuario"].ToString();
                            nivelUsuario = reader["Nivel_Usuario"].ToString();
                            if (reader["Foto"] != DBNull.Value)
                            {
                                fotoUsuario = (byte[])reader["Foto"];  
                            }
                            message = "Login exitoso";
                            return true;
                        }
                        else
                        {
                            message = "Usuario o contraseña incorrectos.";
                            return false;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                message = DatabaseValidations.FormatSqlErrorMessage(ex);
                return false;
            }
        }


    }
}
