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
    public partial class btnModificarAlumno : Form
    {
        public btnModificarAlumno()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnModificarAlumno_Load(object sender, EventArgs e)
        {
            
        }

        private void btnModificarAlumno_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();// Mueve el formulario al hacer clic y arrastrar
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnSalirModificarAlumno_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();//Mueve el formulario al hacer clic y arrastrar
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();//Mueve el formulario al hacer clic y arrastrar
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
