using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//escribir un programa que solicite al usuario ingresar su edad y valide que este en el rango de 1 a 120 años, si la edad no es valida el programa continuara pidiendo la edad
namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;

            Console.WriteLine("ingrese su edad");
            edad = int.Parse(Console.ReadLine());

            while (edad > 121 || edad < 1)
            {
                Console.WriteLine("su edad no es valida");

                Console.WriteLine("ingrese una nueva edad valida");
                edad = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("su edad es valida");


        }
    }
}
