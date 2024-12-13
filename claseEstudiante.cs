using System;
using System.Collections.Generic;

namespace Colegio
{
    public class Estudiante
    {
        public string NombreCompleto { get; set; }
        public int Id { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        private List<double> Notas { get; set; } = new List<double>();

        public Estudiante(string nombreCompleto, int id, int edad, string genero)
        {
            NombreCompleto = nombreCompleto;
            Id = id;
            Edad = edad;
            Genero = genero;
        }

        public void AgregarNota(double nota)
        {
            if (nota >= 0 && nota <= 100)
                Notas.Add(nota);
            else
                Console.WriteLine("La nota debe estar entre 0 y 100.");
        }

        public double CalcularPromedio()
        {
            if (Notas.Count == 0) return 0;
            double suma = 0;
            foreach (var nota in Notas)
            {
                suma += nota;
            }
            return suma / Notas.Count;
        }

        public List<double> ObtenerCalificaciones()
        {
            return new List<double>(Notas);
        }
    }
}
