using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ejercicio3
    {
        static void Main(string[] args)
        {
            double horas, extras;
            Console.WriteLine("Ingrese las horas trabajadas en la semana: ");
            horas = Convert.ToDouble(Console.ReadLine());
            if (horas <= 40)
            {
                Console.WriteLine("Salario: " + (horas * 50));
            }
            else
            {
                extras = horas - 40;
                Console.WriteLine("Salario: " + ((40 * 50) + (extras * 100)));
            }
            Console.ReadLine();
        }
    }
}
