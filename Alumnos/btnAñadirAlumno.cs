using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Roll_Call.Alumnos
{
    public partial class btnAñadirAlumno : Form
    {
        public event Action DatosActualizados;

        private Dictionary<string, int> materiasDictionary = new Dictionary<string, int>()
            {
                { "MATEMÁTICAS", 1 },
                { "CIENCIAS NATURALES", 2 },
                { "HISTORIA", 3 },
                { "GEOGRAFÍA", 4 },
                { "CÍVICA Y ÉTICA", 5 }
            };
        public btnAñadirAlumno()
        {
            InitializeComponent();
            CargarMateriasEnCheckListBox();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]


        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnAñadirAlumno_Load(object sender, EventArgs e)
        {

        }

        private void btnAñadirAlumno_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();//Mueve el formulario al hacer clic y arrastrar
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnSalirAlumno_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();//Mueve el formulario al hacer clic y arrastrar
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void panelbtnAlumno_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();//Mueve el formulario al hacer clic y arrastrar
            SendMessage(Handle, 0x112, 0xf012, 0);
        }



        private void btnGuardarAlumno_Click(object sender, EventArgs e)
        {
            //TODA ESTA PARTE ES SOLO PARA SECCION ALUMNO
            DAL.RepositoryAlumno handlerAlumno = new DAL.RepositoryAlumno();
            BNL.alumno alumno = new BNL.alumno();
            bool isValid = false;
            string mensaje = "";
            string fecha = txtFechaNac.Text;
            string fechaFormateada = "";
            DateTime fechaConvertida;

            if (DateTime.TryParse(fecha, out fechaConvertida))
            {
                fechaFormateada = fechaConvertida.ToString("yyyy-MM-dd");
                Console.WriteLine(fechaFormateada); // Salida: "2025-08-17"
            }
            else
            {
                Console.WriteLine("Formato de fecha inválido");
            }

            alumno.Nombre = txtNombre.Text; //string
            alumno.Apellidos = txtApellidos.Text; // string
            alumno.Fecha_Nac = fechaFormateada;
            alumno.Correo = txtCorreo.Text; //String
            alumno.Estatus = "ACTIVO"; //tring

            try
            {
                
                (isValid, mensaje) = alumno.validarDatos();

                if (!isValid)
                {
                    MessageBox.Show(mensaje);
                    return;
                }

                handlerAlumno.ingresarAlumno(alumno);

                //Empieza aqui la seccion de cursa
                List<int> misMaterias = ObtenerMateriasSeleccionadas();

                DAL.RepositoryCursa handerCursa = new DAL.RepositoryCursa();
                handerCursa.IngresarRegistro(alumno, misMaterias);

                //Actualizar la interfaz padre:
                DatosActualizados?.Invoke();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar alumno: " + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 

        }

        private List<int> ObtenerMateriasSeleccionadas()
        {
            List<int> materiasIds = new List<int>();

            foreach (string materiaSeleccionada in checkMateria.CheckedItems)
            {
                if (materiasDictionary.ContainsKey(materiaSeleccionada))
                {
                    materiasIds.Add(materiasDictionary[materiaSeleccionada]);
                }
            }
            // materiasIds ahora contiene los IDs de las materias seleccionadas
            MessageBox.Show($"IDs de materias seleccionadas: {string.Join(", ", materiasIds)}");
            return materiasIds;


        }


        private void cbxMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelbtnAlumno_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFechaNac_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void CargarMateriasEnCheckListBox()
        {
            // Limpiar el CheckedListBox primero
            checkMateria.Items.Clear();

            // Agregar las materias directamente como strings usando las claves del diccionario
            foreach (string materia in materiasDictionary.Keys)
            {
                checkMateria.Items.Add(materia);
            }
        }

        private void txtFechaNac_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
