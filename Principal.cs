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
    /// Formulario principal que sirve como contenedor para los demás formularios de la aplicación
    /// </summary>
    public partial class Principal : Form
    {
        /// <summary>
        /// Constructor que inicializa el formulario principal
        /// </summary>
        public Principal()
        {
            InitializeComponent();
            DAL.conexion conexion = new DAL.conexion();
            conexion.establecerConexion(); // Establece la conexión con la base de datos
            AbrirFormularioEnPanel(new Asistencias()); // Abre el formulario de asistencias por defecto
        }

        /// <summary>
        /// Evento Click para el botón de cerrar sesión
        /// </summary>
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Termina la aplicación completamente
        }

        /// <summary>
        /// Evento Load del formulario principal que configura su apariencia
        /// </summary>
        private void Principal_Load(object sender, EventArgs e)
        {
            AutoScaleMode = AutoScaleMode.None;

            // Configuración de la ventana principal
            StartPosition = FormStartPosition.Manual;
            Bounds = Screen.PrimaryScreen.Bounds; // Ocupa toda la pantalla
            FormBorderStyle = FormBorderStyle.None; // Elimina bordes y barra de título

            // Establece la imagen de fondo del panel principal
            panelPrincipal.BackgroundImage = Properties.Resources.gris_patron;
            panelPrincipal.BackgroundImageLayout = ImageLayout.Stretch;
        }

        /// <summary>
        /// Evento Paint del panel de cerrar sesión (sin implementación específica)
        /// </summary>
        private void panelCerrarSesion_Paint(object sender, PaintEventArgs e)
        {
            // Sin implementación específica
        }

        /// <summary>
        /// Evento Click para el botón de asistencias
        /// </summary>
        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Asistencias()); // Abre el formulario de asistencias
        }

        /// <summary>
        /// Evento Paint del panel principal (sin implementación específica)
        /// </summary>
        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {
            // Sin implementación específica
        }

        /// <summary>
        /// Método para abrir formularios hijos dentro del panel principal
        /// </summary>
        /// <param name="formHijo">Formulario que se mostrará dentro del panel</param>
        private void AbrirFormularioEnPanel(Form formHijo)
        {
            // Limpiar el panel si ya contiene otro formulario
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);

            // Configurar el formulario hijo
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            // Agregar y mostrar el formulario
            this.panelPrincipal.Controls.Add(formHijo);
            this.panelPrincipal.Tag = formHijo;
            formHijo.Show();
        }

        /// <summary>
        /// Evento Click para el botón de alumnos
        /// </summary>
        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Alumnoss()); // Abre el formulario de alumnos
        }

        /// <summary>
        /// Evento Click para el botón de historial
        /// </summary>
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Historiall()); // Abre el formulario de historial
        }
    }
}