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
    public partial class Alumnoss : Form
    {
        public Alumnoss()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.gris_patron;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
            DAL.RepositoryAlumno ObjetoUsuario = new DAL.RepositoryAlumno();

            ObjetoUsuario.mostrarEmpleados(dgvAlumnos);
        }

        private void btnAñadirAlumno_Click(object sender, EventArgs e)
        {
            using (btnAñadirAlumno ventana = new btnAñadirAlumno())
            {
                // Asegúrate que tu formulario acepte este parámetro
                ventana.ShowDialog();

                ActualizarTabla();
            }
        }


        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            // Verificar que haya una fila seleccionada
            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvAlumnos.SelectedRows[0];

                // Crear objeto alumno con los datos de la fila seleccionada

                BNL.alumno alumno = new BNL.alumno();
                alumno.Matricula = Convert.ToInt32(selectedRow.Cells["Matricula"].Value); // Ajusta "Id" al nombre real de tu columna
                alumno.Nombre = selectedRow.Cells["Nombre"].Value.ToString(); // Ajusta "Nombre" al nombre real
                alumno.Apellidos = selectedRow.Cells["Apellidos"].Value.ToString(); // Ajusta "Nombre" al nombre real
                alumno.Fecha_Nac = selectedRow.Cells["Fecha_Nac"].Value.ToString();
                alumno.Correo = selectedRow.Cells["Correo"].Value.ToString();
                alumno.Estatus = selectedRow.Cells["Estatus"].Value.ToString();

                // Crear y mostrar el formulario de edición pasando el alumno como parámetro
                using (btnModificarAlumno ventana = new btnModificarAlumno(alumno)) { 
                     // Asegúrate que tu formulario acepte este parámetro
                    ventana.ShowDialog();

                    ActualizarTabla();
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un alumno para modificar.");
            }
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void ActualizarTabla()
        {
            DAL.conexion Actualizar = new DAL.conexion();
            dgvAlumnos.DataSource = Actualizar.ObtenerDatos("SELECT * FROM ALUMNO");
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            DAL.RepositoryAlumno handlerAlumno = new DAL.RepositoryAlumno();
            // Verificar que haya una fila seleccionada
            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
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
