using Roll_Call.BNL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roll_Call.DAL
{
    internal class RepositoryAlumno
    {
        public void ingresarAlumno(alumno datosAlumno)
        {
            conexion ObjetoConexion = new conexion();

            try
            {
                // Usamos interpolación de strings ($"") para mayor claridad
                string query = $@"
            INSERT INTO ALUMNO 
                (Nombre, Apellidos, Fecha_Nac, Correo, Estatus) 
            VALUES 
                ('{datosAlumno.Nombre.Replace("'", "''")}', 
                 '{datosAlumno.Apellidos.Replace("'", "''")}', 
                 '{datosAlumno.Fecha_Nac.Replace("'", "''")}', 
                 '{datosAlumno.Correo.Replace("'", "''")}', 
                 '{datosAlumno.Estatus.Replace("'", "''")}')";

                MessageBox.Show($"Query que se enviará a la BD:\n{query}", "Datos a Insertar");

                ObjetoConexion.EjecutarQuery(query);
                MessageBox.Show("Alumno ingresado correctamente", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudieron ingresar los datos: {ex.Message}");
            }
        }

        public void mostrarEmpleados(DataGridView tablaEmpleados)
        {
            conexion ObjetoConexion = new conexion();
            try
            {
                tablaEmpleados.DataSource = null;
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM ALUMNO", ObjetoConexion.establecerConexion());
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                tablaEmpleados.DataSource = dt;

                ObjetoConexion.cerrar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } //end funtion

        public int GetByDataAlumno(alumno DatosAlumno)
        {
            conexion ObjetoConexion = new conexion();
            int Matricula = 0;

            try
            {
                // Opción 1: Buscar por coincidencia exacta de datos
                string query = $@"
                    SELECT Matricula 
                    FROM ALUMNO
                    WHERE
                    Nombre = '{DatosAlumno.Nombre.Replace("'", "''")}' AND
                    Apellidos = '{DatosAlumno.Apellidos.Replace("'", "''")}' AND
                    Correo = '{DatosAlumno.Correo.Replace("'", "''")}'";

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
        }
    }
}
