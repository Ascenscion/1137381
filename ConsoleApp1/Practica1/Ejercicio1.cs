using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {
            double uno, dos, suma;
            string Uno, Dos;
            Console.WriteLine("Introduce un numero real:");
            Uno = Console.ReadLine();
            uno = double.Parse(Uno);
            Console.WriteLine("Introduce otro numero real:");
            Dos = Console.ReadLine();
            dos = double.Parse(Dos);
            suma = uno + dos;
            Console.WriteLine("Resultado: " + suma);
            Console.ReadLine();
        }
    }
}
