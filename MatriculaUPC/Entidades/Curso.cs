using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaUPC.Entidades
{
    public class Curso
    {
        public int codigoCurso { get; set; }
        public string nombreCurso { get; set; }
        public int creditosCurso { get; set; }
        public List<Alumno> listaAlumnos = new List<Alumno>();
    }
}
