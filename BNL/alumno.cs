using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roll_Call.BNL
{
    public class alumno
    {
        public int Matricula;
        public string Nombre;
        public string Apellidos;
        public string Fecha_Nac;
        public string Correo;
        public string Estatus;

        private List<string> GenerarLista()
        {
            List<string> result = new List<string>();
            result.Add(Apellidos);
            result.Add(Nombre);
            return result;
        }

        public (bool,string) validarDatos()
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

        private (bool, string) ValidarCorreo(string correo)  // Corregido nombre de parámetro
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

        private (bool, string) ValidarTexto(string texto)
        {
            // Validar que solo contenga letras, espacios y caracteres acentuados
            foreach (char c in texto)
            {
                if (char.IsDigit(c))
                {
                    return (false, "No se permiten números en el texto");
                }

                if ("[]{};.,".Contains(c))  // Caracteres prohibidos explícitos
                {
                    return (false, $"Carácter no permitido: '{c}' ");
                }
            }
            return (true, "");
        }

    }
}
