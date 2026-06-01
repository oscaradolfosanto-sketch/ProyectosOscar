using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//erimetro de un circulo    
namespace ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal radio = 0M;
            decimal perimetro = 0M;
            Console.WriteLine("Ingrese el radio del circulo");
            radio = decimal.Parse(Console.ReadLine());
            perimetro = (2M * 3.14M * radio);
            Console.WriteLine($"El perimetro del circulo es {perimetro} ");


        }
    }
}
