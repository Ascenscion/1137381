using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Practica2
{
    internal class Ejercicio7
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 >= num2 && num2 >= num3)
            {
                Console.WriteLine("El primer numero es mayor.");
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("El segundo numero es mayor.");
            }
            else if (num3 >= num1 && num3 >= num2)
            {
                Console.WriteLine("El tercer numero es mayor.");
            } else if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine("Todos tienen el mismo valor");
            }
            Console.ReadLine();
        }
    }
}
