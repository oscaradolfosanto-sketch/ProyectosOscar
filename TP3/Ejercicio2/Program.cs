using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//programa que solicite una letra que represente el tipo de vehiculo:M(Motocicleta), A(Auto), C(Camion), O(Omnibus)
namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Letra;

            Console.WriteLine("Para saber l costo del peaje debe ingrsar la letra del vehiculo del que quiere saber.");
            Console.WriteLine("[M](Motocicleta)");
            Console.WriteLine("[A](Auto)");
            Console.WriteLine("[C](Camion)");
            Console.WriteLine("[O](Omnibus)");
            Letra = Console.ReadLine();

            switch (Letra.ToLower())
            {
                case "m":
                    Console.WriteLine("el costo es de 5.000");
                    break;
                case "a":
                    Console.WriteLine("el costo es de 10.000");
                    break;
                case "c":
                    Console.WriteLine("el costo es de 7.000");
                    break ;
                case "o":
                    Console.WriteLine("el costo es de 2.000");
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }




        }
    }
}
