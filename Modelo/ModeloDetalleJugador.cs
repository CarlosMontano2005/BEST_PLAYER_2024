using System;
using System.Collections.Generic;
using System.Data;
using Configuracion;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloDetalleJugador
    {
        public static bool InsertarDetalleJugador(int jugador,string posicion, int numcamisa, int partidos, int goles,float porcentajeG,int asistencias,int TA, int TR, out string message)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();

            try
            {
                string query = "INSERT INTO EstadisticaJugadores(IdJugador,Posicion,NumeroCamisa,PartidosJugados,Goles,PorcentajeGoles,Asistencias,TargetasAmarillas,TargetasRojas) VALUES(@jugador,@posicion,@numerocam,@partidos,@goles,@porcentaje,@asistencias,@tarjetasA,@tarjetasR)";
                using (SqlConnection connection = dbConnection.GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@jugador", jugador);
                    cmd.Parameters.AddWithValue("@posicion", posicion);
                    cmd.Parameters.AddWithValue("@numerocam", numcamisa);
                    cmd.Parameters.AddWithValue("@partidos", partidos);
                    cmd.Parameters.AddWithValue("@goles", goles);
                    cmd.Parameters.AddWithValue("@porcentaje", porcentajeG);
                    cmd.Parameters.AddWithValue("@asistencias", asistencias);
                    cmd.Parameters.AddWithValue("@TarjetasA", TA);
                    cmd.Parameters.AddWithValue("@tarjetasR", TR);
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
        }
        public static DataTable searchIdJugador(out string message,string name,string apellido) {
            DatabaseConnection dbConnection = new DatabaseConnection();
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT IdJugador FROM Jugadores WHERE Nombre=@nombre AND Apellido=@apellido";
                // Obtén la conexión SQL Server usando la instancia de DatabaseConnection
                using (SqlConnection connection = dbConnection.GetConnection())
                using (SqlCommand cmdselect = new SqlCommand(query, connection))
                using (SqlDataAdapter adp = new SqlDataAdapter(cmdselect))
                {
                    cmdselect.Parameters.Add("@nombre", SqlDbType.VarChar).Value = name;
                    cmdselect.Parameters.Add("@apellido", SqlDbType.VarChar).Value = apellido;
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
