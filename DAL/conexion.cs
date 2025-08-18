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
    internal class conexion
    {

        public static string CadenaConexion = "Server=localhost\\SQLEXPRESS01;Database=CONTROL_ESCOLAR;Trusted_Connection=True";

        public SqlConnection cursor = new SqlConnection();

        private string cadena =
            "Data Source=localhost\\SQLEXPRESS01;" + //Aqui Cambiar el usuario
            "Initial Catalog=CONTROL_ESCOLAR;" +
            "Integrated Security=True;" +
            "TrustServerCertificate=True;";

        public SqlConnection establecerConexion()
        {
            try
            {
                cursor.ConnectionString = cadena;
                cursor.Open();
                //MessageBox.Show("Conexión abierta exitosamente.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexión: " + ex.Message);
            }
            return cursor;
        }

        public void cerrar()
        {
            try
            {
                cursor.Close();
                //MessageBox.Show("Conexión cerrada exitosamente.");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("No se pudo cerrar la conexion" + ex.Message);
            }
        }


        // Método genérico para obtener datos (DataTable)
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

        // Método genérico para ejecutar consultas (INSERT/UPDATE/DELETE)
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
        /// Ejecuta una consulta SQL y muestra información de depuración
        /// </summary>
        /// <param name="query">Consulta SQL a ejecutar</param>
        /// <param name="mostrarMensajes">True para mostrar mensajes de depuración</param>
        /// <returns>Número de filas afectadas</returns>
        public int EjecutarQuery(string query, bool mostrarMensajes = true)
        {
            int filasAfectadas = 0;

            try
            {
                // Mostrar el query si está habilitado
                if (mostrarMensajes)
                {
                    MessageBox.Show($"Query a ejecutar:\n{query}", "Depuración - Query SQL");
                }

                // Establecer conexión
                this.establecerConexion();

                using (SqlCommand cmd = new SqlCommand(query, cursor))
                {
                    filasAfectadas = cmd.ExecuteNonQuery();

                    // Mostrar resultado si está habilitado
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
                return -1; // Retorna -1 para indicar error
            }
            finally
            {
                this.cerrar();
            }
        }

        /// <summary>
        /// Versión con parámetros para mayor seguridad
        /// </summary>
        public int EjecutarQueryConParametros(string query, Dictionary<string, object> parametros, bool mostrarMensajes = false)
        {
            int filasAfectadas = 0;

            try
            {
                // Mostrar información de depuración
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
                    // Agregar parámetros
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
