using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;
using Configuracion;

namespace Controlador
{
    public class CtrLogin
    {
        public static class SesionUsuario
        {
            public static int IdUsuario { get; set; }
            public static string NombreUsuario { get; set; }
            public static string NivelUsuario { get; set; }
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
                    throw new ArgumentException("NOMBRE DE USUARIO: " + errorMessage);
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
                    throw new ArgumentException("CORREO: " + errorMessage);
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
                    throw new ArgumentException("CLAVE: " + errorMessage);
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

        public CtrLogin() { }

        public CtrLogin(string nombreUsuario, string correo,  string clave, string nivelUsuario)
        {

            NombreUsuario = nombreUsuario;
            Correo = correo;
            Clave = clave;
            NivelUsuario = nivelUsuario;

        }


    }
}
