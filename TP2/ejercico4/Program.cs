using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//realizar un programa que permita ingresar a edad de una persona y determinar si es  niño (0 a 12 años) adolecente (13 a 17), adulto(18 a 64), adulto mayor (mas de 64). 
namespace ejercico4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;


            Console.WriteLine("Ingrese la edad de la persona");
            edad = int.Parse(Console.ReadLine());

            if (edad >= 0 & edad <= 12)
            {
                Console.WriteLine("La persona es un niño");
            }
            if (edad >= 13 & edad <= 17  )
            {
                Console.WriteLine("La persona es un adolecente");
            }
            if (edad >= 18 & edad <= 64)
            {
                Console.WriteLine("La persona es un adulto ");
            }
            if (edad > 64 )
            {
                Console.WriteLine("La persona es un adulto mayor  ");
            }
        }
    }
}
