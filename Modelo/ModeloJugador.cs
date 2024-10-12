using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Configuracion;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloJugador
    {
        public static DataTable cargarJugador(out string message,int id) {
            DatabaseConnection dbConnection = new DatabaseConnection();
            DataTable data = new DataTable();
            try {
                string query = "SELECT CONCAT(b.Nombre,' ',b.Apellido) as NombreJugador,a.Posicion,c.Nacionalidad,a.NumeroCamisa,a.PartidosJugados,b.DescripcionJugador,a.Asistencias,a.TargetasAmarillas,a.TargetasRojas,a.Goles FROM Jugadores b INNER JOIN EstadisticaJugadores a ON a.IdJugador=b.IdJugador JOIN Paises c ON b.IdPais=c.IdPais WHERE b.IdJugador=@idjugador";
                // Obtén la conexión SQL Server usando la instancia de DatabaseConnection
                using (SqlConnection connection = dbConnection.GetConnection())
                using (SqlCommand cmdselect = new SqlCommand(query, connection))
                using (SqlDataAdapter adp = new SqlDataAdapter(cmdselect))
                {
                    cmdselect.Parameters.Add("@idjugador", SqlDbType.Int).Value = id;
                    connection.Open();
                    adp.Fill(data);
                }
            }
            catch (Exception ex) {
                message = $"Error al cargar datos: {ex.Message}";
                data = null;
            }
            message = null;
            return data;
        }
        public static DataTable cargarJugadores(out string message) {
            DatabaseConnection dbConnection = new DatabaseConnection();
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT a.IdJugador,a.Nombre,a.Apellido,b.Nombre AS NombreEquipo,c.Nacionalidad,a.Altura FROM Jugadores a INNER JOIN Equipos b ON a.IdEquipo = b.IdEquipo JOIN Paises c ON a.IdPais = c.IdPais";
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
    }
}
