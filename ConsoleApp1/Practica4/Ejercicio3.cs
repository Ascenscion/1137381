using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Practica4
{
    internal class Ejercicio3
    {
        static void Main(string[] args)
        {
            int n1, n2;
            int suma = 0;
            bool esBueno = true;
            List<int> list = new List<int>();
            do 
            {   
                esBueno = true;
                Console.WriteLine("Ingrese dos numeros: ");
                n1 = int.Parse(Console.ReadLine());
                n2 = int.Parse(Console.ReadLine());
                if (n1 > n2)
                {
                    esBueno = false;
                    Console.WriteLine("Numeros en orden equivocado, vuelva a ingresarlos.");
                } else
                {
                    for(int i = n1; i <= n2; i++)
                    {
                        if(i%2 == 0)
                        {
                            suma += i;
                            list.Add(i);
                        }
                    }
                    Console.WriteLine("Los numeros pares entre los rangos " + n1 + " y " + n2 + "son: ");
                    foreach(int i in list)
                        Console.WriteLine(i);
                    Console.WriteLine("La suma de todos los numeros pares entre " + n1 + " y " + n2 + " es: " + suma);

                }

            } while (!esBueno);
            Console.ReadLine();
        }
    }
}
