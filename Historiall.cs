using Roll_Call.Alumnos;
using Roll_Call.DAL;
using Roll_Call.Historial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roll_Call
{
    public partial class Historiall : Form
    {
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
    }
}
