using Roll_Call.BNL;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roll_Call.DAL
{
    internal class RepositoryCursa
    {
        public void IngresarRegistro(alumno alumno, List<int> listaMaterias)
        {
            conexion ObjetoConexion = new conexion();
            RepositoryAlumno handlerAlumno = new RepositoryAlumno();

            int matricula = handlerAlumno.GetByDataAlumno(alumno);
            string periodo = "SEP 2025-JUN 2026";
            float calificacion = 10.00f;
            foreach (int materia in listaMaterias)
                {
                
                try
                    {
                        // Usamos interpolación de strings ($"") para mayor claridad
                        string query = $@"
                        INSERT INTO CURSA 
                            (Matricula, ID_Asignatura, Periodo, Calificacion) 
                        VALUES 
                        ('{matricula}', 
                        '{materia}', 
                        '{periodo}',  
                        '{calificacion}')";

                        MessageBox.Show($"Query que se enviará a la BD:\n{query}", "Datos a Insertar");

                        ObjetoConexion.EjecutarQuery(query);
                        MessageBox.Show("Alumno ingresado correctamente", "Éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudieron ingresar los datos: {ex.Message}");
                }
            }
        }
    }
}
