using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//cree el programa segun el diagrama
namespace ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limite = 0;
            Console.WriteLine("Ingrese el limite ");
            limite = int.Parse(Console.ReadLine());
            int suma = 0;
            int numero = 0;
            while (suma < limite)
            {
                Console.WriteLine("Ingrese un numero para sumar");
                numero = int.Parse(Console.ReadLine());
                suma = suma + numero;
            }
            Console.WriteLine($"La suma de los numeros ingresados es: {suma}");

        }
    }
}
