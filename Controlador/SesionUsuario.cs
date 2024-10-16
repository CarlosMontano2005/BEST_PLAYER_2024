using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public static class SesionUsuario
    {
        public static int IdUsuario { get; set; }
        public static string NombreUsuario { get; set; }
        public static string CorreoUsuario { get; set; }
        public static string NivelUsuario { get; set; }
        public static byte[] FotoUsuario { get; set; } = null;
        public static bool SesionActiva { get; set; } = false;
    }
}
