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
        public static DataTable cargarEquipo(out string message) {
            DatabaseConnection dbConnection = new DatabaseConnection();
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT idEquipo,Nombre FROM Equipos";
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
        public static DataTable cargarNacionalidad(out string message) {

            DatabaseConnection dbConnection = new DatabaseConnection();
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT IdPais,Nacionalidad FROM Paises";
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
        public static bool InsertarJugador(string nombre, string apellido, string descripcion, int equipo, int pais, string fecha_nac, float altura, byte[] foto,out string message ) {
            DatabaseConnection dbConnection = new DatabaseConnection();

            try
            {
                string query = "INSERT INTO Jugadores(Nombre,Apellido,DescripcionJugador,IdEquipo,IdPais,Edad, Altura,Foto) VALUES(@NombreJugador,@ApellidoJugador,@Descripcion,@IdEquipo,@IdPais,@FechaNac,@Altura,@Foto)";
                using (SqlConnection connection = dbConnection.GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@NombreJugador", nombre);
                    cmd.Parameters.AddWithValue("@ApellidoJugador", apellido);
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@IdEquipo", equipo);
                    cmd.Parameters.AddWithValue("@IdPais", pais);
                    cmd.Parameters.AddWithValue("@FechaNac", fecha_nac);
                    cmd.Parameters.AddWithValue("@Altura", altura);
                    cmd.Parameters.Add("@Foto", SqlDbType.VarBinary).Value = (object)foto ?? DBNull.Value;
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
            catch (SqlException ex) {
                message = $"Error de SQL: {DatabaseValidations.FormatSqlErrorMessage(ex)}";
                return false;
            }
        }
        public static bool EliminarJugador(int idjugador, out string message) {
            DatabaseConnection dbConnection = new DatabaseConnection();

            try
            { 
                string query = "DELETE FROM Jugadores WHERE IdJugador=@idjugador";
                using (SqlConnection connection = dbConnection.GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@idjugador", idjugador);
                    connection.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        message = "Eliminado Exitosamente";
                        return true;
                    }
                    else
                    {
                        message = "No se Elimino ningún registro.";
                        return false;
                    }
                }
            }
            catch (SqlException ex)
            {
                message = $"Error de SQL: {DatabaseValidations.FormatSqlErrorMessage(ex)}";
                return false;
            }
        }
    }
}
