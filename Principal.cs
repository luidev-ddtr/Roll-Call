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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            DAL.conexion conexion = new DAL.conexion();

            conexion.establecerConexion(); // se establece

            AbrirFormularioEnPanel(new Asistencias()); // Abre el formulario de asistencias al iniciar
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Form loginForm = new Login(); // Crea una nueva instancia del formulario de inicio de sesión
            loginForm.Show(); // Muestra el formulario de inicio de sesión
            this.Close(); // Cierra el formulario principal
        }

        

        private void Principal_Load(object sender, EventArgs e)
        {
            AutoScaleMode = AutoScaleMode.None;

            // Ajustar el formulario a la pantalla principal
            StartPosition = FormStartPosition.Manual;
            //Bounds = Screen.PrimaryScreen.Bounds; // Ocupa todo el área visible
            FormBorderStyle = FormBorderStyle.None; // Sin bordes ni barra de título
        }

        private void panelCerrarSesion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Asistencias());
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {
        }
        private void AbrirFormularioEnPanel(Form formHija)
        {
            formHija.TopLevel = false; // Indica que el formulario es hijo
            formHija.Dock = DockStyle.Fill; // Rellena todo el panel
            this.panelPrincipal.Controls.Add(formHija); // Agrega el formulario al panel
            this.panelPrincipal.Tag = formHija;// Guarda el formulario en la propiedad Tag del panel
            formHija.Show(); // Muestra el formulario

            // Cierra el formulario anterior si existe
            if (this.panelPrincipal.Controls.Count > 0)
            {
                this.panelPrincipal.Controls.RemoveAt(0); // Elimina el formulario anterior
                Form fh = formHija as Form; // Convierte el objeto a Form
                fh.TopLevel = false; // Indica que el formulario es hijo
                fh.Dock = DockStyle.Fill; // Rellena todo el panel
                this.panelPrincipal.Controls.Add(fh); // Agrega el formulario al panel
                this.panelPrincipal.Tag = fh; // Guarda el formulario en la propiedad Tag del panel
                fh.Show(); // Muestra el formulario
            }
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Alumnoss());
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Historiall());
        }
    }
}
