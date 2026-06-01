using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Escriba un programa que solicite al usuario un numero y calcule la suma de de todos los numeros desde 1 hasta el numero. 
namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int suma = 0;
            int i = 1;
            while(i <= numero )
            {
                suma = suma + i;
                Console.WriteLine($"{i}");
                

                i++;
            }  
            Console.WriteLine($"La suma de los numeros desde 1 hasta {numero} es: {suma}");
        }
    }
}
