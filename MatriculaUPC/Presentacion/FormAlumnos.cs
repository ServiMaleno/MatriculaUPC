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
    public partial class FormAlumnos: Form
    {
        private int codigoCursoSeleccionado;
        private nAlumno negocioAlumno = new nAlumno();

        public FormAlumnos(int codigoCursoSeleccionado)
        {
            InitializeComponent();
            this.codigoCursoSeleccionado = codigoCursoSeleccionado;
            ListarAlumnos();
        }

        private void ListarAlumnos()
        {
            dgvAlumnos.DataSource = null;
            List<Alumno> alumnos = negocioAlumno.ListarAlumnos(codigoCursoSeleccionado);
            if(alumnos != null && alumnos.Count > 0)
            {
                dgvAlumnos.DataSource = alumnos;
            }
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtEdad.Clear();
            txtCodigo.Focus();
        }
        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            // Validar campos
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoPaterno.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoMaterno.Text) ||
                string.IsNullOrWhiteSpace(txtEdad.Text))
            {
                MessageBox.Show("Complete todos los campos.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                MessageBox.Show("La edad debe ser un número entero.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEdad.Focus();
                return;
            }

            // Crear alumno
            Alumno alumnoNuevo = new Alumno
            {
                codigoAlumno = txtCodigo.Text.Trim(),
                nombreAlumno = txtNombre.Text.Trim(),
                apellidoPaternoAlumno = txtApellidoPaterno.Text.Trim(),
                apellidoMaternoAlumno = txtApellidoMaterno.Text.Trim(),
                edadAlumno = edad
            };

            bool agregarAlumno = negocioAlumno.AgregarAlumno(codigoCursoSeleccionado, alumnoNuevo);
            
            if (agregarAlumno)
            {
                // Agregar alumno al curso
                MessageBox.Show("Alumno agregado correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                ListarAlumnos();
            }
            else
            {
                MessageBox.Show("El codigo del alumno ya existe en el curso", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCampos();
            }
        }
    }
}