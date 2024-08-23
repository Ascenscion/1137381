using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Practica2
{
    internal class Ejercicio4
    {
        static void Main(string[] args)
        {
            double calif = 0;
            double promedio;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese la calificacion " + (i + 1) + ":");
                calif += double.Parse(Console.ReadLine());
            }
            promedio = calif / 5;
            if (promedio >= 60)
            {
                Console.WriteLine("Alumno aprobado.");
            } else
            {
                Console.WriteLine("Alumno reprobado.");
            }
            Console.ReadLine();
        }
    }
}
