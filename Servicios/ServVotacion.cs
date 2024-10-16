using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class ServVotacion
    {
        //cargar datos del jugadores aleatorios
        public static DataTable CargarTopJugadorAleatorio()
        {
            DataTable datos = ModelVotacion.CargarTopJugadoresAleatorio(out string message);
            return datos;
        }
        //cargar datos de juagadores de equipos seleccionado
        public static DataTable CargarTopJugadoresEquipo(string nombreEquipo)
        {
            DataTable datos = ModelVotacion.CargarTopJugadoresEquipo(out string message, nombreEquipo);
            return datos;
        }
        //Verificar Voto del usuario para ver si ya voto
        public static DataTable VerificarUsuarioVoto(int IdUsuario) {
            DataTable datos = ModelVotacion.VerificarVotoUsuario(out string message, IdUsuario);
            return datos;
        }
        // Insertar Voto del Usuario
        public static bool InsertarVotoUsuario(CrtVotacion crtVotacion, out string message)
        {
            try
            {
                // Asignar la fecha y hora actual al campo FechaHoraVoto
                //crtVotacion.FechaHoraVoto = Convert.ToString(DateTime.Now);
                // Enviar los datos del usuario, jugador y la fecha y hora de hoy
                return ModelVotacion.InsertarVoto(
                    crtVotacion.IdUsuario,  // Cuando ya se tenga el login igualar al usuario con el usuario que se logeo
                    crtVotacion.IdJugadore,
                    crtVotacion.FechaHoraVoto = Convert.ToString(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")),
                     out message
                );
            }
            catch (Exception ex)
            {
                message = $"Error al verificar el voto del usuario: {ex.Message}";
                return false;
            }
        }

    }
}
