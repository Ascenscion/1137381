using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Practica2
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        { 
            int edad;
            Console.WriteLine("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Usuario es mayor de edad.");
            }
            else if (edad <= 0)
            {
                Console.WriteLine("Valor invalido");
            }
            else
            {
                Console.WriteLine("Usuario es menor de edad.");
            }
            Console.ReadLine();
        }
    }
}
