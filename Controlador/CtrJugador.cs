using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Configuracion;
using System.Threading.Tasks;

namespace Controlador
{
    public class CtrJugador
    {
        public static int _idJugador;

        public  int IdJugador
        {
            get { return _idJugador; }
            set
            {
                if (Validaciones.ValidateNaturalNumber(value, out string errorMessage))
                {
                    _idJugador = value;
                }
                else
                {
                    throw new ArgumentException("ID USUARIO: " + errorMessage);
                }
            }
        }
    }
}
