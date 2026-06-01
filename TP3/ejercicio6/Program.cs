using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//crear un programa que solicite 12  numeros enterosal finalizar el ingreso delos caracteres luego informar cuantos esran pares y cuantoeran impares

namespace ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero =  0;
            int pares = 0;
            int mpares = 0;
            Console.WriteLine("Ingresar 12 numeros enteros ");
            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine($"Ingrar el Nª{i} ");
                numero = int.Parse( Console.ReadLine() );

                if (numero % 2 == 0)
                {
                    pares++;
                }
                else
                { 
                   mpares++;
                }
            }
            Console.WriteLine($"la cantidad de numeros pares ingresados:{pares} y los numeros  impares ingresados son {mpares} ");


        }
    }
}
