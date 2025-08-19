using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roll_Call.BNL
{
    /// <summary>
    /// Clase que representa a un alumno y contiene métodos para validar sus datos
    /// </summary>
    public class alumno
    {
        // Campos públicos que representan los atributos del alumno
        public int Matricula;
        public string Nombre;
        public string Apellidos;
        public string Fecha_Nac;
        public string Correo;
        public string Estatus;

        /// <summary>
        /// Genera una lista con los apellidos y nombre del alumno
        /// </summary>
        /// <returns>Lista de strings con apellidos y nombre</returns>
        private List<string> GenerarLista()
        {
            List<string> result = new List<string>();
            result.Add(Apellidos);
            result.Add(Nombre);
            return result;
        }

        /// <summary>
        /// Valida todos los datos del alumno (nombre, apellidos, fecha y correo)
        /// </summary>
        /// <returns>
        /// Tupla con:
        /// bool - true si todos los datos son válidos
        /// string - mensaje de error si hay datos inválidos
        /// </returns>
        public (bool, string) validarDatos()
        {
            string mensaje = "";
            bool isValid = true;

            if (Fecha_Nac != null)
            {
                (isValid, mensaje) = ValidarFecha(Fecha_Nac);
                if (!isValid)
                    return (false, mensaje);
            }

            if (Correo != null)
            {
                (isValid, mensaje) = ValidarCorreo(Correo);
                if (!isValid)
                    return (false, mensaje);
            }

            foreach (var item in GenerarLista())
            {
                (isValid, mensaje) = ValidarTexto(item);
                if (!isValid)
                    return (false, mensaje);
            }

            return (isValid, mensaje);
        }

        /// <summary>
        /// Valida que una fecha tenga formato correcto y esté en rango válido
        /// </summary>
        /// <param name="fecha">Cadena con la fecha a validar</param>
        /// <returns>
        /// Tupla con:
        /// bool - true si la fecha es válida
        /// string - mensaje de error si la fecha es inválida
        /// </returns>
        private (bool, string) ValidarFecha(string fecha)
        {
            // Intentar convertir la cadena a DateTime
            if (DateTime.TryParse(fecha, out DateTime fechaConvertida))
            {
                int añoActual = DateTime.Now.Year;
                int añoFecha = fechaConvertida.Year;

                // Validar rango de años (2000 - año actual)
                if (añoFecha < 2000 || añoFecha > añoActual)
                {
                    return (false, $"El año debe estar entre 2000 y {añoActual}");
                }
                return (true, "");
            }
            return (false, "Formato de fecha inválido");
        }

        /// <summary>
        /// Valida que un correo electrónico tenga formato válido
        /// </summary>
        /// <param name="correo">Cadena con el correo a validar</param>
        /// <returns>
        /// Tupla con:
        /// bool - true si el correo es válido
        /// string - mensaje de error si el correo es inválido
        /// </returns>
        private (bool, string) ValidarCorreo(string correo)
        {
            // Validar presencia de '@' y dominio con punto
            if (!correo.Contains('@'))
            {
                return (false, "El correo debe contener '@'");
            }

            int posArroba = correo.IndexOf('@');
            string dominio = correo.Substring(posArroba + 1);

            if (!dominio.Contains('.'))
            {
                return (false, "El dominio debe contener al menos un punto '.'");
            }

            return (true, "");
        }

        /// <summary>
        /// Valida que un texto contenga solo caracteres permitidos (letras y espacios)
        /// </summary>
        /// <param name="texto">Cadena de texto a validar</param>
        /// <returns>
        /// Tupla con:
        /// bool - true si el texto es válido
        /// string - mensaje de error si el texto es inválido
        /// </returns>
        private (bool, string) ValidarTexto(string texto)
        {
            // Validar que solo contenga letras, espacios y caracteres acentuados
            foreach (char c in texto)
            {
                if (char.IsDigit(c))
                {
                    return (false, "No se permiten números en el texto");
                }

                if ("[]{};.,".Contains(c))
                {
                    return (false, $"Carácter no permitido: '{c}' ");
                }
            }
            return (true, "");
        }
    }
}