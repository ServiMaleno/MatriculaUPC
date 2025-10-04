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
    public partial class FormBuscar : Form
    {
        private nAlumno nAlumno = new nAlumno();
        public FormBuscar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                MessageBox.Show("Ingrese un nombre o parte del nombre para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgvAlumnosEdad.DataSource = null;
            dgvAlumnosEdad.DataSource = nAlumno.BuscarAlumnosPorEdad(int.Parse(txtBuscar.Text));
        }
    }
}
