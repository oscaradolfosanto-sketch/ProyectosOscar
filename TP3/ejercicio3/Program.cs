using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//escribe un programa que simule unacalculadora
namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            int resultado = 0;
            string operador;

            Console.WriteLine("Ingrese el simbolo de la operacion que quiere hacer (+,-,x,:)");
            operador = Console.ReadLine();

            Console.WriteLine("Ingrese los dos numeos que quiere operar");
            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());

            switch (operador)
            {
                case "+":
                     resultado = numero1 + numero2 ;
                    Console.WriteLine($"{numero1} + {numero2} = {resultado}");
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    Console.WriteLine($"{numero1} - {numero2} = {resultado}");
                    break;
                case "x":
                    resultado = numero1 * numero2;
                    Console.WriteLine($"{numero1} x {numero2} = {resultado}");
                    break;
                case ":":
                    if (numero2 == 0 || numero1 == 0)
                    {
                        Console.WriteLine("error");
                        Console.WriteLine("no se puede dividir");
                    }
                    else
                    {
                      resultado = numero1 / numero2;
                      Console.WriteLine($"{numero1} : {numero2} = {resultado}");
                        
                    
                    }
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }

        }
    }
}
