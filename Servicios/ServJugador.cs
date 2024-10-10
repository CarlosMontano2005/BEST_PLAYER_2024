using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public static DataTable CargarJugadores() {
            DataTable data = ModeloJugador.cargarJugadores(out string message);
            return data;
        }
    }
}
