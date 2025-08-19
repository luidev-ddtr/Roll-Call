using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Roll_Call
{
    public partial class Login : Form
    {
        /// <summary>
        /// Constructor de la clase Login. Inicializa los componentes y establece btnInicio como botón predeterminado.
        /// </summary>
        public Login()
        {
            InitializeComponent();
            AcceptButton = btnInicio;
        }

        /// <summary>
        /// Evento Load del formulario. Configura el modo de escalado y la apariencia inicial del formulario.
        /// </summary>
        private void Login_Load(object sender, EventArgs e)
        {
            AutoScaleMode = AutoScaleMode.None;
            StartPosition = FormStartPosition.Manual;
            FormBorderStyle = FormBorderStyle.None;
        }

        // Métodos simplificados con expresión lambda
        private void pictureBox1_Click(object sender, EventArgs e)  {}
        private void txtUsuario_TextChanged(object sender, EventArgs e) {}

        /// <summary>
        /// Evento Click del botón Cerrar. Termina la aplicación.
        /// </summary>
        private void btnCerrar_Click(object sender, EventArgs e) => Application.Exit();

        private Panel panel1;
        private Panel panel2;

        /// <summary>
        /// Evento Click del botón Inicio. Valida las credenciales de usuario.
        /// </summary>
        private void btnInicio_Click(object sender, System.EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (string.IsNullOrEmpty(usuario) && contraseña == txtContraseña.Text)
            {
                MessageBox.Show("Por favor, ingrese el nombre del usuario.");
                return;
            }
            else if (usuario == txtUsuario.Text && string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingrese la contraseña.");
                return;
            }
            else if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            else if (usuario == "admin" && contraseña == "admin")
            {
                Principal ventana = new Principal();
                ventana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}