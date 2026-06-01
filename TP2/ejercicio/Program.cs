using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Ingrese un numero y determine si es positivo o negativousando una estructura condicional if-else y tambien resuelva el mismoproblema utilizando un operadorr ternario.
namespace ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.WriteLine("Ingrese un numero " );
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0 )
            {
                Console.WriteLine("El numero es positivo");
            }
            else
            {
                Console.WriteLine("El numero es negativo");   
            }
            Console.ReadKey();

        }
    }
}
