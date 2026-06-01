using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//calculo de iva 
namespace ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal precioSinIva = 0M;
            decimal precioConIva = 0M;

            Console.WriteLine("Ingrese el precio sin iva del producto");
            precioSinIva = decimal.Parse(Console.ReadLine());

            precioConIva = (precioSinIva + (precioSinIva * 0.21M));
            Console.WriteLine($"El precio de producto con el IVA es de {precioConIva}");

        }
    }
}
