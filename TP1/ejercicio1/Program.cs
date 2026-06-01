using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal alto = 0;
            decimal base1 = 0;
            decimal area = 0;
            Console.WriteLine("Ingrese el alto del triangulo");
            alto = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la base del triangulo");
            base1 = decimal.Parse(Console.ReadLine());
            area = (alto * base1) / 2;
            Console.WriteLine($" El area del triangulo es de {area}");


        }
    }
}
