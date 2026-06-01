using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//escribe un programa que permita ingresar numeros hasta que el usuario ingrese 0. el programa debe mostrar cual es el numero mayor ingresado.
namespace ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int mayor = 0;
            Console.WriteLine("Programa que encuentra el numero mayor");
            do
            {
                Console.WriteLine("Ingrese un numero:");
                numero = int.Parse(Console.ReadLine());
                if (numero > mayor )
                {
                    mayor = numero + 0;
                }


            }
            while (numero != 0);
            Console.WriteLine($"El numero mayor ingresado es:{mayor}" );
        }
    }
}
