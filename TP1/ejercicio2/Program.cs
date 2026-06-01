using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal largo = 0;
            decimal ancho = 0;
            decimal alto = 0;
            decimal volumen = 0;

            Console.WriteLine("Ingrese el largo de la caja");
            largo = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el ancho de la caja");
            ancho = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el alto de la caja");
            alto = decimal.Parse(Console.ReadLine());
            volumen = (largo * ancho * alto);
            Console.WriteLine($"El volumen de la caja es {volumen}");
        }
    }
}
