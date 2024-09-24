
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1Progra3
{
    class Estudiante
    {
        public string Nombre { get; set; }
        private int Edad { get; set; }
        public double Promedio { get; set; }

        public bool EsMayorDeEdad()
        {
            return Edad >= 18;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}, Promedio: {Promedio}");
        }

        public void SetEdad(int edad)
        {
            Edad = edad;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> estudiantes = new List<Estudiante>();

            Console.Write("Ingrese la cantidad de estudiantes que desea registrar: ");
            int cantidadEstudiantes = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                Estudiante estudiante = new Estudiante();

                Console.Write($"Ingrese el nombre del estudiante {i + 1}: ");
                estudiante.Nombre = Console.ReadLine();

                Console.Write($"Ingrese la edad del estudiante {i + 1}: ");
                estudiante.SetEdad(Convert.ToInt32(Console.ReadLine()));

                Console.Write($"Ingrese el promedio del estudiante {i + 1}: ");
                estudiante.Promedio = Convert.ToDouble(Console.ReadLine());

                estudiantes.Add(estudiante);
            }

            int contador = 0;
            while (contador < estudiantes.Count)
            {
                if (estudiantes[contador].Promedio > 70)
                {
                    estudiantes[contador].MostrarInfo();
                    if (estudiantes[contador].EsMayorDeEdad())
                    {
                        Console.WriteLine("Es mayor de edad.");
                    }
                    else
                    {
                        Console.WriteLine("No es mayor de edad.");
                    }
                }
                contador++;
                Console.ReadKey();
            }
        }
    }
}
