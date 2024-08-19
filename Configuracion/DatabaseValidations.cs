using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuracion
{
    public static class DatabaseValidations
    {
        public static string FormatSqlErrorMessage(SqlException ex)
        {
            // Aquí puedes personalizar la lógica para formatear el mensaje de error
            switch (ex.Number)
            {
                case 2627: // Error de clave duplicada (violación de índice único)
                    return "Error: La clave que está intentando insertar ya existe en la base de datos.";
                case 547: // Error de restricción de clave foránea
                    return "Error: La operación viola una restricción de clave foránea.";
                case 50000: // Error definido por el usuario
                    return $"Error definido por el usuario: {ex.Message}";
                default:
                    return $"Error SQL: {ex.Message}";
            }
        }
    }
}
