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

namespace Roll_Call.Historial
{
    public partial class ModificarHistoriall : Form
    {
        public ModificarHistoriall()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void ModificarHistoriall_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGuardarModificaiones_Click(object sender, EventArgs e)
        {

        }

        private void ModificarHistoriall_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();//Mueve el formulario al hacer clic y arrastrar
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();//Mueve el formulario al hacer clic y arrastrar
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();//Mueve el formulario al hacer clic y arrastrar
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void dvgModificarAsistencias_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();//Mueve el formulario al hacer clic y arrastrar
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnSalirModificaciones_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }
    }
}
