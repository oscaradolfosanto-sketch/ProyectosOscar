using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Cree un un programa que tenga una funcion llamada convertir que reciba dos valores, el primero es el valor a convertir y el segundo la unidad a la que quiere convertir.

namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int unidad;
            decimal resultado;
            Console.WriteLine("Ingrese el valor a convertir:");
            valor = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la unidad a la que desea convertir:");
            Console.WriteLine("1. Kilómetros a millas");
            Console.WriteLine("2. Celsius a Fahrenheit");
            Console.WriteLine("3. Kilogramos a libras");
            unidad = int.Parse(Console.ReadLine());

            resultado = Convertir(valor, unidad);
            if (resultado != 0)
            {
                Console.WriteLine($"El resultado de la conversión es {resultado}");
            }
        }
        public static decimal Convertir(int valor, int unidad)
        {
            switch (unidad)
            {
                case 1:
                    return valor * 0.621371m;
                case 2:
                    return (valor * 1.8m) + 32;
                case 3:
                    return valor * 2.20462m;

                default:
                    Console.WriteLine("Unidad no válida");
                    return 0;
            }

        }
    }
}
