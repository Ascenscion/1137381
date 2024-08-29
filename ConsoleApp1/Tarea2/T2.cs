using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tarea2
{
    internal class T2
    {
        static void Main(string[] args)
        {
            int cal;
            do
            {
                Console.WriteLine("Ingrese una calificacion: ");
                cal = int.Parse(Console.ReadLine());
                switch (cal)
                {
                    case 10:
                        Console.WriteLine("Excelente");
                        break;
                    case 9:
                        Console.WriteLine("Muy bien");
                        break;
                    case 8:
                        Console.WriteLine("Bien");
                        break;
                    case 7:
                        Console.WriteLine("Regular");
                        break;
                    case 6:
                        Console.WriteLine("Suficiente");
                        break;
                    case 5:
                        Console.WriteLine("Insuficiente");
                        break;
                    case 4:
                        Console.WriteLine("Insuficiente");
                        break;
                    case 3:
                        Console.WriteLine("Insuficiente");
                        break;
                    case 2:
                        Console.WriteLine("Insuficiente");
                        break;
                    case 1:
                        Console.WriteLine("Insuficiente");
                        break;
                    default:
                        Console.WriteLine("Valor Invalido");
                        break;
                }
            } while (true);
        }
    }
}
