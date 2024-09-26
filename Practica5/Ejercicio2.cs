using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    internal class Ejercicio2
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Ingrese su nombre: ");
            name = Console.ReadLine();
            int longitud = name.Length;
            Console.WriteLine("La longitud de la cadena es de: " +  longitud);
            Console.WriteLine("Que character desea buscar? ");
            char letra = char.Parse(Console.ReadLine());
            string letraCad = letra.ToString();
            if (name.Contains(letra))
            {
                Console.WriteLine(name.Replace(letra, char.ToUpper(letra)));
                Console.WriteLine(name.Replace(letra, char.ToLower(letra)));
                Console.WriteLine(name.Replace(letraCad, string.Empty));
                Console.WriteLine("Ingrese dos numeros entre 0 y " + (longitud-2));
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                string sub = name.Substring(n1, n2);
                Console.WriteLine(sub);
                char[] charArray = sub.ToCharArray();
                Array.Reverse(charArray);
                Console.WriteLine(charArray);
            } else
            {
                Console.WriteLine("No se encontro el character dentro de la cadena");
            }
            Console.ReadLine();
        }

    }
}
