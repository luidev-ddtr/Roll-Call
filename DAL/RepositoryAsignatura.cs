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
    internal class RepositoryAsignatura
    {
        public int GetasignaturaByName(string materia)
        {
            conexion ObjetoConexion = new conexion();
            int Matricula = 0;

            try
            {
                // Opción 1: Buscar por coincidencia exacta de datos
                string query = $@"
                    SELECT  ID_Asignatura
                    FROM ASIGNATURA
                    WHERE
                    Nombre = '{materia.Replace("'", "''")}'";

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
                return 0; // Retorna 0 en caso de error
            }
            finally
            {
                ObjetoConexion.cerrar();
            }
        }
    }
}
