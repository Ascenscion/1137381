using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ejercicio2
    {
        static void Main(string[] args)
        {
            string nombre, profesion, genero;
            int Edad;
            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su profesion: ");
            profesion = Console.ReadLine();
            Console.WriteLine("Ingrese su edad: ");
            Edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su genero:");
            genero = Console.ReadLine();
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Profesion: " + profesion);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Genero: " + genero);
            Console.ReadLine();
        }
    }
}
