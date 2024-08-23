using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Practica2
{
    internal class Ejercicio8
    {
        static void Main (string[] args)
        {
            double numero;
            int pot;
            int op;
            do
            {
                Console.WriteLine("Ingrese un numero:");
                numero = double.Parse(Console.ReadLine());
                Console.WriteLine("Elija una opcion: ");
                Console.WriteLine("1) Valor Absoluto");
                Console.WriteLine("2) Potencia");
                Console.WriteLine("3) Raiz Cuadrada");
                Console.WriteLine("4) Seno");
                Console.WriteLine("5) Coseno");
                Console.WriteLine("6) Redondeo");
                Console.WriteLine("7) Trunco");
                Console.WriteLine("0) Salir");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Console.WriteLine("Valor Absoluto: " + Math.Abs(numero));
                }
                else if (op == 2)
                {
                    Console.WriteLine("Ingrese el valor de la potencia: ");
                    pot = int.Parse(Console.ReadLine());
                    Console.WriteLine("Potencia de " + numero + "^" + pot + ": " + Math.Pow(numero, pot));
                }
                else if (op == 3)
                {
                    Console.WriteLine("Raiz Cuadrada: " + Math.Sqrt(numero));
                }
                else if (op == 4)
                {
                    Console.WriteLine("Seno: " + Math.Sin(numero));
                }
                else if (op == 5)
                {
                    Console.WriteLine("Coseno: " + Math.Cos(numero));
                }
                else if (op == 6)
                {
                    Console.WriteLine("Redondeo: " + Math.Round(numero));
                } 
                else if(op == 7)
                {
                    Console.WriteLine("Trunco: " + Math.Truncate(numero));
                }
            }while(op != 0);
        }
    }
}
