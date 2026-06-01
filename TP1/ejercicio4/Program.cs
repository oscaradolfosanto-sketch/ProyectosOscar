using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Calular el presio final de un articulo con un descuentodel 15%
namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal precioArticulo = 0M;
            decimal precioFinal = 0M;
            Console.WriteLine("Ingrese el precio del articulo");
            precioArticulo = decimal.Parse(Console.ReadLine());
            precioFinal = precioArticulo - (precioArticulo * 0.15M);
            Console.WriteLine($"El precio final del producto es {precioFinal} ");



        }
    }
}
