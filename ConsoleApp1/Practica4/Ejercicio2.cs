using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Practica4
{
    internal class Ejercicio2
    {
        static void Main(string[] args)
        {
            int n1, n2, max, min;
            Console.WriteLine("Ingrese dos numeros: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Los numeros primos ingresados entre los rangos " + n1 + " y " + n2 + " son: ");
            if(n1 < n2)
            {
                min = n1;
                max = n2;
            } else
            {
                min = n2;
                max = n1;
            }
            for (int i = min; i <= max; i++)
            {
                bool esPrimo = true;
                if (i == 1)
                {
                    esPrimo = false;
                }
                else
                {
                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            esPrimo = false;
                            break;
                        }
                    }
                }
                if (esPrimo)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
