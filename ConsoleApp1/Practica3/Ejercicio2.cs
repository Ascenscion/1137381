using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Practica3
{
    internal class Ejercicio2
    {
        static void Main(string[] args)
        {
            int n1, n2, op;
            do
            {
                Console.WriteLine("Ingrese el primer numero: ");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero: ");
                n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("1) suma");
                Console.WriteLine("2) resta");
                Console.WriteLine("3) multiplicacion");
                Console.WriteLine("4) division");
                Console.WriteLine("Elija una opcion:");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("La suma del primer numero con el segundo numero es: " + (n1 + n2));
                        break;
                    case 2:
                        Console.WriteLine("La resta del primer numero menos el segundo numero es: " + (n1 - n2));
                        break;
                    case 3:
                        Console.WriteLine("La multiplicacion del primer numero por el segundo numero es: " + (n1 * n2));
                        break;
                    case 4:
                        Console.WriteLine("La division del primer numero entre el segundo numero es de: " + (n1 / n2));
                        break;
                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }
            }while (true);

        }
    }
}
