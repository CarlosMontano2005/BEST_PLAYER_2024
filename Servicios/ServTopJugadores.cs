using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
namespace Servicios
{
    public class ServTopJugadores
    {
        public static DataTable CargarTopFiveJugadores()
        {
            DataTable datos = ModelTopJugadores.CargarTop5Jugadore(out string mensage);
            return datos;
        }

        public static DataTable CargarJugadoresVotados()
        {
            DataTable datos = ModelTopJugadores.CargarJugadoresVotadosLista(out string mensage);
            return datos;
        }
    }
}
