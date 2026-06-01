using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//escribe un programa que muestre los numeros del 1 al 100, debe mostrar por pantalla solo aquellos numeros quesean pares y al mismo tiempo sean multiplo de 7.
namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Los numeros pares y multiplos de 7 del 1 al 100 son:");
            for (int i = 0; i < 101; i++ )
            {
                if (i % 2 == 0 && i % 7 == 0)
                { 
                    Console.WriteLine($"{i}");

                }   
                   
            }
        }
    }
}
