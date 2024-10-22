using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Controlador;
using System.Data;
using System.Threading.Tasks;
using Modelo;


namespace Servicios
{
    public class ServJugador
    {
        public static DataTable cargarDatos(int idjugador) {
            DataTable datos = ModeloJugador.cargarJugador(out string message,idjugador);
            return datos;
        }
        public static DataTable cargarEquipo() {
            DataTable datos = ModeloJugador.cargarEquipo(out string message);
            return datos;
        }
        public static DataTable cargarNacionalidad() {
            DataTable datos = ModeloJugador.cargarNacionalidad(out string message);
            return datos;
        }
        public static DataTable CargarJugadores() {
            DataTable data = ModeloJugador.cargarJugadores(out string message);
            return data;
        }
        public static DataTable CargarDatosEquipos()
        {
            DataTable data = ModeloJugador.cargarEquiposDatos(out string message);
            return data;
        }
        public static bool RegistrarJugador(CtrJugador jugador, out string message)
        {
            try
            {
                return ModeloJugador.InsertarJugador(
                    jugador.NombreJugador,
                    jugador.ApellidoJugador,
                    jugador.DescripcionJugador,
                    jugador.IdEquipo,
                    jugador.IdPais,
                    jugador.FechaNacimiento,
                    jugador.Altura,
                    jugador.Foto,
                    out message);
            }
            catch (Exception ex)
            {
                message = $"Error al registrar el jugador: {ex.Message}";
                return false;
            }
        }

        public static bool ActualizarJugador(CtrJugador jugador ,out string message) {
            try
            {
                return ModeloJugador.ActualizarJugador(
                    jugador.IdJugador,
                    jugador.NombreJugador,
                    jugador.ApellidoJugador,
                    jugador.DescripcionJugador,
                    jugador.IdEquipo,
                    jugador.IdPais,
                    jugador.FechaNacimiento,
                    jugador.Altura,
                    jugador.Foto,
                    out message);
            }
            catch (Exception ex)
            {
                message = $"Error al registrar el jugador: {ex.Message}";
                return false;
            }
        }

        public static bool EliminarJugador(out string message) {
            try
            {
                return ModeloJugador.EliminarJugador(
                    CtrJugador._idJugador,
                    out message);
            }
            catch (Exception ex)
            {
                message = $"Error al registrar el jugador: {ex.Message}";
                return false;
            }
        }
    }
}
