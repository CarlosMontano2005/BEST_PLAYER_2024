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

        public static bool ActualizarDetalleJugador(int idjugadordetalle, int jugador, string posicion, int numcamisa, int partidos, int goles, float porcentajeG, int asistencias, int TA, int TR, out string message)
        {
            {
                DatabaseConnection dbConnection = new DatabaseConnection();

                try
                {
                    string query = "UPDATE EstadisticaJugadores SET IdJugador=@jugador, Posicion=@posicion,NumeroCamisa=@numerocam,PartidosJugados=@partidos,Goles=@goles,PorcentajeGoles=@porcentaje,Asistencias=@asistencias,TargetasAmarillas=@TarjetasA,TargetasRojas=@tarjetasR WHERE IdEstadisticaJugador=@iddetalle";
                    using (SqlConnection connection = dbConnection.GetConnection())
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("iddetalle",idjugadordetalle);
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


        public static DataTable buscarDetalle(out string message, int id_jugador) {
            DatabaseConnection dbConnection = new DatabaseConnection();
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT * FROM EstadisticaJugadores WHERE IdJugador=@idjugador";
                // Obtén la conexión SQL Server usando la instancia de DatabaseConnection
                using (SqlConnection connection = dbConnection.GetConnection())
                using (SqlCommand cmdselect = new SqlCommand(query, connection))
                using (SqlDataAdapter adp = new SqlDataAdapter(cmdselect))
                {
                    cmdselect.Parameters.Add("@idjugador", SqlDbType.Int).Value = id_jugador;
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

        public static DataTable buscarJugadoreEquipo(out string message, int id_Equipo)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT J.Nombre, J.Apellido, Ej.Posicion, J.foto FROM Jugadores J, EstadisticaJugadores Ej WHERE J.IdJugador = Ej.IdJugador AND J.IdEquipo = @idequipo";
                // Obtén la conexión SQL Server usando la instancia de DatabaseConnection
                using (SqlConnection connection = dbConnection.GetConnection())
                using (SqlCommand cmdselect = new SqlCommand(query, connection))
                using (SqlDataAdapter adp = new SqlDataAdapter(cmdselect))
                {
                    cmdselect.Parameters.Add("@idequipo", SqlDbType.Int).Value = id_Equipo;
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
        public static bool ActualizarLogoEquipo(byte[] logoEquipo, int IdEquipo, out string message)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            try
            {
                string query = "UPDATE Equipos SET FotoLogoEquipo = @logoEquipo WHERE IdEquipo = @IdEquipo";
                using (SqlConnection connection = dbConnection.GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Si el logo es obligatorio, verificar que no sea null
                    if (logoEquipo == null || logoEquipo.Length == 0)
                    {
                        message = "El logo del equipo es obligatorio.";
                        return false;
                    }
                    cmd.Parameters.Add("@logoEquipo", SqlDbType.VarBinary).Value = logoEquipo;
                    cmd.Parameters.Add("@IdEquipo", SqlDbType.Int).Value = IdEquipo;
                    connection.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        message = "Actualización del logo del equipo exitosa.";
                        return true;
                    }
                    else
                    {
                        message = "No se actualizó ningún registro.";
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
                message = $"Error al actualizar el logo: {ex.Message}";
                return false;
            }
        }
        public static bool ActualizarFotoDT(byte[] FotoDT, int IdEquipo, out string message)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            try
            {
                string query = "UPDATE Equipos SET Foto_DT = @FotoDT WHERE IdEquipo = @IdEquipo";
                using (SqlConnection connection = dbConnection.GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Si el logo es obligatorio, verificar que no sea null
                    if (FotoDT == null || FotoDT.Length == 0)
                    {
                        message = "El logo del equipo es obligatorio.";
                        return false;
                    }
                    cmd.Parameters.Add("@FotoDT", SqlDbType.VarBinary).Value = FotoDT;
                    cmd.Parameters.Add("@IdEquipo", SqlDbType.Int).Value = IdEquipo;
                    connection.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        message = "Actualización de la foto del director tecnico del equipo exitosa.";
                        return true;
                    }
                    else
                    {
                        message = "No se actualizó ningún registro.";
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
                message = $"Error al actualizar el logo: {ex.Message}";
                return false;
            }
        }

    }

}
