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
            Application.Exit(); // Cierra la aplicación
        }

        

        private void Principal_Load(object sender, EventArgs e)
        {
            AutoScaleMode = AutoScaleMode.None;

            // Ajustar el formulario a la pantalla principal
            StartPosition = FormStartPosition.Manual;
            Bounds = Screen.PrimaryScreen.Bounds; // Ocupa todo el área visible
            FormBorderStyle = FormBorderStyle.None; // Sin bordes ni barra de título
            panelPrincipal.BackgroundImage = Properties.Resources.gris_patron;
            panelPrincipal.BackgroundImageLayout=ImageLayout.Stretch;
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
        private void AbrirFormularioEnPanel(Form formHijo)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(formHijo);
            this.panelPrincipal.Tag = formHijo;
            formHijo.Show();
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
