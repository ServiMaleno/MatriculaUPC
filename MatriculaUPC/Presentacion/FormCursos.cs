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
    public partial class FormCursos: Form
    {
        private nCurso negocioCurso = new nCurso();
        public FormCursos()
        {
            InitializeComponent();
            //LimpiarCampos();
            ListarCursos();
        }
        private void ListarCursos()
        {
            dgvListarCursos.DataSource = null;
            List<Curso> cursos = negocioCurso.ListarCursos();
            if(cursos!=null && cursos.Count > 0)
            {
                dgvListarCursos.DataSource = cursos;
            }
        }
        private void LimpiarCampos()
        {
            txtCodigoCurso.Clear();
            txtNombreCurso.Clear();
            txtCreditosCurso.Clear();
            txtCodigoCurso.Focus();
        }
        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoCurso.Text) ||
                    string.IsNullOrEmpty(txtNombreCurso.Text) ||
                        string.IsNullOrEmpty(txtCreditosCurso.Text))
            {
                MessageBox.Show("Complete todos los campos","Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtCodigoCurso.Text, out int codigo))
            {
                MessageBox.Show("El codigo deben ser un numero entero", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCampos();
                return;
            }
            if (!int.TryParse(txtCreditosCurso.Text, out int creditos))
            {
                MessageBox.Show("Los creditos deben ser un numero entero", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCampos();
                return;
            }
            Curso curso = new Curso
            {
                codigoCurso = int.Parse(txtCodigoCurso.Text),
                nombreCurso = txtNombreCurso.Text,
                creditosCurso = int.Parse(txtCreditosCurso.Text)
            };

            bool agregarCurso = negocioCurso.CrearCurso(curso);
            if (agregarCurso)
            {
                MessageBox.Show("Curso agregado correctamente", "Exito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                ListarCursos();
            } else
            {
                MessageBox.Show("El codigo del curso ya existe", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCampos();
            }
        }

        private void btnAgregarAlumnos_Click(object sender, EventArgs e)
        {
            if(dgvListarCursos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un curso para agregar alumnos.", "Aviso",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int codigoCursoSeleccionado = Convert.ToInt32(dgvListarCursos.CurrentRow.Cells["codigoCurso"].Value);

            FormAlumnos formAlumnos = new FormAlumnos(codigoCursoSeleccionado);
            formAlumnos.ShowDialog();
        }
    }
}
