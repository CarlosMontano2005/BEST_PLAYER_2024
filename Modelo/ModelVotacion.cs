using Configuracion;
using Controlador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModelVotacion
    {
        //CARGAR TOP 10 JUGADORES DE MANERA ALEATORIA
        public static DataTable CargarTopJugadoresAleatorio(out string message)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT TOP 10 J.IdJugador, CONCAT(J.Nombre,' ',J.Apellido)AS nomJugador,E.Nombre, J.Foto " +
                    "  FROM Jugadores J " +
                    " INNER JOIN Equipos E ON J.IdEquipo = E.IdEquipo " +
                    " ORDER BY NEWID();";

                using (SqlConnection connection = dbConnection.GetConnection())
                using (SqlCommand cmdselect = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmdselect))
                {
                    connection.Open();
                    adapter.Fill(data);
                }
            }
            catch (Exception ex)
            {

                message = $"Error al cargar top jugadores: {ex.Message}";
                data = null;
            }
            message = null;
            return data;
        }
        //CARGAR TOP 10 JUGADORES DE EQUIPO
        public static DataTable CargarTopJugadoresEquipo(out string message, string nombreEquipo)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT TOP 10 J.IdJugador, CONCAT(J.Nombre,' ',J.Apellido)AS nomJugador,E.Nombre, J.Foto  " +
                    "  FROM Jugadores J "+
                    " INNER JOIN Equipos E ON J.IdEquipo = E.IdEquipo  "+
                    " WHERE E.Nombre = @NombreEquipo "+
                    " ORDER BY J.IdJugador desc;";

                using (SqlConnection connection = dbConnection.GetConnection())
                using (SqlCommand cmdselect = new SqlCommand(query, connection))
                using(SqlDataAdapter adapter = new SqlDataAdapter(cmdselect))
                {
                    cmdselect.Parameters.AddWithValue("@NombreEquipo", nombreEquipo);
                    connection.Open();
                    adapter.Fill(data);
                }
            }
            catch (Exception ex)
            {

                message = $"Error al cargar top jugadores: {ex.Message}";
                data = null;
            }
            message = null;
            return data;
        }

        public static DataTable VerificarVotoUsuario(out string message)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            DataTable data = new DataTable();

            try
            {
                string query = "SELECT IdUsuario, IdJugador, FechaHoraVoto, COUNT(*) AS TotalVotos "+
                    "FROM Votacion "+
                    "WHERE IdUsuario = @idUsuario "+
                    "GROUP BY IdUsuario, IdJugador, FechaHoraVoto;";
                // Obtén la conexión SQL Server usando la instancia de DatabaseConnection
                using (SqlConnection connection = dbConnection.GetConnection())
                using (SqlCommand cmdselect = new SqlCommand(query, connection))
                using (SqlDataAdapter adp = new SqlDataAdapter(cmdselect))
                {
                    cmdselect.Parameters.AddWithValue("@idUsuario", SesionUsuario.IdUsuario);
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

        public static bool InsertarVoto(int idJugadore, string fechaHoraVoto, out string message)
        {

            DatabaseConnection dbConnection = new DatabaseConnection();
            try
            {
                string query = "INSERT INTO Votacion(IdUsuario, IdJugador, FechaHoraVoto) " + 
                    "VALUES(@IdUsuario, @IdJugador, @FechaHoraVoto)";
                using (SqlConnection connection = dbConnection.GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@IdUsuario", SesionUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("@IdJugador", idJugadore);
                    cmd.Parameters.AddWithValue("@FechaHoraVoto", fechaHoraVoto);
                    connection.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        message = "Voto Agregado Exitosamente";
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
                message = $"Error general al insertar el voto: {ex.Message}";
                return false;
            }
        }
    }
}
