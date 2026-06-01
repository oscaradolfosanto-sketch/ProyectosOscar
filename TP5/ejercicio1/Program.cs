using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Realice un programa que muestre todos los numeros pares entre 1 y 50.
namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}");
                }
                
            }

        }
    }
}
