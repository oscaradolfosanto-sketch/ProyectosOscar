using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ecribe un programa que solicite 15 caracteres y identificar vocales y las no vocales
namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caracter;
            int vocales  = 0;
            int novocales = 0;

            for (int i = 1; i < 16; i++)
            {
                Console.WriteLine($"ingrse el caracter N{i}");
                caracter = Console.ReadLine();

                switch (caracter.ToLower())
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u":
                        vocales++;
                        break;
                 

                    default:
                        novocales++;
                        break;
                }

            }
            Console.WriteLine($"la cantidad de vocales son {vocales} y la cantidad de novocales son {novocales}");
        }
    }
}
