using Roll_Call.Alumnos;
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
    public partial class Alumnoss : Form
    {
        public Alumnoss()
        {
            InitializeComponent();
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
            DAL.RepositoryAlumno ObjetoUsuario = new DAL.RepositoryAlumno();

            ObjetoUsuario.mostrarEmpleados(dgvAlumnos);
        }

        private void btnAñadirAlumno_Click(object sender, EventArgs e)
        {
            btnAñadirAlumno ventana = new btnAñadirAlumno();
            ventana.DatosActualizados += ActualizarInterfaz;
            ventana.Show();
        }

        private void ActualizarInterfaz()
        {
            // Aquí actualizas tu DataGridView o lo que necesites
            dgvAlumnos.Refresh();
            // O cargar datos nuevamente si es necesario
        }

        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            object datoAlumno = dgvAlumnos.DataSource;
            MessageBox.Show(datoAlumno.GetType().ToString());

            //foreach (var o in datoAlumno)
            //    MessageBox.Show(o.ToString());
            btnModificarAlumno ventana = new btnModificarAlumno();
            ventana.Show();
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
