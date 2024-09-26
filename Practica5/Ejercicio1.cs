using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {
            string cad;
            Console.WriteLine("Ingrese una cadena: ");
            cad = Console.ReadLine();
            Console.WriteLine(cad);
            string cadsinEspacio = cad.Replace(" ", string.Empty);
            Console.WriteLine(cadsinEspacio);
            char[] charArray = cadsinEspacio.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);
            Console.ReadLine();
        }
    }
}
