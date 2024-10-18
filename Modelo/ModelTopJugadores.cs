using Configuracion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModelTopJugadores
    {
        public static DataTable CargarTop5Jugadore (out string mensage){
            DatabaseConnection dbConection = new DatabaseConnection();
            DataTable data = new DataTable(); 
            try
            {
                string query = "SELECT TOP 5 COUNT(A.IdJugador) AS cantidadVotos, " +
                "B.Nombre, " +
                "B.Apellido, " +
                "B.Foto, " +
                "D.Nombre AS NombreEquipo, " +
                "C.Nombre AS NombrePais " +
                "FROM Votacion A " + 
                "JOIN Jugadores B ON A.IdJugador = B.IdJugador " +
                "JOIN Paises C ON B.IdPais = C.IdPais " + 
                "JOIN Equipos D ON D.IdEquipo = B.IdEquipo " + 
                "GROUP BY B.Nombre, B.Apellido, B.IdEquipo, D.Nombre, C.Nombre, B.Foto " + 
                "ORDER BY cantidadVotos DESC";

                using (SqlConnection connection = dbConection.GetConnection())
                using (SqlCommand cmdslect = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmdslect))
                {
                    connection.Open();
                    adapter.Fill(data);
                }
            }
            catch (Exception ex)
            {

                mensage = $"Error al cargar los datos de Top Votaciones {ex.Message}";
                data = null;
            }
            mensage = null;
            return data;
        }
        public static DataTable CargarJugadoresVotadosLista(out string mensage)
        {
            DatabaseConnection dbConection = new DatabaseConnection();
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT COUNT(A.IdJugador) AS cantidadVotos, " +
                "B.Nombre, " +
                "B.Apellido, " +
                "B.Foto, " +
                "D.Nombre AS NombreEquipo, " +
                "C.Nombre AS NombrePais " +
                "FROM Votacion A " +
                "JOIN Jugadores B ON A.IdJugador = B.IdJugador " +
                "JOIN Paises C ON B.IdPais = C.IdPais " +
                "JOIN Equipos D ON D.IdEquipo = B.IdEquipo " +
                "GROUP BY B.Nombre, B.Apellido, B.IdEquipo, D.Nombre, C.Nombre, B.Foto " +
                "ORDER BY cantidadVotos DESC, NombreEquipo ASC;";

                using (SqlConnection connection = dbConection.GetConnection())
                using (SqlCommand cmdslect = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmdslect))
                {
                    connection.Open();
                    adapter.Fill(data);
                }
            }
            catch (Exception ex)
            {

                mensage = $"Error al cargar los datos de Top Votaciones {ex.Message}";
                data = null;
            }
            mensage = null;
            return data;
        }
    }
}
