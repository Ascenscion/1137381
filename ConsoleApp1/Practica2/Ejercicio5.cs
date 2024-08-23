using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Practica2
{
    internal class Ejercicio5
    {
        static void Main (string[] args)
        {
            int edad;
            char sexo;
            Console.WriteLine("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su sexo (m/f): ");
            sexo = char.Parse(Console.ReadLine());
            if(sexo == 'm')
            {
                if(edad >= 18 && edad <= 30)
                {
                    Console.WriteLine("La persona si es masculina entre 18 y 30 anios");
                } 
            } else
            {
                Console.WriteLine("Nada.");
            }
            Console.ReadLine();
        }
    }
}
