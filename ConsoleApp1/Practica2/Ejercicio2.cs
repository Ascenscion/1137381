using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Practica2
{
    internal class Ejercicio2
    {
        static void Main(string[] args)
        {
            int anio;
            Console.WriteLine("Ingrese un anio: ");
            anio = int.Parse(Console.ReadLine());
            if (anio <= 0)
            {
                Console.WriteLine("Anio invalido.");
            }
            else if(anio % 4 != 0) {
                Console.WriteLine("Anio no es bisiestro.");
            }
            else
            {
                if (anio % 4 == 0)
                {
                    if (anio % 100 == 0 && anio % 400 == 0)
                    {
                        Console.WriteLine("Anio es bisiestro");
                    }
                    else if (anio % 100 == 0)
                    {
                        Console.WriteLine("anio no es bisiestro");
                    }
                    else
                    {
                        Console.WriteLine("Anio es bisiestro.");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
