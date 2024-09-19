using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Practica4
{
    internal class Ejercicio4
    {
        static void Main(string[] args)
        {
            char op;
            double deposito, retiro, saldo = 0;
            do
            {
                Console.WriteLine("Seleccione una opcion:");
                Console.WriteLine("A) Deposito");
                Console.WriteLine("B) Retiro");
                Console.WriteLine("C) Finalizar");
                op = char.Parse(Console.ReadLine());
                if(op == 'a')
                {
                    Console.WriteLine("Ingrese el monto a depositar:");
                    deposito = Convert.ToDouble(Console.ReadLine());
                    saldo += deposito;
                }
                if(op == 'b')
                {
                    Console.WriteLine("Ingrese el monto a retirar:");
                    retiro = Convert.ToDouble(Console.ReadLine());
                    saldo -= retiro;
                }
            } while (op != 'c');
            Console.WriteLine("Saldo Final: " + saldo);
            Console.ReadLine();
        }
    }
}
