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
    /// Clase para manejar la conexión y operaciones con la base de datos
    /// </summary>
    internal class conexion
    {
        /// <summary>
        /// Cadena de conexión estática a la base de datos
        /// </summary>
        public static string cadenaBD = "Data Source=ANGEL\\SQLEXPRESS;Initial Catalog=CONTROL_ESCOLAR;Integrated Security=True;TrustServerCertificate=True;";

        /// <summary>
        /// Objeto SqlConnection para manejar la conexión a la base de datos
        /// </summary>
        public SqlConnection cursor = new SqlConnection();

        /// <summary>
        /// Cadena de conexión privada para la instancia actual
        /// </summary>
        private string cadena =
            "Data Source=ANGEL\\SQLEXPRESS;" + //Aqui Cambiar el usuario
            "Initial Catalog=CONTROL_ESCOLAR;" +
            "Integrated Security=True;" +
            "TrustServerCertificate=True;";

        /// <summary>
        /// Establece una conexión con la base de datos
        /// </summary>
        /// <returns>Objeto SqlConnection abierto</returns>
        public SqlConnection establecerConexion()
        {
            try
            {
                cursor.ConnectionString = cadena;
                cursor.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexión: " + ex.Message);
            }
            return cursor;
        }

        /// <summary>
        /// Cierra la conexión con la base de datos
        /// </summary>
        public void cerrar()
        {
            try
            {
                cursor.Close();
            }
            catch (Exception ex)
            {
                // La excepción se silencia intencionalmente
            }
        }

        /// <summary>
        /// Obtiene datos de la base de datos y los devuelve en un DataTable
        /// </summary>
        /// <param name="consultaSQL">Consulta SELECT a ejecutar</param>
        /// <returns>DataTable con los resultados de la consulta</returns>
        public DataTable ObtenerDatos(string consultaSQL)
        {
            DataTable dt = new DataTable();
            try
            {
                this.establecerConexion();
                using (SqlCommand cmd = new SqlCommand(consultaSQL, cursor))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            finally
            {
                cerrar();
            }
            return dt;
        }

        /// <summary>
        /// Ejecuta una consulta que no devuelve resultados (INSERT/UPDATE/DELETE)
        /// </summary>
        /// <param name="consultaSQL">Consulta SQL a ejecutar</param>
        /// <returns>Número de filas afectadas</returns>
        public int EjecutarConsulta(string consultaSQL)
        {
            int filasAfectadas = 0;
            try
            {
                this.establecerConexion();
                using (SqlCommand cmd = new SqlCommand(consultaSQL, cursor))
                {
                    filasAfectadas = cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                cerrar();
            }
            return filasAfectadas;
        }

        /// <summary>
        /// Ejecuta una consulta SQL con opción de mostrar mensajes de depuración
        /// </summary>
        /// <param name="query">Consulta SQL a ejecutar</param>
        /// <param name="mostrarMensajes">True para mostrar mensajes de depuración</param>
        /// <returns>
        /// Número de filas afectadas (≥0) si tiene éxito, 
        /// -1 si ocurre un error
        /// </returns>
        public int EjecutarQuery(string query, bool mostrarMensajes = false)
        {
            int filasAfectadas = 0;

            try
            {
                if (mostrarMensajes)
                {
                    MessageBox.Show($"Query a ejecutar:\n{query}", "Depuración - Query SQL");
                }

                this.establecerConexion();

                using (SqlCommand cmd = new SqlCommand(query, cursor))
                {
                    filasAfectadas = cmd.ExecuteNonQuery();

                    if (mostrarMensajes)
                    {
                        MessageBox.Show($"Filas afectadas: {filasAfectadas}", "Resultado de la operación");
                    }
                }

                return filasAfectadas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ejecutar el query:\n{ex.Message}", "Error en la base de datos");
                return -1;
            }
            finally
            {
                this.cerrar();
            }
        }

        /// <summary>
        /// Ejecuta una consulta SQL con parámetros para mayor seguridad
        /// </summary>
        /// <param name="query">Consulta SQL con parámetros (@param1, @param2, etc.)</param>
        /// <param name="parametros">Diccionario de parámetros (nombre, valor)</param>
        /// <param name="mostrarMensajes">True para mostrar mensajes de depuración</param>
        /// <returns>
        /// Número de filas afectadas (≥0) si tiene éxito, 
        /// -1 si ocurre un error
        /// </returns>
        public int EjecutarQueryConParametros(string query, Dictionary<string, object> parametros, bool mostrarMensajes = false)
        {
            int filasAfectadas = 0;

            try
            {
                if (mostrarMensajes)
                {
                    string debugInfo = $"Query a ejecutar:\n{query}\n\nParámetros:";
                    foreach (var param in parametros)
                    {
                        debugInfo += $"\n{param.Key} = {param.Value}";
                    }
                    MessageBox.Show(debugInfo, "Depuración - Query con Parámetros");
                }

                this.establecerConexion();

                using (SqlCommand cmd = new SqlCommand(query, cursor))
                {
                    foreach (var param in parametros)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                    }

                    filasAfectadas = cmd.ExecuteNonQuery();

                    if (mostrarMensajes)
                    {
                        MessageBox.Show($"Filas afectadas: {filasAfectadas}", "Resultado de la operación");
                    }
                }

                return filasAfectadas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ejecutar el query:\n{ex.Message}", "Error en la base de datos");
                return -1;
            }
            finally
            {
                this.cerrar();
            }
        }
    }
}