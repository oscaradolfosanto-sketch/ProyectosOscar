using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Realizar un programa que permita introducir un valor (X) y determinar si es par o impar.
namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.WriteLine("Ingrese el numero ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero es par ");

            }
            else
            {
                Console.WriteLine("El numero es impar");

            }
            Console.ReadKey();
        }
    }
}
