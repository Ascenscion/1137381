using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tarea3
{
    internal class Ejercicio1
    {
        static void Main()
        {
            List<int> numeros = new List<int>();
            numeros.Add(10);
            numeros.Add(20);
            numeros.Add(30);
            Console.WriteLine("Elemento en la posicion 3: " + numeros[2]); // Problema 1 CORREGIDO

            for (int i = 0; i < numeros.Count; i++) // Problema 2 CORREGIDO
            {
                if(numeros[i] > 15)
                {
                    Console.WriteLine("Numero mayor a 15: " + numeros[i]);
                }

            }
            string listaComoTexto = string.Join(",", numeros.ToArray()); // Problema 3 CORREGIDO
            Console.WriteLine("Lista como texto: " + listaComoTexto);   
            Console.ReadLine();
        }
    }
}
