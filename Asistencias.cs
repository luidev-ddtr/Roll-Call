using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Roll_Call.DAL;

namespace Roll_Call
{
    public partial class Asistencias : Form
    {
        public Asistencias()
        {
            InitializeComponent();
          this.BackgroundImage = Properties.Resources.gris_patron;
           this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Asistencias_Load(object sender, EventArgs e)
        {
          
        }

        public void CargarDatos()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.ConexionBd.CadenaConexion))
                {
                    conexion.Open();
                    string consulta = "SELECT Matricula, Nombre, Apellidos FROM Alumno WHERE Estatus = 'ACTIVO'";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgvAsistencias.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void CargarMaterias()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.ConexionBd.CadenaConexion))
                {
                    conexion.Open();
                    string consulta = "SELECT ID_Asignatura, Nombre FROM Asignatura";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    cbxMateria.DataSource = tabla;
                    cbxMateria.DisplayMember = "Nombre";
                    cbxMateria.ValueMember = "ID_Asignatura";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las materias: " + ex.Message);
            }
        }
    }
}
