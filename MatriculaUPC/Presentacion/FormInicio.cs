using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaUPC.Presentacion
{
    public partial class FormInicio: Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnCrearCursos_Click(object sender, EventArgs e)
        {
            //Sin función
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            //Sin función
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void registroDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCursos formCursos = new FormCursos();
            formCursos.Show();
        }

        private void buscarYCursoMasAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportes formReportes = new FormReportes();
            formReportes.Show();
        }

        private void ordenarAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporteOrden formReporteOrden = new FormReporteOrden();
            formReporteOrden.Show();
        }
    }
}
