using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Practica2
{
    internal class Ejercicio6
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ingrese un numero:");
            numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("Numero es par.");
            } else
            {
                Console.WriteLine("Numero no es par");
            }
            Console.ReadLine();
        }
    }
}
