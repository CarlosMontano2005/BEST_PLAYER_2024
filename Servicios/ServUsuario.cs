using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;

namespace Servicios
{
    public class ServUsuario
    {
        //cargar grid de datos a tabla 
        public static DataTable CargarUsuarios()
        {
            DataTable datos = ModelUsuario.CargarUsuario(out string message);
            return datos;
        }
        //cargar niveles usuarios SERVIOS ServUsuario
        public static DataTable CargarAgencias()
        {
            DataTable datos = ModelUsuario.CargarAgencias(out string message);
            return datos ;
        }
        public static bool RegistrarUsuario(CtrUsuario usuario, out string message)
        {
            try
            {
                return ModelUsuario.InsertarUsuario(
                    usuario.NombreUsuario,
                    usuario.Correo,
                    usuario.FechaNacimiento,
                    usuario.Clave,
                    usuario.Foto,
                    usuario.Pasaporte,
                    usuario.NivelUsuario,
                    usuario.IdAgencia,
                    out message);
            }
            catch (Exception ex)
            {
                message = $"Error al registrar el usuario: {ex.Message}";
                return false;
            }
        }
     

    }
}
