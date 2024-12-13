using System;
using System.Collections.Generic;

namespace Colegio
{
    public class Curso
    {
        public string Nombre { get; set; }
        private List<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();

        public Curso(string nombre)
        {
            Nombre = nombre;
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            Estudiantes.Add(estudiante);
        }

        public double CalcularPromedioGeneral()
        {
            if (Estudiantes.Count == 0) return 0;
            double sumaPromedios = 0;
            foreach (var estudiante in Estudiantes)
            {
                sumaPromedios += estudiante.CalcularPromedio();
            }
            return sumaPromedios / Estudiantes.Count;
        }

        public int CantidadAprobados(double notaMinima = 60)
        {
            int aprobados = 0;
            foreach (var estudiante in Estudiantes)
            {
                if (estudiante.CalcularPromedio() >= notaMinima)
                    aprobados++;
            }
            return aprobados;
        }

        public int CantidadReprobados(double notaMinima = 60)
        {
            return Estudiantes.Count - CantidadAprobados(notaMinima);
        }
    }
}

