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
    public partial class btnModificarAlumno : Form
    {
        public bool actualizar;
        public btnModificarAlumno(alumno DatosAlumno )
        {
            DAL.RepositoryAsignatura handlerMaterias = new DAL.RepositoryAsignatura(); 
            InitializeComponent();

            txtMatricula.Text = DatosAlumno.Matricula.ToString();
            txtNombre.Text = DatosAlumno.Nombre.ToString();
            txtApellidos.Text = DatosAlumno.Apellidos.ToString();
            txtFechaNac.Text = DatosAlumno.Fecha_Nac.ToString();
            txtCorreo.Text = DatosAlumno.Correo.ToString();
            //Para obtener materias
            txtMaterias.Text = handlerMaterias.GetasignaturaByMatricula(DatosAlumno.Matricula);
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

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFechaNac_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarModificarAlumno_Click(object sender, EventArgs e)
        {
            //TODA ESTA PARTE ES SOLO PARA SECCION ALUMNO
            DAL.RepositoryAlumno handlerAlumno = new DAL.RepositoryAlumno();
            BNL.alumno alumno = new BNL.alumno();
            bool isValid = false;
            string mensaje = "";


            alumno.Nombre = txtNombre.Text; //string
            alumno.Apellidos = txtApellidos.Text; // string
            alumno.Correo = txtCorreo.Text; //String
            alumno.Matricula = int.Parse(txtMatricula.Text);

            try
            {

                (isValid, mensaje) = alumno.validarDatos();

                if (!isValid)
                {
                    MessageBox.Show(mensaje);
                    return;
                }

                handlerAlumno.ModificarAlumno(alumno);


                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar alumno: " + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }
    }
}
