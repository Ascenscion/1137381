using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Practica4
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {
            char op = 's';
            int edad;
            LinkedList<int> list = new LinkedList<int>();
            do
            {
                Console.WriteLine("Ingrese una edad");
                edad = int.Parse(Console.ReadLine());
                if (edad > 0)
                {
                    list.AddLast(edad);
                }
                Console.WriteLine("Desea ingresar otra edad ?");
                op = char.Parse(Console.ReadLine());
            } while (op == 's');
            Console.WriteLine("La edad maxima ingresada es: " + list.Max());
            Console.WriteLine("La edad minima ingresada es: " + list.Min());
            Console.ReadLine();
        }

        static int ValorMaximo(LinkedList<int> list)
        {
            int max = 0;
            foreach (int numero in list)
            {
                if(numero > max)
                {
                    max = numero;
                }
            }
            return max;
        }
    }
}
