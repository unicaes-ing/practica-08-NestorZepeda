using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Ejercicio1
    {
        public struct Estudiante
        {
            public string carnet, nombre, carrera;
            private decimal cum;

            public void setCum(decimal cum)
            {
                if (cum > 0 && cum <= 10)
                {
                    this.cum = cum;
                }

            }

            public decimal getCum()
            {
                return cum;
            }
        }
        public static void Ejercicio_1()
        {
            Estudiante est = new Estudiante();
            Console.WriteLine("Ingrese datos del estudiante");
            Console.Write("Estudiante: ");
            est.nombre = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Carnet: ");
            est.carnet = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Carrera: ");
            est.carrera = Console.ReadLine();
            Console.WriteLine();
            Console.Write("CUM:");
            est.setCum(Convert.ToDecimal(Console.ReadLine()));
            Console.Clear();
            Console.WriteLine("Nombre del Estudiante: " + est.nombre);
            Console.WriteLine();
            Console.WriteLine("Carnet del Estudiante: " + est.carnet);
            Console.WriteLine();
            Console.WriteLine("Carrera del Estudiante: " + est.carrera);
            Console.WriteLine();
            Console.WriteLine("CUM del Estudiante: " + est.getCum());
            Console.ReadKey();
        }



    }
}
