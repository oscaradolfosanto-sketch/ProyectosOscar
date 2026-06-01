using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//escribir un programa que calcule el cuadradro de los 9 primeros numeros
namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado = 0;
            for (int numero = 1; numero < 10; numero++)
            {
                resultado = numero * numero;
                Console.WriteLine($"{numero} elevado al cuadrado es {resultado}");
            }

        }
    }
}
