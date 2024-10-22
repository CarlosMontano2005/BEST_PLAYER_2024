using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Configuracion;

namespace Controlador
{
    public class CtrDetalleJugador
    {
        public int IdDetalle;
        public int IdJugador;
        public string Posicion;
        public int NumeroCamisa;
        public int PartidosJugados;
        public int Goles;
        public float PorcentajeGoles;
        public int Aistencias;
        public int TarjetasAmarrilas;
        public int TarjetasRojas;

        public int idDetalle
        {
            get { return IdDetalle; }
            set
            {
                if (Validaciones.ValidateNaturalNumber(value, out string errorMessage))
                {
                    IdDetalle = value;
                }
                else
                {
                    throw new ArgumentException("ID Detalle: " + errorMessage);
                }
            }
        }
        public int idJugador
        {
            get { return IdJugador; }
            set
            {
                if (Validaciones.ValidateNaturalNumber(value, out string errorMessage))
                {
                    IdJugador = value;
                }
                else
                {
                    throw new ArgumentException("ID JUGADOR: " + errorMessage);
                }
            }
        }
        public string PosicionJugador
        {
            get { return Posicion; }
            set
            {
                if (Validaciones.ValidateString(value, 2, 40, out string errorMessage))
                {
                    Posicion = value;
                }
                else
                {
                    throw new ArgumentException("NOMBRE JUGADOR: " + errorMessage);
                }
            }
        }
        public int NumeroCam
        {
            get { return NumeroCamisa; }
            set
            {
                if (Validaciones.ValidateNaturalNumber(value, out string errorMessage))
                {
                    NumeroCamisa = value;
                }
                else
                {
                    throw new ArgumentException("ID JUGADOR: " + errorMessage);
                }
            }
        }
        public int Partidosjugados
        {
            get { return PartidosJugados; }
            set
            {
                if (Validaciones.ValidateNaturalNumber(value, out string errorMessage))
                {
                    PartidosJugados = value;
                }
                else
                {
                    throw new ArgumentException("ID JUGADOR: " + errorMessage);
                }
            }
        }
        public int goles
        {
            get { return Goles; }
            set
            {
                if (Validaciones.ValidateNaturalNumber(value, out string errorMessage))
                {
                    goles = value;
                }
                else
                {
                    throw new ArgumentException("ID JUGADOR: " + errorMessage);
                }
            }
        }
        public float porcentajegoles
        {
            get { return PorcentajeGoles; }
            set
            {
                if (Validaciones.validateFloatNumber(value, out string errorMessage))
                {
                    PorcentajeGoles = value;
                }
                else
                {
                    throw new ArgumentException("ALTURA: " + errorMessage);
                }
            }
        }
        public int asistencias
        {
            get { return Aistencias; }
            set
            {
                if (Validaciones.ValidateNaturalNumber(value, out string errorMessage))
                {
                    Aistencias = value;
                }
                else
                {
                    throw new ArgumentException("ID JUGADOR: " + errorMessage);
                }
            }
        }
        public int tarjetasamarillas
        {
            get { return TarjetasAmarrilas; }
            set
            {
                if (Validaciones.ValidateNaturalNumber(value, out string errorMessage))
                {
                    TarjetasAmarrilas = value;
                }
                else
                {
                    throw new ArgumentException("ID JUGADOR: " + errorMessage);
                }
            }
        }
        public int tarjetasrojas
        {
            get { return TarjetasRojas; }
            set
            {
                if (Validaciones.ValidateNaturalNumber(value, out string errorMessage))
                {
                    TarjetasRojas = value;
                }
                else
                {
                    throw new ArgumentException("ID JUGADOR: " + errorMessage);
                }
            }
        }

        //Tabla equipo
        private int _IdEquipo;

        public int IdEquipo
        {
            get { return _IdEquipo; }
            set
            {
                if (Validaciones.ValidateNaturalNumber(value, out string errorMessage))
                {
                    _IdEquipo = value;
                }
                else
                {
                    throw new ArgumentException("ID Detalle: " + errorMessage);
                }
            }
        }
        private static byte[] _LogoEquipo;
        public byte[] LogoEquipo
        {
            get { return _LogoEquipo; }
            set
            {
                if (Validaciones.validateImage(value, out string errorMessage))
                {
                    _LogoEquipo = value;
                }
                else
                {
                    throw new ArgumentException("IMAGEN: " + errorMessage);
                }

            }
        }
        private static byte[] _FotoDT;
        public byte[] FotoDT
        {
            get { return _FotoDT; }
            set
            {
                if (Validaciones.validateImage(value, out string errorMessage))
                {
                    _FotoDT = value;
                }
                else
                {
                    throw new ArgumentException("IMAGEN: " + errorMessage);
                }

            }
        }

    }
}
