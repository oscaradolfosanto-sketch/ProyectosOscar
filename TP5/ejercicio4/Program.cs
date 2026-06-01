using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// escriba un programa que recorra los numeros de 100 al 0, pero con un descremento de 5 en 5, ademas el programa no debe mostrar el los multiplos de 3.
namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i > 0; i = i - 5)
            {
                if (i % 3 != 0)
                {
                    Console.WriteLine($"{i}");
                }

            }
        }
    }
}
