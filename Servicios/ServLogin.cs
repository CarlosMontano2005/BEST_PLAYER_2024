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

            try
            {
                // Llamada a ValidarLogin con los parámetros correctos
                bool resultado = ModelLogin.ValidarLogin(
                    usuario.Correo,
                    usuario.Clave,
                    out nombreUsuario,
                    out nivelUsuario,
                    out message
                );

                if (resultado)
                {
                    // Almacenar el nombre y nivel de usuario si es necesario
                    usuario.NombreUsuario = nombreUsuario; 
                    usuario.NivelUsuario = nivelUsuario;  
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
