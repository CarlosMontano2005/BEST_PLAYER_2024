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
        public static DataTable CargarUsuario(out string message)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            DataTable data = new DataTable();

            try
            {
                string query = "SELECT U.IdUsuario, U.NombreUsuario, U.Correo, U.FechaNacimiento, U.Foto, U.Pasaporte, U.Nivel_Usuario, A.NombreAgencia " + " FROM Usuarios U INNER JOIN Agencias A ON U.IdAgencia = A.IdAgencia; ";
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

      

        public static bool EliminarUsuario(int idUsuario, out string message)
        {
            DatabaseConnection con = new DatabaseConnection();
            try
            {
                //query para la eleiminacion del dato con su paramentro @idusuario
                string query = "DELETE Usuarios WHERE IdUsuario = @idusuario";
                //verificar conexion
                using (SqlConnection connection = con.GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                   
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    //conectamos
                    connection.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        message = "Eliminado Exitosamente";
                        return true;
                    }
                    else
                    {
                        message = "No se no se pudo eliminar ningún registro.";
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
                message = $"Error al eliminar el usuario: {ex.Message}";
                return false;
            }
        }

        public static DataTable CargarAgencias(out string message)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            DataTable data = new DataTable(); // Inicializar aquí para evitar problemas de null

            try
            {
                string query = "SELECT * FROM Agencias ORDER BY TipoAgencia";

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

        public static bool ActualizarUsuario(string nombreUsuario, string correo, string fechaNacimiento, byte[] foto, string pasaporte, string nivelUsuario, int idAgencia, int IdUsuario/* ID DEL USUARIO ACTUALIZAR*/, out string message)
        {
            //Clase de conexion a la base de datos
            DatabaseConnection dbConnection = new DatabaseConnection();
            //metodo try cash para salida de errores o exepciones
            try
            {
                //
                string query = "UPDATE [dbo].[Usuarios] SET [NombreUsuario] = @NombreUsuario, [Correo] = @Correo, [FechaNacimiento] = @FechaNacimiento, [Foto] = @Foto, [Pasaporte] = @Pasaporte, [Nivel_Usuario] = @NivelUsuario, [IdAgencia] = @IdAgencia WHERE IdUsuario = @IdUsuario";
                using (SqlConnection connection = dbConnection.GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                    cmd.Parameters.Add("@Foto", SqlDbType.VarBinary).Value = (object)foto ?? DBNull.Value;
                    cmd.Parameters.AddWithValue("@Pasaporte", (object)pasaporte ?? DBNull.Value); // NULL
                    cmd.Parameters.AddWithValue("@NivelUsuario", nivelUsuario);
                    cmd.Parameters.AddWithValue("@IdAgencia", idAgencia);
                    cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario);

                    connection.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        message = "Actualizado Exitosamente";
                        return true;
                    }
                    else
                    {
                        message = "No se actualizo ningún registro.";
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
                message = $"Error al actualizar el usuario: {ex.Message}";
                return false;
            }
        }

        public static bool InsertarUsuario(string nombreUsuario, string correo, string fechaNacimiento, string clave, byte[] foto, string pasaporte, string nivelUsuario, int idAgencia, out string message)
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
                    cmd.Parameters.Add("@Foto", SqlDbType.VarBinary).Value = (object)foto ?? DBNull.Value;
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
                message = $"Error de SQL: {DatabaseValidations.FormatSqlErrorMessage(ex)}"; 
                return false;
            }
            catch (Exception ex)
            {
                message = $"Error general al insertar el usuario: {ex.Message}"; 
                return false;
            }

        }
        public static bool ActualizarClave(int idUsuario, string clave, out string message)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();

            try
            {
                string query = "UPDATE Usuarios SET Clave = @clave WHERE IdUsuario = @idUsuario";
                using (SqlConnection connection = dbConnection.GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@clave", clave);
                    connection.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        message = "Actualizado Clave Exitoso";
                        return true;
                    }
                    else
                    {
                        message = "No se actualizo ningún registro.";
                        return false;
                    }
                }
            }
            catch (SqlException ex)
            {
                message = $"Error de SQL: {DatabaseValidations.FormatSqlErrorMessage(ex)}";
                return false;
            }
            catch (Exception ex)
            {
                message = $"Error general al insertar el usuario: {ex.Message}";
                return false;
            }

        }

    }
}