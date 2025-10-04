using MatriculaUPC.Negocio;
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
    public partial class FormReporteOrden : Form
    {
        public nAlumno nAlumno = new nAlumno();
        public FormReporteOrden()
        {
            InitializeComponent();
        }

        //Reportes del lado de Presentacion
        private void btnAscendente_Click(object sender, EventArgs e)
        {
            dgvAlumnosOrdenados.DataSource = null;
            dgvAlumnosOrdenados.DataSource = nAlumno.OrdenarTodosLosAlumnosPorNombreAsc();
        }

        private void btnDescendente_Click(object sender, EventArgs e)
        {
            dgvAlumnosOrdenados.DataSource = null;
            dgvAlumnosOrdenados.DataSource = nAlumno.OrdenarTodosLosAlumnosPorNombreDesc();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
