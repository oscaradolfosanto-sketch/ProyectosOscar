using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//desarrollar un programa que pida al usuario dos numeros enteros positivos, el programa  debe sumar todos los numeros de cada digit, la ejecucion termina cundo ingrese un 0 
namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int centenas = 0;
            int decenas = 0;
            int unidades = 0;
            int verificador = 0;
            int total = 0;
            int numero = 0;

            do
            {
                Console.WriteLine("ingre un numero de 3 sifras para sumar ");
                numero = int.Parse(Console.ReadLine());
                verificador = numero + 0;

                centenas = numero / 100;
                decenas = (numero / 10) % 10;
                unidades = numero % 10;

                total = centenas + decenas + unidades;
                Console.WriteLine($"La suma de las sifras del numero {numero} es {total}");
                Console.WriteLine("__________________________________________");

                Console.WriteLine(" ingrese 0 para salir");

                Console.WriteLine(" o");
            }
            while (verificador != 0);

           
             

            
        }
    }
}
