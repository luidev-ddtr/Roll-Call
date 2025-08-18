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
using Roll_Call.DAL;

namespace Roll_Call
{
    public partial class Asistencias : Form
    {
        public Asistencias()
        {
            InitializeComponent();
            CargarDatos(); // Carga los datos de los alumnos al iniciar el formulario
            CargarMaterias(); // Carga las materias al iniciar el formulario
            this.BackgroundImage = Properties.Resources.gris_patron;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Asistencias_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now; // Actualiza la fecha al valor actual
            dtpFecha.MinDate = DateTime.Now; // Establece la fecha mínima al día actual
        }

        public void CargarDatos()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(DAL.conexion.cadenaBD))
                {
                    conexion.Open();
                    string consulta = "SELECT Matricula, Nombre, Apellidos FROM Alumno WHERE Estatus = 'ACTIVO'";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgvAsistencias.DataSource = tabla;
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

        private void btnRegistrarAsistencia_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(DAL.conexion.cadenaBD))
                {
                    conexion.Open();

                    foreach (DataGridViewRow fila in dgvAsistencias.Rows)
                    {
                        // Obtener datos del alumno
                        int matricula = Convert.ToInt32(fila.Cells["Matricula"].Value);
                        int idAsignatura = Convert.ToInt32(cbxMateria.SelectedValue);
                        DateTime fecha = dtpFecha.Value;

                        // Asignar estado basado en selección
                        string estado = fila.Selected ? "Presente" : "Ausente";

                        // Validar que la matrícula exista en ALUMNO
                        string validarMatricula = "SELECT COUNT(*) FROM ALUMNO WHERE Matricula = @Matricula";
                        using (SqlCommand validarCmd = new SqlCommand(validarMatricula, conexion))
                        {
                            validarCmd.Parameters.AddWithValue("@Matricula", matricula);
                            int existe = (int)validarCmd.ExecuteScalar();

                            if (existe == 0)
                            {
                                MessageBox.Show($"La matrícula {matricula} no existe en la tabla ALUMNO. Se omitirá este registro.");
                                continue;
                            }
                        }

                        // Verificar si ya existe asistencia para ese alumno en esa fecha y asignatura
                        string verificarDuplicado = @"SELECT COUNT(*) FROM Asistencia 
                                                      WHERE Matricula = @Matricula AND ID_Asignatura = @ID_Asignatura
                                                      AND CAST(Fecha AS DATE) = CAST(@Fecha AS DATE)";
                        using (SqlCommand verificarCmd = new SqlCommand(verificarDuplicado, conexion))
                        {
                            verificarCmd.Parameters.AddWithValue("@Matricula", matricula);
                            verificarCmd.Parameters.AddWithValue("@ID_Asignatura", idAsignatura);
                            verificarCmd.Parameters.AddWithValue("@Fecha", fecha);
                            int yaRegistrado = (int)verificarCmd.ExecuteScalar();

                            if (yaRegistrado > 0)
                            {
                                MessageBox.Show("Los alumnos no pueden tener más de una asistencia en la misma fecha.");
                                return;
                            }
                        }

                        // Insertar asistencia
                        string consulta = "INSERT INTO Asistencia (Matricula, ID_Asignatura, Fecha, Estado) VALUES (@Matricula, @ID_Asignatura, @Fecha, @Estado)";
                        using (SqlCommand comando = new SqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@Matricula", matricula);
                            comando.Parameters.AddWithValue("@ID_Asignatura", idAsignatura);
                            comando.Parameters.AddWithValue("@Fecha", fecha);
                            comando.Parameters.AddWithValue("@Estado", estado);
                            comando.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Asistencia registrada correctamente.");

                    // Opcional: Deseleccionar todas las filas después de registrar
                    dgvAsistencias.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la asistencia: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cbxMateria.SelectedIndex = 0;
            dgvAsistencias.ClearSelection();
        }

        private void txtPeriodo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
