using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//romedio extendido 
namespace ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal sumaNotas = 0M;
            decimal promedio = 0M;

            Console.WriteLine("ingrese la nota 1");
            sumaNotas = (sumaNotas+ decimal.Parse(Console.ReadLine()));

            Console.WriteLine("ingrese la nota 2");
            sumaNotas = (sumaNotas + decimal.Parse(Console.ReadLine()));

            Console.WriteLine("ingrese la nota 3");
            sumaNotas = (sumaNotas + decimal.Parse(Console.ReadLine()));

            Console.WriteLine("ingrese la nota 4");
            sumaNotas = (sumaNotas + decimal.Parse(Console.ReadLine()));

            Console.WriteLine("ingrese la nota 5");
            sumaNotas = (sumaNotas + decimal.Parse(Console.ReadLine()));

            promedio = (sumaNotas / 5M);
            Console.WriteLine($"El promedio de las notas es {promedio} ");

        }
    }
}
