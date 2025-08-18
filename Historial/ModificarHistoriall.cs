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
    public partial class ModificarHistoriall : Form
    {
        public ModificarHistoriall()
        {
            InitializeComponent();
            ConfigurarDataGridView(); // CONFIGURACION DEL DATAGRIVD
            CargarDatos(); // Carga los datos al iniciar el formulario
            CargarMaterias(); // Carga las materias al iniciar el formulario
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void ModificarHistoriall_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGuardarModificaiones_Click(object sender, EventArgs e)
        {
            if (dvgModificarAsistencias.DataSource == null || dvgModificarAsistencias.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para modificar.");
                return;
            }
            foreach (DataGridViewRow row in dvgModificarAsistencias.Rows)
            {
                if (row.IsNewRow) continue;
            }
            ModificarHistorial(); // Llama al método para modificar el historial de asistencias
        }

        private void ModificarHistoriall_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();//Mueve el formulario al hacer clic y arrastrar
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();//Mueve el formulario al hacer clic y arrastrar
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();//Mueve el formulario al hacer clic y arrastrar
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void dvgModificarAsistencias_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();//Mueve el formulario al hacer clic y arrastrar
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnSalirModificaciones_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }

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

        //Si en la busqueda se busca por fecha y materia
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

        // Método para decidir qué búsqueda ejecutar
        private void BuscarAsistencia()
        {
            if (!string.IsNullOrEmpty(cbxMateria.Text) && dtpBuscarFecha.Value != null)
            {
                // Buscar por fecha y materia
                BuscarAsistenciaFechaMateria(dtpBuscarFecha.Value.Date, cbxMateria.Text);
            }
            else if (!string.IsNullOrEmpty(cbxMateria.Text))
            {
                // Buscar solo por materia
                BuscarAsistenciaMateria(cbxMateria.Text);
            }
            else if (dtpBuscarFecha.Value != null)
            {
                // Buscar solo por fecha
                BuscarAsistenciaFecha(dtpBuscarFecha.Value.Date);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione al menos una materia o una fecha para buscar.");
                dvgModificarAsistencias.DataSource = null;
            }
        }

        private void ModificarHistorial()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(DAL.conexion.cadenaBD))
                {
                    conexion.Open();
                    foreach (DataGridViewRow row in dvgModificarAsistencias.Rows)
                    {
                        if (row.IsNewRow) continue; // Ignorar la fila nueva
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

        private void cbxMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxMateria.SelectedItem != null)
            {
                BuscarAsistencia(); // Llama al método para buscar asistencia al cambiar la materia
            }
        }

        private void dtpBuscarFecha_ValueChanged(object sender, EventArgs e)
        {
            BuscarAsistencia(); // Llama al método para buscar asistencia al cambiar la fecha
        }
    }
}
