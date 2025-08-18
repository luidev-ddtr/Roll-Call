using Roll_Call.Alumnos;
using Roll_Call.Historial;
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
    public partial class Historiall : Form
    {
        public Historiall()
        {
            InitializeComponent();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            AutoScaleMode = AutoScaleMode.None;

            // Ajustar el formulario a la pantalla principal
            StartPosition = FormStartPosition.Manual;
            Bounds = Screen.PrimaryScreen.Bounds; // Ocupa todo el área visible
            FormBorderStyle = FormBorderStyle.None; // Sin bordes ni barra de título
        }

        private void btnModificarHistorial_Click(object sender, EventArgs e)
        {
            ModificarHistoriall ventana = new ModificarHistoriall();
            ventana.Show();
        }
    }
}
