using Python.Runtime;
using Roll_Call.Alumnos;
using Roll_Call.DAL;
using Roll_Call.Historial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Roll_Call
{
    public partial class Historiall : Form
    {
        private dynamic TablaDatos;
        public Historiall()
        {

            InitializeComponent();
            this.BackgroundImage = Properties.Resources.gris_patron;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            CargarDatos(); // Carga los datos al iniciar el formulario
        }
        private void Historial_Load(object sender, EventArgs e)
        {
            AutoScaleMode = AutoScaleMode.None;

            // Ajustar el formulario a la pantalla principal
            StartPosition = FormStartPosition.Manual;
            Bounds = Screen.PrimaryScreen.Bounds; // Ocupa todo el área visible
            FormBorderStyle = FormBorderStyle.None; // Sin bordes ni barra de título

            // La fecha minima sera a la del primer registro en la base de datos
            dtpBuscarFecha.MinDate = new DateTime(2025, 1, 1);
            // La fecha maxima sera la fecha actual
            dtpBuscarFecha.MaxDate = DateTime.Today.AddDays(7);
        }

        private void btnModificarHistorial_Click(object sender, EventArgs e)
        {
            ModificarHistoriall ventana = new ModificarHistoriall();
            ventana.Show();
        }


        private void CargarDatos()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(DAL.conexion.cadenaBD))
                {
                    conexion.Open();
                    string consulta = "SELECT * FROM VistaAsistencias";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgvHistorial.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void BuscarAsistencia(string busqueda)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(DAL.conexion.cadenaBD))
                {
                    conexion.Open();
                    // Consulta para buscar asistencia por asignatura y fecha
                    string consulta = "SELECT * FROM VistaAsistencias WHERE  Fecha LIKE @busqueda";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    adaptador.SelectCommand.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%");
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgvHistorial.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar la asistencia: " + ex.Message);
            }
        }

        private void dtpBuscarFecha_ValueChanged(object sender, EventArgs e)
        {
            BuscarAsistencia(dtpBuscarFecha.Value.ToString("yyyy-MM-dd"));
        }

        // Método para generar el reporte
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            DataTable TablaDatos = new DataTable(); // Asumimos que esta variable está declarada a nivel de clase

            try
            {
                using (SqlConnection conexion = new SqlConnection(DAL.conexion.cadenaBD))
                {
                    conexion.Open();
                    string consulta = "SELECT * FROM VistaAsistencias";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    adaptador.Fill(TablaDatos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
                return;
            }

            // --- INICIO DEL NUEVO CÓDIGO PARA GENERAR CSV ---
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                saveFileDialog.Title = "Guardar reporte de asistencias";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                    {
                        // Escribir encabezados
                        foreach (DataColumn columna in TablaDatos.Columns)
                        {
                            sw.Write($"\"{columna.ColumnName}\"");
                            if (columna.Ordinal < TablaDatos.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();

                        // Escribir datos
                        foreach (DataRow fila in TablaDatos.Rows)
                        {
                            for (int i = 0; i < TablaDatos.Columns.Count; i++)
                            {
                                string valor = fila[i].ToString();

                                // Escapar comillas y manejar campos especiales
                                valor = valor.Replace("\"", "\"\"");

                                sw.Write($"\"{valor}\"");
                                if (i < TablaDatos.Columns.Count - 1)
                                    sw.Write(",");
                            }
                            sw.WriteLine();
                        }
                    }
                    MessageBox.Show("Reporte exportado exitosamente", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar CSV: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // --- FIN DEL NUEVO CÓDIGO PARA GENERAR CSV ---
        }
    }
}
