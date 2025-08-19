using Roll_Call.BNL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roll_Call.DAL
{
    /// <summary>
    /// Clase de acceso a datos para la gestión de asignaturas/materias en la base de datos
    /// </summary>
    internal class RepositoryAsignatura
    {
        /// <summary>
        /// Obtiene el ID de una asignatura basado en su nombre
        /// </summary>
        /// <param name="materia">Nombre de la materia a buscar</param>
        /// <returns>
        /// El ID de la asignatura si se encuentra, 
        /// 0 si no se encuentra o ocurre un error
        /// </returns>
        /// <remarks>
        /// Escapa comillas simples en el parámetro para prevenir SQL injection
        /// </remarks>
        public int GetasignaturaByName(string materia)
        {
            conexion ObjetoConexion = new conexion();
            int Matricula = 0;

            try
            {
                string query = $@"
                    SELECT ID_Asignatura
                    FROM ASIGNATURA
                    WHERE Nombre = '{materia.Replace("'", "''")}'";

                using (SqlCommand cmd = new SqlCommand(query, ObjetoConexion.establecerConexion()))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        Matricula = Convert.ToInt32(result);
                    }
                }

                return Matricula;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudieron obtener los datos: {ex.Message}");
                return 0;
            }
        }

        /// <summary>
        /// Obtiene la lista de materias asignadas a un alumno específico
        /// </summary>
        /// <param name="matricula">Matrícula del alumno</param>
        /// <returns>
        /// Cadena con los nombres de las materias separados por comas,
        /// o cadena vacía si no hay materias o ocurre un error
        /// </returns>
        /// <remarks>
        /// Utiliza STRING_AGG para concatenar los resultados en una sola cadena
        /// </remarks>
        public string GetasignaturaByMatricula(int matricula)
        {
            conexion ObjetoConexion = new conexion();
            string materia = "";
            try
            {
                string query = $@"
                    SELECT STRING_AGG(ASIGNATURA.Nombre, ', ')
                    FROM ASIGNATURA, CURSA, ALUMNO
                    WHERE ASIGNATURA.ID_Asignatura = CURSA.ID_Asignatura
                    AND CURSA.Matricula = ALUMNO.Matricula
                    AND ALUMNO.Matricula = '{matricula}'";

                using (SqlCommand cmd = new SqlCommand(query, ObjetoConexion.establecerConexion()))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        materia = Convert.ToString(result);
                    }
                }

                return materia;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudieron obtener los datos: {ex.Message}");
                return "";
            }
        }
    }
}