using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Exportar
using Configuracion;

namespace Controlador
{
    class CtrTopJugadores
    {
        private int _CantidadVotos;
        public int CantidadVotos
        {
            get { return _CantidadVotos; }
            set
            {
                if (Validaciones.ValidateNaturalNumber(value, out string errorMessage))
                {
                    _CantidadVotos = value;
                }
            }
        }
        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set
            {
                if (Validaciones.ValidateString(value, 10, 50, out string errorMessage))
                {
                    _Nombre = value;
                }
            }
        }

        private string _Apellido;
        public string Apellido
        {
            get { return _Apellido; }
            set
            {
                if (Validaciones.ValidateString(value, 10, 50, out string errorMessage))
                {
                    _Apellido = value;
                }
            }
        }
        private string _NombreEquipo;
        public string NombreEquipo
        {
            get { return _NombreEquipo; }
            set
            {
                if (Validaciones.ValidateString(value, 10, 50, out string errorMessage))
                {
                    _NombreEquipo = value;
                }
            }
        }
        private string _NombrePais;
        public string NombrePais
        {
            get { return _NombrePais; }
            set
            {
                if (Validaciones.ValidateString(value, 10, 50, out string errorMessage))
                {
                    _NombrePais = value;
                }
            }
        }
    }
}
