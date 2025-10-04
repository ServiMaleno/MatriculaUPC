using MatriculaUPC.Datos;
using MatriculaUPC.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaUPC.Negocio
{
    public class nAlumno
    {
        private dAlumno datosAlumno = new dAlumno();

        public bool AgregarAlumno(int codigoCursoSeleccionado, Alumno alumno)
        {
            List<Alumno> alumnos = datosAlumno.ListarAlumnos(codigoCursoSeleccionado);
            if(alumnos.Any(a=> a.codigoAlumno == alumno.codigoAlumno))
            {
                return false;
            }

            datosAlumno.AgregarAlumno(codigoCursoSeleccionado, alumno);
            return true;
        }

        public List<Alumno> ListarAlumnos(int codigoCursoSeleccionado)
        {
            return datosAlumno.ListarAlumnos(codigoCursoSeleccionado);
        }

        //Reportes del lado del Negocio
        public List<Alumno> OrdenarTodosLosAlumnosPorNombreAsc()
        {
            return datosAlumno.OrdenarTodosLosAlumnosPorNombreAsc();
        }

        public List<Alumno> OrdenarTodosLosAlumnosPorNombreDesc()
        {
            return datosAlumno.OrdenarTodosLosAlumnosPorNombreDesc();
        }
    }
}
