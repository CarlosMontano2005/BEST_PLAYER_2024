using Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class CrtVotacion
    {
        private int _idVotacion;
        public int IdVotacion
        {
            get { return _idVotacion; }
            set
            {
                if (Validaciones.ValidateNaturalNumber(value, out string errorMessage))
                {
                    _idVotacion = value;
                }
                else
                {
                    throw new ArgumentException("ID VOTACION: " + errorMessage);
                }
            }
        }
        private int _idUsuario;

        public int IdUsuario
        {
            get { return _idUsuario; }
            set
            {
                if (Validaciones.ValidateNaturalNumber(value, out string errorMessage))
                {
                    _idUsuario = value;
                }
                else
                {
                    throw new ArgumentException("ID USUARIO: " + errorMessage);
                }
            }
        }
        private int _idJugadore;

        public int IdJugadore
        {
            get { return _idJugadore; }
            set
            {
                if (Validaciones.ValidateNaturalNumber(value, out string errorMessage))
                {
                    _idJugadore = value;
                }
                else
                {
                    throw new ArgumentException("ID JUGADORES: " + errorMessage);
                }
            }
        }
        private String _fechaHoraVoto;

        public string FechaHoraVoto
        {
            get { return _fechaHoraVoto; }
            set
            {
                if (Validaciones.ValidateDateTime(value, out string errorMessage))
                {
                    _fechaHoraVoto = value;
                }
                else
                {
                    throw new ArgumentException("FECHA VOTACION: " + errorMessage);
                }
            }
        }
    }
}
