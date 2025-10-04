using MatriculaUPC.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaUPC.Datos
{
    public class dCurso
    {
        private static List<Curso> cursos = new List<Curso>();
        public void CrearCurso(Curso curso)
        {
            cursos.Add(curso);
        }
        public List<Curso> ListarCursos()
        {
            return cursos;
        }
    }
}
