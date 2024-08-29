using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Practica3
{
    internal class Ejercicio3
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case int n when num < 50:
                        Console.WriteLine("Numero menor a 50.");
                        break;
                    case int n when num > 50:
                        Console.WriteLine("Numero es mayor a 50");
                        break;
                    default:
                        Console.WriteLine("Numero es igual a 50");
                        break;
                }
            }while (true);
        }
    }
}
