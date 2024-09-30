using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Configuracion;

namespace Controlador
{
    public class CtrUsuario
    {
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
                    throw new ArgumentException("ID USUARIO: "+errorMessage);
                }
            }
        }

        private string _nombreUsuario;
        public string NombreUsuario
        {
            get { return _nombreUsuario; }
            set
            {
                if (Validaciones.ValidateString(value, 10, 50, out string errorMessage))
                {
                    _nombreUsuario = value;
                }
                else
                {
                    throw new ArgumentException("NOMBRE DE USUARIO: "+errorMessage);
                }
            }
        }

        private string _correo;
        public string Correo
        {
            get { return _correo; }
            set
            {
                if (Validaciones.ValidateEmail(value, out string errorMessage))
                {
                    _correo = value;
                }
                else
                {
                    throw new ArgumentException("CORRE: "+ errorMessage);
                }
            }
        }

        private String _fechaNacimiento;
        public string FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set
            {
                if (Validaciones.ValidateDate(value, out string errorMessage))
                {
                    _fechaNacimiento = value;
                }
                else
                {
                    throw new ArgumentException("FECHA NACIMIENTO: "+errorMessage);
                }
            }
        }

        private string _clave;

        public string Clave
        {
            get { return _clave; }
            set
            {
                if (Validaciones.ValidatePassword(value, out string errorMessage))
                {
                    _clave = Validaciones.GetMD5(value); // Guarda la clave en formato MD5
                }
                else
                {
                    throw new ArgumentException("CLAVE: "+errorMessage);
                }
            }
        }

        private byte[] _foto;
        public byte[] Foto
        {
            get { return _foto; }
            set
            {
                if (Validaciones.validateImage(value, out string errorMessage))
                {
                    _foto = value;
                }
                else
                {
                    throw new ArgumentException("IMAGEN: " + errorMessage);
                }
              
            }
        }
        private string _pasaporte;
        public string Pasaporte
        {
            get { return _pasaporte; }
            set
            {
                if (Validaciones.ValidatePasaporte(value, out string errorMessage))
                {
                    _pasaporte = value;
                }
                else
                {
                    throw new ArgumentException("PASAPORTE: "+errorMessage);
                }
            }
        }

        private string _nivelUsuario;

        public string NivelUsuario
        {
            get { return _nivelUsuario; }
            set
            {
                if (Validaciones.ValidateNivelUsuario(value, out string errorMessage))
                {
                    _nivelUsuario = value;
                }
                else
                {
                    throw new ArgumentException("NIVEL USUARIO: " + errorMessage);
                }
            }
        }

        private int _idAgencia;

        public int IdAgencia
        {
            get { return _idAgencia; }
            set
            {
                if (Validaciones.ValidateNaturalNumber(value, out string errorMessage))
                {
                    _idAgencia = value;
                }
                else
                {
                    throw new ArgumentException("AGENCIA: "+errorMessage);
                }
            }
        }

        // Constructor vacío
        public CtrUsuario() { }

        public CtrUsuario(int idUsuario, string nombreUsuario, string correo, string fechaNacimiento, string clave, string pasaporte, string nivelUsuario, int idAgencia, byte[] foto = null)
        {
            IdUsuario = idUsuario;
            NombreUsuario = nombreUsuario;
            Correo = correo;
            FechaNacimiento = fechaNacimiento;
            Clave = clave;
            Foto = foto;  // Puede ser null si no se proporciona
            Pasaporte = pasaporte;
            NivelUsuario = nivelUsuario;
            IdAgencia = idAgencia;
        }
    }

}
