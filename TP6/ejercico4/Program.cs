using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Genere  una funcion que calcule el IVA de un producto, La funcion reside dos parametros uno el precio del producto y el segundo y el segundo parametro la unidad el tipo de iva. 
namespace ejercico4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PrecioProducto;
            int TipoIVA;
            decimal resultado;
            Console.WriteLine("Ingrese el precio del producto: ");
            PrecioProducto = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tipo de IVA (ingrese 1 o 2 o 3) ");
            Console.WriteLine("1 - 27%");
            Console.WriteLine("2 - 21%");
            Console.WriteLine("3 - 10.5%");
            TipoIVA = int.Parse(Console.ReadLine());

            resultado = CalcularIVA(PrecioProducto, TipoIVA);
            Console.WriteLine($"El IVA del producto es: {resultado}" );
        }
        public static decimal CalcularIVA(int PrecioProducto, int TipoIVA)
        {
            switch (TipoIVA)
            {
                case 1:
                    return PrecioProducto * 0.27m;
                case 2:
                    return PrecioProducto * 0.21m;
                case 3:
                    return PrecioProducto * 0.105m;
                default:
                    return 0m;
            }
        }
    }
}
