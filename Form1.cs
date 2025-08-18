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
        public Login()
        {
            InitializeComponent();
            AcceptButton = btnInicio; // Establece el botón de inicio como el botón predeterminado

        }

        private void Login_Load(object sender, EventArgs e)
        {

            AutoScaleMode = AutoScaleMode.None;

            // Ajustar el formulario a la pantalla principal
            StartPosition = FormStartPosition.Manual;
            //Bounds = Screen.PrimaryScreen.Bounds; // Ocupa todo el área visible
            FormBorderStyle = FormBorderStyle.None; // Sin bordes ni barra de título

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {



        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Panel panel1;
        private Panel panel2;
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
                this.Hide(); // oculta la actual
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}

