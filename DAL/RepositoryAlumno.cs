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
    /// <summary>
    /// Clase de acceso a datos para la gestión de alumnos en la base de datos
    /// </summary>
    internal class RepositoryAlumno
    {
        /// <summary>
        /// Inserta un nuevo alumno en la base de datos
        /// </summary>
        /// <param name="datosAlumno">Objeto alumno con los datos a insertar</param>
        /// <remarks>
        /// Maneja la inserción de datos escapando comillas simples para prevenir SQL injection
        /// </remarks>
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

                ObjetoConexion.EjecutarQuery(query);
                MessageBox.Show("Alumno ingresado correctamente", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudieron ingresar los datos: {ex.Message}");
            }
        }

        /// <summary>
        /// Carga y muestra todos los alumnos en un DataGridView
        /// </summary>
        /// <param name="tablaEmpleados">Control DataGridView donde se mostrarán los datos</param>
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
        }

        /// <summary>
        /// Obtiene la matrícula de un alumno basado en sus datos personales
        /// </summary>
        /// <param name="DatosAlumno">Objeto alumno con los datos a buscar</param>
        /// <returns>
        /// La matrícula del alumno si se encuentra, 0 si no se encuentra o hay error
        /// </returns>
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

        /// <summary>
        /// Actualiza los datos de un alumno existente en la base de datos
        /// </summary>
        /// <param name="datosAlumno">Objeto alumno con los datos actualizados</param>
        public void ModificarAlumno(alumno datosAlumno)
        {
            conexion ObjetoConexion = new conexion();

            try
            {
                // Usamos interpolación de strings ($"") para mayor claridad
                string query = $@"
                    UPDATE ALUMNO
                    SET Nombre = '{datosAlumno.Nombre.Replace("'", "''")}', Apellidos = '{datosAlumno.Apellidos.Replace("'", "''")}', Correo = '{datosAlumno.Correo.Replace("'", "''")}'
                    WHERE Matricula = {datosAlumno.Matricula};";

                ObjetoConexion.EjecutarQuery(query);
                MessageBox.Show("Alumno Modificado correctamente", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudieron ingresar los datos: {ex.Message}");
            }
        }

        /// <summary>
        /// Desactiva un alumno cambiando su estatus a INACTIVO
        /// </summary>
        /// <param name="matricula">Matrícula del alumno a desactivar</param>
        public void Desactivarusuario(int matricula)
        {
            conexion ObjetoConexion = new conexion();

            try
            {
                // Usamos interpolación de strings ($"") para mayor claridad
                string query = $@"
                    UPDATE ALUMNO
                    SET Estatus = 'INACTIVO'
                    WHERE Matricula = {matricula};";

                ObjetoConexion.EjecutarQuery(query);
                MessageBox.Show("Alumno Desactivado correctamente", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudieron ingresar los datos: {ex.Message}");
            }
        }
    }
}