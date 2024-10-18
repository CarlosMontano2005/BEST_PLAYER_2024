using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Globalization;
using System.IO;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace Configuracion
{
    public class Validaciones
    {
        public static bool ValidateString(string value, int minimum, int maximum, out string errorMessage)
        {
            if (string.IsNullOrEmpty(value))
            {
                errorMessage = "ERR001: El valor no puede estar vacío.";
                return false;
            }
            if (value.Length < minimum || value.Length > maximum)
            {
                errorMessage = $"ERR002: El valor debe tener entre {minimum} y {maximum} caracteres.";
                return false;
            }
            // Validar caracteres permitidos (letras, dígitos, espacios y signos de puntuación)
            if (!System.Text.RegularExpressions.Regex.IsMatch(value, @"^[a-zA-Z0-9ñÑáÁéÉíÍóÓúÚ\s\,\;\.]+$"))
            {
                errorMessage = "ERR003: El valor contiene caracteres no permitidos.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        public static bool ValidateEmail(string value, out string errorMessage)
        {
            if (string.IsNullOrEmpty(value))
            {
                errorMessage = "ERR004: El correo no puede estar vacío.";
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorMessage = "ERR005: Formato de correo electrónico no válido.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        public static bool ValidateDate(string value, out string errorMessage)
        {
            errorMessage = null;

            if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                return true;
            }
            else
            {
                errorMessage = "ERR006: La fecha debe estar en el formato yyyy-MM-dd.";
                return false;
            }
        }
       
        public static bool ValidatePassword(string password, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                errorMessage = "ERR007: La contraseña no puede estar vacía.";
                return false;
            }

            // Ejemplo de validación: mínimo 8 caracteres, al menos una mayúscula, una minúscula y un número
            if (password.Length < 8 ||
                !password.Any(char.IsUpper) ||
                !password.Any(char.IsLower) ||
                !password.Any(char.IsDigit))
            {
                errorMessage = "ERR008: La contraseña debe tener al menos 8 caracteres, incluyendo una letra mayúscula, una letra minúscula y un número.";
                return false;
            }

            errorMessage = null;
            return true;
        }
       
        public static string GetMD5(string str)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(str);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.AppendFormat("{0:x2}", b);
                }

                return sb.ToString();
            }
        }

        public static bool ValidatePasaporte(string value, out string errorMessage)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(value, @"^[A-Za-z0-9]{9}$"))
            {
                errorMessage = "Formato de pasaporte incorrecto. Debe ser alfanumérico de 9 caracteres.";
                return false;
            }
            errorMessage = null;
            return true;
        }
        public static bool ValidateNaturalNumber(int value, out string errorMessage)
        {
            if (value >= 1)
            {
                errorMessage = null;
                return true;
            }
            else
            {
                errorMessage = "ERR009: El valor debe ser un número entero mayor o igual a uno.";
                return false;
            }
        }
        public static bool validateFloatNumber(float value, out string errorMessage) {
            if (value >= 0.5)
            {
                errorMessage = null;
                return true;
            }
            else
            {
                errorMessage = "ERR009: El valor debe ser un número entero mayor o igual a uno.";
                return false;
            }
        }

        public static bool ValidateNivelUsuario(string nivelUsuario, out string errorMessage)
        {
            var valoresPermitidos = new HashSet<string> { "Comentarista", "Administrador" };

            if (string.IsNullOrWhiteSpace(nivelUsuario))
            {
                errorMessage = "ERR010: El nivel de usuario no puede estar vacío.";
                return false;
            }
            if (!valoresPermitidos.Contains(nivelUsuario))
            {
                errorMessage = "ERR011: El nivel de usuario no es válido. Los valores permitidos son: Administrador o Comentarista.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        public static bool validateImage(byte[] value, out string errorMessage)
        {
            errorMessage = null;

            if (value == null)
            {
                errorMessage = "ERR012: La imagen no puede ser nula.";
                return false;
            }

            if (value.Length == 0)
            {
                errorMessage = "ERR012: La imagen no puede estar vacía.";
                return false;
            }

            // Validar el tamaño en bytes (máximo 1 MB)
            const int maxSizeInBytes = 10 * 1024 * 1024; // 1 MB
            if (value.Length > maxSizeInBytes)
            {
                errorMessage = "ERR013: La imagen es demasiado grande. El tamaño máximo permitido es 10 MB.";
                return false; 
            }

            return true; 
        }
        public static bool ValidateDateTime(string value, out string errorMessage)
        {
            errorMessage = null;

            if (DateTime.TryParseExact(value, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                return true;
            }
            else
            {
                errorMessage = "ERR014: La fecha debe estar en el formato yyyy-MM-dd HH:mm:ss.";
                return false;
            }
        }


    }
}
