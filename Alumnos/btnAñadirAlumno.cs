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
    /// <summary>
    /// Formulario para agregar nuevos alumnos al sistema
    /// </summary>
    public partial class btnAñadirAlumno : Form
    {
        /// <summary>
        /// Diccionario que mapea nombres de materias con sus respectivos IDs
        /// </summary>
        private Dictionary<string, int> materiasDictionary = new Dictionary<string, int>()
        {
            { "MATEMÁTICAS", 1 },
            { "CIENCIAS NATURALES", 2 },
            { "HISTORIA", 3 },
            { "GEOGRAFÍA", 4 },
            { "CÍVICA Y ÉTICA", 5 }
        };

        /// <summary>
        /// Constructor del formulario. Inicializa los componentes y carga las materias en el CheckListBox.
        /// </summary>S
        public btnAñadirAlumno()
        {
            InitializeComponent();
            CargarMateriasEnCheckListBox();
        }

        // Importaciones para funcionalidad de arrastrar el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        /// <summary>
        /// Evento Load del formulario
        /// </summary>
        private void btnAñadirAlumno_Load(object sender, EventArgs e) { }

        /// <summary>
        /// Maneja el evento MouseDown para permitir arrastrar el formulario
        /// </summary>
        private void btnAñadirAlumno_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Cierra el formulario al hacer clic en el botón Salir
        /// </summary>
        private void btnSalirAlumno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Maneja el evento MouseDown en la PictureBox para permitir arrastrar el formulario
        /// </summary>
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Maneja el evento MouseDown en el panel para permitir arrastrar el formulario
        /// </summary>
        private void panelbtnAlumno_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Maneja el evento Click del botón Guardar. Valida y guarda los datos del nuevo alumno.
        /// </summary>
        private void btnGuardarAlumno_Click(object sender, EventArgs e)
        {
            DAL.RepositoryAlumno handlerAlumno = new DAL.RepositoryAlumno();
            BNL.alumno alumno = new BNL.alumno();
            bool isValid = false;
            string mensaje = "";
            string fecha = txtFechaNac.Text;
            string fechaFormateada = "";
            DateTime fechaConvertida;

            // Validación y formateo de fecha
            if (DateTime.TryParse(fecha, out fechaConvertida))
            {
                fechaFormateada = fechaConvertida.ToString("yyyy-MM-dd");
            }
            else
            {
                Console.WriteLine("Formato de fecha inválido");
                return;
            }

            // Asignación de valores al objeto alumno
            alumno.Nombre = txtNombre.Text;
            alumno.Apellidos = txtApellidos.Text;
            alumno.Fecha_Nac = fechaFormateada;
            alumno.Correo = txtCorreo.Text;
            alumno.Estatus = "ACTIVO";

            try
            {
                // Validación de datos del alumno
                (isValid, mensaje) = alumno.validarDatos();

                if (!isValid)
                {
                    MessageBox.Show(mensaje);
                    return;
                }

                // Guardar alumno en la base de datos
                handlerAlumno.ingresarAlumno(alumno);

                // Procesar materias seleccionadas
                List<int> misMaterias = ObtenerMateriasSeleccionadas();
                DAL.RepositoryCursa handerCursa = new DAL.RepositoryCursa();
                handerCursa.IngresarRegistro(alumno, misMaterias);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar alumno: " + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Obtiene los IDs de las materias seleccionadas en el CheckListBox
        /// </summary>
        /// <returns>Lista de IDs de materias seleccionadas</returns>
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

            MessageBox.Show($"IDs de materias seleccionadas: {string.Join(", ", materiasIds)}");
            return materiasIds;
        }

        // Eventos sin implementación específica (mantenidos para posibles futuras extensiones)
        private void cbxMaterias_SelectedIndexChanged(object sender, EventArgs e) { }
        private void panelbtnAlumno_Paint(object sender, PaintEventArgs e) { }
        private void txtCorreo_TextChanged(object sender, EventArgs e) { }
        private void txtFechaNac_TextChanged(object sender, EventArgs e) { }
        private void txtApellidos_TextChanged(object sender, EventArgs e) { }
        private void txtNombre_TextChanged(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtFechaNac_ValueChanged(object sender, EventArgs e) { }

        /// <summary>
        /// Carga las materias del diccionario en el CheckListBox
        /// </summary>
        private void CargarMateriasEnCheckListBox()
        {
            checkMateria.Items.Clear();
            foreach (string materia in materiasDictionary.Keys)
            {
                checkMateria.Items.Add(materia);
            }
        }
    }
}