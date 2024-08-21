using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ejercicio4
    {
        static void Main (string[] args)
        {
            string numero;
            Console.WriteLine("Ingrese un numero de 3 digitos: ");
            numero = Console.ReadLine();
            char[] digitos = numero.ToCharArray();
            Console.WriteLine("Numero ingresado: " + numero);
            Array.Reverse(digitos);
            Console.Write("Numero invertido: " );
            for (int i = 0; i < digitos.Length; i++)
            {
                Console.Write(digitos[i]);
            }
            Console.ReadLine();
        }
    }
}
