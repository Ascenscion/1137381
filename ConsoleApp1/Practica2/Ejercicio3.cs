using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Practica2
{
    internal class Ejercicio3
    {
        static void Main (string[] args)
        {
            int op = 0;
            double basee, altura, radio;

            do
            {
                Console.WriteLine("Calcular Areas:");
                Console.WriteLine("1) Rectangulo");
                Console.WriteLine("2) Circulo");
                Console.WriteLine("3) Triangulo");
                Console.WriteLine("Que desea calcular");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Console.WriteLine("Ingrese la base del rectangulo: ");
                    basee = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del rectangulo: ");
                    altura = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area: " + (basee * altura));
                }
                else if (op == 2)
                {
                    Console.WriteLine("Ingrese el radio del circulo: ");
                    radio = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area: " + (3.1416 * (radio * radio)));
                }
                else if (op == 3)
                {
                    Console.WriteLine("Ingrese la base del triangulo: ");
                    basee = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del triangulo: ");
                    altura = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area: " + ((basee * altura) / 2));
                }
            } while (op == 1 || op == 2 || op == 3);
        }
    }
}
