using MatriculaUPC.Entidades;
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
    public partial class FormReportes: Form
    {
        private nCurso negocioCurso = new nCurso();
        public FormReportes()
        {
            InitializeComponent();
        }

        // Método para limpiar controles
        private void LimpiarCampos()
        {
            txtBuscarCurso.Clear();       // Limpiar el TextBox de búsqueda
            dgvReportes.DataSource = null; // Limpiar el DataGridView
            txtBuscarCurso.Focus();       // Colocar el foco en el TextBox
        }

        //Reportes del lado de Presentacion
        private void btnCursoMasAlumnos_Click(object sender, EventArgs e)
        {
            List<Curso> cursosConMasAlumnos = negocioCurso.CursosConMasAlumnos();

            List<Curso> ListarCursos = negocioCurso.ListarCursos();

            if (ListarCursos.Count == 0)
            {
                MessageBox.Show("No hay cursos registrados en el sistema.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                return;
            }
            
            
            if (cursosConMasAlumnos.Count == 0 || cursosConMasAlumnos[0].listaAlumnos.Count == 0)
            {
                MessageBox.Show("Todos los cursos tienen cero (0) alumnos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                return;
            }
            else
            {
                dgvReportes.DataSource = null;
                dgvReportes.DataSource = cursosConMasAlumnos.ToList();
            }
            
        }

        //Buscar por código de curso
        private void btnBuscarCurso_Click(object sender, EventArgs e)
        {
            
            if (!int.TryParse(txtBuscarCurso.Text, out int codigoCurso))
            {
                MessageBox.Show("Ingrese un código válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCampos();
                return;
            }

            List<Curso> ListarCursos = negocioCurso.ListarCursos();

            if(ListarCursos.Count == 0)
            {
                MessageBox.Show("No hay cursos registrados en el sistema.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                return;
            }

            List<Curso> CursoBuscado = negocioCurso.BuscarCursoPorCodigo(codigoCurso);

            if (CursoBuscado.Count == 0)
            {
                MessageBox.Show("No se encontró ningún curso con ese código.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                dgvReportes.DataSource = null;
                dgvReportes.DataSource = CursoBuscado;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
