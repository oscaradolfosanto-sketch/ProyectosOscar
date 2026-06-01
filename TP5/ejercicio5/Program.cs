using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// El programa debe permitir ingresar numeros enteros, hasta que el usuario ingrese 0, al finalizar, mostrar la cantidad de numero positivos ingresados 
namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int cantidadPositivos = 0;
            do
            {
                Console.WriteLine("ingrese  un numero");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                { 
                    cantidadPositivos++;

                }
            } while (numero != 0);
            Console.WriteLine($"cantidad de numeros positivos ingresados: {cantidadPositivos}");

        }
    }
}
