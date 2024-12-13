using System;
using System.Collections.Generic;

namespace Colegio
{
    public class SistemaAcademico
    {
        private List<Curso> Cursos { get; set; } = new List<Curso>();

        public void AgregarCurso(Curso curso)
        {
            Cursos.Add(curso);
        }

        public Curso BuscarCurso(string nombreCurso)
        {
            return Cursos.Find(curso => curso.Nombre.Equals(nombreCurso, StringComparison.OrdinalIgnoreCase));
        }

        public void EstadisticasGenerales()
        {
            int totalEstudiantes = 0;
            int totalAprobados = 0;
            int totalReprobados = 0;

            foreach (var curso in Cursos)
            {
                totalEstudiantes += curso.CantidadAprobados() + curso.CantidadReprobados();
                totalAprobados += curso.CantidadAprobados();
                totalReprobados += curso.CantidadReprobados();
            }


        }
    }
}

