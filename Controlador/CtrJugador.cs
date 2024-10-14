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
        public static string nombrejugador;
        public static string apellidojugador;
        public static string descripcionjugador;
        public static int idequipo;
        public static int idpais;
        public static string fecha;
        public static float altura;
        public static byte[] foto;

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
                    throw new ArgumentException("ID JUGADOR: " + errorMessage);
                }
            }
        }

        public string NombreJugador
        {
            get { return nombrejugador; }
            set
            {
                if (Validaciones.ValidateString(value,2,40, out string errorMessage))
                {
                    nombrejugador = value;
                }
                else
                {
                    throw new ArgumentException("NOMBRE JUGADOR: " + errorMessage);
                }
            }
        }

        public string ApellidoJugador
        {
            get { return apellidojugador; }
            set
            {
                if (Validaciones.ValidateString(value, 2, 40, out string errorMessage))
                {
                    apellidojugador = value;
                }
                else
                {
                    throw new ArgumentException("APELLIDO JUGADOR: " + errorMessage);
                }
            }
        }

        public string DescripcionJugador
        {
            get { return descripcionjugador; }
            set
            {
                if (Validaciones.ValidateString(value, 2, 400, out string errorMessage))
                {
                    descripcionjugador = value;
                }
                else
                {
                    throw new ArgumentException("DESCRIPCION JUGADOR: " + errorMessage);
                }
            }
        }

        public int IdEquipo
        {
            get { return idequipo; }
            set
            {
                if (Validaciones.ValidateNaturalNumber(value, out string errorMessage))
                {
                    idequipo = value;
                }
                else
                {
                    throw new ArgumentException("ID EQUIPO: " + errorMessage);
                }
            }
        }

        public int IdPais
        {
            get { return idpais; }
            set
            {
                if (Validaciones.ValidateNaturalNumber(value, out string errorMessage))
                {
                    idpais = value;
                }
                else
                {
                    throw new ArgumentException("ID PAIS: " + errorMessage);
                }
            }
        }

        public string FechaNacimiento
        {
            get { return fecha; }
            set
            {
                if (Validaciones.ValidateDate(value, out string errorMessage))
                {
                    fecha = value;
                }
                else
                {
                    throw new ArgumentException("FECHA NACIMIENTO: " + errorMessage);
                }
            }
        }

        public float Altura
        {
            get { return altura; }
            set
            {
                if (Validaciones.validateFloatNumber(value, out string errorMessage))
                {
                    altura = value;
                }
                else
                {
                    throw new ArgumentException("ALTURA: " + errorMessage);
                }
            }
        }

        public byte[] Foto
        {
            get { return foto; }
            set
            {
                if (Validaciones.validateImage(value, out string errorMessage))
                {
                    foto = value;
                }
                else
                {
                    throw new ArgumentException("IMAGEN: " + errorMessage);
                }

            }
        }

    }
}
