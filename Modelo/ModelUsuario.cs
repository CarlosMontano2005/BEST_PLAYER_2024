using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Configuracion;
namespace Modelo
{
    public class ModelUsuario
    {
        public static DataTable CargarAgencias(out string message)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            DataTable data = new DataTable(); // Inicializar aquí para evitar problemas de null

            try
            {
                string query = "SELECT IdAgencia, NombreAgencia FROM Agencias";

                // Obtén la conexión SQL Server usando la instancia de DatabaseConnection
                using (SqlConnection connection = dbConnection.GetConnection())
                using (SqlCommand cmdselect = new SqlCommand(query, connection))
                using (SqlDataAdapter adp = new SqlDataAdapter(cmdselect))
                {
                    connection.Open();
                    adp.Fill(data);
                }
            }
            catch (Exception ex)
            {
                message = $"Error al cargar datos: {ex.Message}";
                data = null; 
            }
            message = null;
            return data;
        }


        public static bool InsertarUsuario(string nombreUsuario, string correo, string fechaNacimiento, string clave, string foto, string pasaporte, string nivelUsuario, int idAgencia, out string message)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();

            try
            {
                string query = "INSERT INTO Usuarios (NombreUsuario, Correo, FechaNacimiento, Clave, Foto, Pasaporte, Nivel_Usuario, IdAgencia) " +
                               "VALUES (@NombreUsuario, @Correo, @FechaNacimiento, @Clave, @Foto, @Pasaporte, @NivelUsuario, @IdAgencia)";

                using (SqlConnection connection = dbConnection.GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                    cmd.Parameters.AddWithValue("@Clave", clave);
                    cmd.Parameters.AddWithValue("@Foto", (object)foto ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Pasaporte", (object)pasaporte ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@NivelUsuario", nivelUsuario);
                    cmd.Parameters.AddWithValue("@IdAgencia", idAgencia);

                    connection.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        message = "Agregado Exitosamente";
                        return true;
                    }
                    else
                    {
                        message = "No se insertó ningún registro.";
                        return false;
                    }
                }
            }
             catch (SqlException ex)
    {
        message = DatabaseValidations.FormatSqlErrorMessage(ex);
        return false;
    }
            catch (Exception ex)
            {
                message = $"Error al insertar el usuario: {ex.Message}";
                return false;
            }
        }

    }
}
