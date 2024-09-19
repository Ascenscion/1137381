using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tarea2
{
    internal class clase1
    {
        static void Main(string[] args)
        {
            int m = 0;
            int aux;
            int[] num = { 1, 2, 8, 24, 90 };
            aux = num[0];
            while (m < num.Length)
            {
                if (num[m] > aux)
                {
                    aux = num[m];
                }
                m++;
            }
            Console.WriteLine("numero mayor: " + aux);
            Console.ReadLine();
        }
    }
}
