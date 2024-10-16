using Controlador;
using Modelo;
using System;
using System.Data;


namespace Servicios
{
    public class ServLogin
    {
        public static bool LoginUsuario(CtrLogin usuario, out string message)
        {

            string nombreUsuario;
            string nivelUsuario;
            byte[] fotoUsuario;
            int idUsuario;

            try
            {
                // Llamada a ValidarLogin con los parámetros correctos
                bool resultado = ModelLogin.ValidarLogin(
                    usuario.Correo,
                    usuario.Clave,
                    out idUsuario,
                    out nombreUsuario,
                    out nivelUsuario,
                    out fotoUsuario,
                    out message
                );

                if (resultado)
                {
                    // Almacenar el nombre y nivel de usuario si es necesario
                    SesionUsuario.IdUsuario = idUsuario;
                    SesionUsuario.NombreUsuario = nombreUsuario;
                    SesionUsuario.NivelUsuario = nivelUsuario;
                    SesionUsuario.FotoUsuario = fotoUsuario;
                    SesionUsuario.CorreoUsuario = usuario.Correo;
                }

                return resultado;
            }
            catch (Exception ex)
            {
                message = $"Error durante el proceso de login: {ex.Message}";
                return false;
            }
        }

        
    }
}
