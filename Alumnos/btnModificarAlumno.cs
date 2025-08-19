using Roll_Call.BNL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roll_Call.Alumnos
{
    /// <summary>
    /// Formulario para modificar los datos de un alumno existente
    /// </summary>
    public partial class btnModificarAlumno : Form
    {
        /// <summary>
        /// Indica si se realizó una actualización de datos
        /// </summary>
        public bool actualizar;

        /// <summary>
        /// Constructor que inicializa el formulario con los datos del alumno
        /// </summary>
        /// <param name="DatosAlumno">Objeto alumno con los datos a mostrar en el formulario</param>
        public btnModificarAlumno(alumno DatosAlumno)
        {
            DAL.RepositoryAsignatura handlerMaterias = new DAL.RepositoryAsignatura();
            InitializeComponent();

            // Mostrar los datos del alumno en los controles del formulario
            txtMatricula.Text = DatosAlumno.Matricula.ToString();
            txtNombre.Text = DatosAlumno.Nombre.ToString();
            txtApellidos.Text = DatosAlumno.Apellidos.ToString();
            txtFechaNac.Text = DatosAlumno.Fecha_Nac.ToString();
            txtCorreo.Text = DatosAlumno.Correo.ToString();

            // Obtener y mostrar las materias del alumno
            txtMaterias.Text = handlerMaterias.GetasignaturaByMatricula(DatosAlumno.Matricula);
        }

        // Importaciones para la funcionalidad de arrastrar el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        /// <summary>
        /// Evento Load del formulario
        /// </summary>
        private void btnModificarAlumno_Load(object sender, EventArgs e) { }

        /// <summary>
        /// Permite arrastrar el formulario al hacer clic y mover el mouse
        /// </summary>
        private void btnModificarAlumno_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Cierra el formulario al hacer clic en el botón Salir
        /// </summary>
        private void btnSalirModificarAlumno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Permite arrastrar el formulario al hacer clic y mover el mouse en la PictureBox
        /// </summary>
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Permite arrastrar el formulario al hacer clic y mover el mouse en el panel
        /// </summary>
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        // Eventos sin implementación específica
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void txtMatricula_TextChanged(object sender, EventArgs e) { }
        private void txtFechaNac_TextChanged(object sender, EventArgs e) { }

        /// <summary>
        /// Guarda los cambios realizados en los datos del alumno
        /// </summary>
        private void btnGuardarModificarAlumno_Click(object sender, EventArgs e)
        {
            DAL.RepositoryAlumno handlerAlumno = new DAL.RepositoryAlumno();
            BNL.alumno alumno = new BNL.alumno();
            bool isValid = false;
            string mensaje = "";

            // Asignar los valores modificados al objeto alumno
            alumno.Nombre = txtNombre.Text;
            alumno.Apellidos = txtApellidos.Text;
            alumno.Correo = txtCorreo.Text;
            alumno.Matricula = int.Parse(txtMatricula.Text);

            try
            {
                // Validar los datos del alumno
                (isValid, mensaje) = alumno.validarDatos();

                if (!isValid)
                {
                    MessageBox.Show(mensaje);
                    return;
                }

                // Actualizar los datos del alumno en la base de datos
                handlerAlumno.ModificarAlumno(alumno);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar alumno: " + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}