using MatriculaUPC.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaUPC.Datos
{
    public class dAlumno
    {
        private static dCurso datosCurso = new dCurso();

        public void AgregarAlumno(int codigoCursoSeleccionado, Alumno alumno)
        {
            List<Curso> cursos = datosCurso.ListarCursos();
            Curso cursoSeleccionado = cursos.FirstOrDefault(c => c.codigoCurso == codigoCursoSeleccionado);
            cursoSeleccionado.listaAlumnos.Add(alumno);
        }

        public List<Alumno> ListarAlumnos(int codigoCursoSeleccionado)
        {
            List<Curso> cursos = datosCurso.ListarCursos();
            Curso cursoSeleccionado = cursos.FirstOrDefault(c => c.codigoCurso == codigoCursoSeleccionado);
            return cursoSeleccionado.listaAlumnos;
        }

        public List<Alumno> OrdenarTodosLosAlumnosPorNombreAsc()
        {
            List<Curso> cursos = datosCurso.ListarCursos();
            List<Alumno> todosLosAlumnos = cursos.SelectMany(c => c.listaAlumnos).ToList();
            return todosLosAlumnos.OrderBy(a => a.nombreAlumno).ToList();
        }
        public List<Alumno> OrdenarTodosLosAlumnosPorNombreDesc()
        {
            List<Curso> cursos = datosCurso.ListarCursos();
            List<Alumno> todosLosAlumnos = cursos.SelectMany(c => c.listaAlumnos).ToList();
            return todosLosAlumnos.OrderByDescending(a => a.nombreAlumno).ToList();
        }
    }
}
