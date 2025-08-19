using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Roll_Call.DAL;

namespace Roll_Call.Historial
{
    /// <summary>
    /// Formulario para modificar el historial de asistencias de alumnos
    /// </summary>
    public partial class ModificarHistoriall : Form
    {
        /// <summary>
        /// Constructor que inicializa el formulario y carga los datos iniciales
        /// </summary>
        public ModificarHistoriall()
        {
            InitializeComponent();
            ConfigurarDataGridView(); // Configura las columnas del DataGridView
            CargarDatos(); // Carga los datos iniciales de asistencias
            CargarMaterias(); // Carga la lista de materias disponibles
        }

        // Importaciones para permitir arrastrar el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        /// <summary>
        /// Evento Load del formulario
        /// </summary>
        private void ModificarHistoriall_Load(object sender, EventArgs e) { }

        /// <summary>
        /// Guarda las modificaciones realizadas en el historial de asistencias
        /// </summary>
        private void btnGuardarModificaiones_Click(object sender, EventArgs e)
        {
            if (dvgModificarAsistencias.DataSource == null || dvgModificarAsistencias.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para modificar.");
                return;
            }
            ModificarHistorial(); // Actualiza los registros en la base de datos
        }

        // Eventos para permitir arrastrar el formulario
        private void ModificarHistoriall_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void dvgModificarAsistencias_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Cierra el formulario actual
        /// </summary>
        private void btnSalirModificaciones_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Configura la columna de estado en el DataGridView como ComboBox
        /// </summary>
        private void ConfigurarDataGridView()
        {
            if (!dvgModificarAsistencias.Columns.Contains("Estado"))
            {
                DataGridViewComboBoxColumn estadoColumna = new DataGridViewComboBoxColumn
                {
                    Name = "Estado",
                    HeaderText = "Estado",
                    DataPropertyName = "Estado",
                    DataSource = new string[] { "Presente", "Ausente", "Justificado" }
                };
                dvgModificarAsistencias.Columns.Add(estadoColumna);
            }
        }

        /// <summary>
        /// Carga todos los registros de asistencias en el DataGridView
        /// </summary>
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
                    dvgModificarAsistencias.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        /// <summary>
        /// Carga la lista de materias en el ComboBox
        /// </summary>
        private void CargarMaterias()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(DAL.conexion.cadenaBD))
                {
                    conexion.Open();
                    string consulta = "SELECT ID_Asignatura, Nombre FROM Asignatura";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    cbxMateria.DataSource = tabla;
                    cbxMateria.DisplayMember = "Nombre";
                    cbxMateria.ValueMember = "ID_Asignatura";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las materias: " + ex.Message);
            }
        }

        /// <summary>
        /// Busca asistencias por fecha específica
        /// </summary>
        /// <param name="fecha">Fecha a buscar</param>
        private void BuscarAsistenciaFecha(DateTime fecha)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(DAL.conexion.cadenaBD))
                {
                    conexion.Open();
                    string consulta = "SELECT * FROM VistaAsistencias WHERE Fecha LIKE @buscar";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@buscar", "%" + fecha + "%");
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dvgModificarAsistencias.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar asistencia por fecha: " + ex.Message);
            }
        }

        /// <summary>
        /// Busca asistencias por materia específica
        /// </summary>
        /// <param name="buscar">Nombre de la materia a buscar</param>
        private void BuscarAsistenciaMateria(String buscar)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(DAL.conexion.cadenaBD))
                {
                    conexion.Open();
                    string consulta = "SELECT * FROM VistaAsistencias WHERE Materia LIKE @buscar";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@buscar", "%" + buscar + "%");
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dvgModificarAsistencias.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar asistencia por materia: " + ex.Message);
            }
        }

        /// <summary>
        /// Busca asistencias por fecha y materia específicas
        /// </summary>
        /// <param name="fecha">Fecha a buscar</param>
        /// <param name="buscar">Nombre de la materia a buscar</param>
        private void BuscarAsistenciaFechaMateria(DateTime fecha, String buscar)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(DAL.conexion.cadenaBD))
                {
                    conexion.Open();
                    string consulta = @"
                SELECT Matricula, Nombre, Apellidos, Materia, Fecha, Estado 
                FROM VistaAsistencias 
                WHERE Materia = @Materia 
                AND CAST(Fecha AS DATE) = CAST(@Fecha AS DATE)";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@Materia", buscar);
                    comando.Parameters.AddWithValue("@Fecha", fecha);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dvgModificarAsistencias.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar asistencia por fecha y materia: " + ex.Message);
            }
        }

        /// <summary>
        /// Decide qué tipo de búsqueda ejecutar según los filtros seleccionados
        /// </summary>
        private void BuscarAsistencia()
        {
            if (!string.IsNullOrEmpty(cbxMateria.Text) && dtpBuscarFecha.Value != null)
            {
                BuscarAsistenciaFechaMateria(dtpBuscarFecha.Value.Date, cbxMateria.Text);
            }
            else if (!string.IsNullOrEmpty(cbxMateria.Text))
            {
                BuscarAsistenciaMateria(cbxMateria.Text);
            }
            else if (dtpBuscarFecha.Value != null)
            {
                BuscarAsistenciaFecha(dtpBuscarFecha.Value.Date);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione al menos una materia o una fecha para buscar.");
                dvgModificarAsistencias.DataSource = null;
            }
        }

        /// <summary>
        /// Actualiza el estado de las asistencias en la base de datos
        /// </summary>
        private void ModificarHistorial()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(DAL.conexion.cadenaBD))
                {
                    conexion.Open();
                    foreach (DataGridViewRow row in dvgModificarAsistencias.Rows)
                    {
                        if (row.IsNewRow) continue;
                        string matricula = row.Cells["Matricula"].Value.ToString();
                        string estado = row.Cells["Estado"].Value.ToString();
                        DateTime fecha = Convert.ToDateTime(row.Cells["Fecha"].Value);
                        string consulta = "UPDATE Asistencia SET Estado = @Estado WHERE Matricula = @Matricula AND Fecha = @Fecha";
                        SqlCommand comando = new SqlCommand(consulta, conexion);
                        comando.Parameters.AddWithValue("@Estado", estado);
                        comando.Parameters.AddWithValue("@Matricula", matricula);
                        comando.Parameters.AddWithValue("@Fecha", fecha);
                        comando.ExecuteNonQuery();
                    }
                    MessageBox.Show("Modificaciones guardadas exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el historial: " + ex.Message);
            }
        }

        /// <summary>
        /// Evento que se dispara al cambiar la materia seleccionada
        /// </summary>
        private void cbxMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMateria.SelectedItem != null)
            {
                BuscarAsistencia();
            }
        }

        /// <summary>
        /// Evento que se dispara al cambiar la fecha seleccionada
        /// </summary>
        private void dtpBuscarFecha_ValueChanged(object sender, EventArgs e)
        {
            BuscarAsistencia();
        }

        /// <summary>
        /// Evento Paint del panel
        /// </summary>
        private void panel5_Paint(object sender, PaintEventArgs e) { }
    }
}