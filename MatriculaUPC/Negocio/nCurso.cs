using MatriculaUPC.Datos;
using MatriculaUPC.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaUPC.Negocio
{
    public class nCurso
    {
        private dCurso datosCurso = new dCurso();
        public bool CrearCurso(Curso curso)
        {
            if(datosCurso.ListarCursos().Any(c=>c.codigoCurso == curso.codigoCurso))
            {
                return false;
            }
           
            datosCurso.CrearCurso(curso);
            return true;
        }
        public List<Curso> ListarCursos()
        {
            return datosCurso.ListarCursos();
        }

        //Reportes para CURSOS

        // Reporte 1: Cursos con más alumnos (puede devolver más de uno si hay empate)
        public List<Curso> CursosConMasAlumnos()
        {
            List<Curso> cursos = datosCurso.ListarCursos();
            List<Curso> cursosConMasAlumnos = new List<Curso>();
            if(cursos == null || cursos.Count == 0)
            {
                return cursosConMasAlumnos;
            }

            int maximaCantidadAlumnos = cursos.Max(c => c.listaAlumnos.Count);
            cursosConMasAlumnos = cursos.Where(c => c.listaAlumnos.Count == maximaCantidadAlumnos).ToList();
            return cursosConMasAlumnos;
        }

        // Reporte 2: Buscar curso por código (devuelve lista vacía si no existe)
        public List<Curso> BuscarCursoPorCodigo(int codigoCursoBuscado)
        {
            List<Curso> cursos = datosCurso.ListarCursos();
            List<Curso> cursoPorCodigo = new List<Curso>();
            if (cursos == null || cursos.Count == 0)
            {
                return cursoPorCodigo;
            }
            cursoPorCodigo = cursos.Where(c => c.codigoCurso == codigoCursoBuscado).ToList();
            return cursoPorCodigo;
        }
    }
}
