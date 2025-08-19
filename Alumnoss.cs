using Roll_Call.Alumnos;
using Roll_Call.BNL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roll_Call
{
    /// <summary>
    /// Formulario para la gestión de alumnos
    /// </summary>
    public partial class Alumnoss : Form
    {
        /// <summary>
        /// Constructor de la clase Alumnoss.
        /// Inicializa los componentes y establece la imagen de fondo.
        /// </summary>
        public Alumnoss()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.gris_patron;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        /// <summary>
        /// Evento Load del formulario.
        /// Carga los datos de los alumnos en el DataGridView al iniciar el formulario.
        /// </summary>
        private void Alumnos_Load(object sender, EventArgs e)
        {
            DAL.RepositoryAlumno ObjetoUsuario = new DAL.RepositoryAlumno();
            ObjetoUsuario.mostrarEmpleados(dgvAlumnos);
        }

        /// <summary>
        /// Evento Click para el botón Añadir Alumno.
        /// Abre el formulario para agregar un nuevo alumno y actualiza la tabla.
        /// </summary>
        private void btnAñadirAlumno_Click(object sender, EventArgs e)
        {
            using (btnAñadirAlumno ventana = new btnAñadirAlumno())
            {
                ventana.ShowDialog();
                ActualizarTabla();
            }
        }

        /// <summary>
        /// Evento Click para el botón Modificar Alumno.
        /// Abre el formulario de edición con los datos del alumno seleccionado y actualiza la tabla.
        /// </summary>
        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvAlumnos.SelectedRows[0];

                BNL.alumno alumno = new BNL.alumno();
                alumno.Matricula = Convert.ToInt32(selectedRow.Cells["Matricula"].Value);
                alumno.Nombre = selectedRow.Cells["Nombre"].Value.ToString();
                alumno.Apellidos = selectedRow.Cells["Apellidos"].Value.ToString();
                alumno.Fecha_Nac = selectedRow.Cells["Fecha_Nac"].Value.ToString();
                alumno.Correo = selectedRow.Cells["Correo"].Value.ToString();
                alumno.Estatus = selectedRow.Cells["Estatus"].Value.ToString();

                using (btnModificarAlumno ventana = new btnModificarAlumno(alumno))
                {
                    ventana.ShowDialog();
                    ActualizarTabla();
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un alumno para modificar.");
            }
        }

        /// <summary>
        /// Evento CellContentClick del DataGridView.
        /// </summary>
        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sin implementación específica
        }

        /// <summary>
        /// Actualiza los datos mostrados en el DataGridView.
        /// </summary>
        public void ActualizarTabla()
        {
            DAL.conexion Actualizar = new DAL.conexion();
            dgvAlumnos.DataSource = Actualizar.ObtenerDatos("SELECT * FROM ALUMNO");
        }

        /// <summary>
        /// Evento Click para el botón Eliminar Alumno.
        /// Desactiva el alumno seleccionado y actualiza la tabla.
        /// </summary>
        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            DAL.RepositoryAlumno handlerAlumno = new DAL.RepositoryAlumno();
            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvAlumnos.SelectedRows[0];
                int matricula = Convert.ToInt32(selectedRow.Cells["Matricula"].Value);
                handlerAlumno.Desactivarusuario(matricula);
                ActualizarTabla();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un alumno para modificar.");
            }
        }
    }
}