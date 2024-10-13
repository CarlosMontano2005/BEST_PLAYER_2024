using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Controlador;
using Modelo;

namespace Servicios
{
    public class ServDetalleJugador
    {
        public static bool RegistrarDetalle(CtrDetalleJugador detallejugador, out string message)
        {
            try
            {
                return ModeloDetalleJugador.InsertarDetalleJugador(
                    detallejugador.IdJugador,
                    detallejugador.Posicion,
                    detallejugador.NumeroCamisa,
                    detallejugador.PartidosJugados,
                    detallejugador.Goles,
                    detallejugador.PorcentajeGoles,
                    detallejugador.Aistencias,
                    detallejugador.TarjetasAmarrilas,
                    detallejugador.TarjetasRojas,
                    out message);
            }
            catch (Exception ex)
            {
                message = $"Error al registrar el jugador: {ex.Message}";
                return false;
            }
        }
        public static DataTable searchId(string nombre,string apellido) {
            DataTable dato = ModeloDetalleJugador.searchIdJugador(out string message, nombre,apellido);
            return dato;
        }
    }
}
