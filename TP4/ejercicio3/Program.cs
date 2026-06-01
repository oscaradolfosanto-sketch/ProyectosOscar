using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//cree un programa que solicite al ususario dos numeros (inicio y fin) y muestre todos los numeros primos  desde ese rango. validar que el numero de inicio sea menor  al del fin 
namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inicio = 0;
            int final = 0;
           
            
            

            Console.WriteLine("Ingrese el numero de inicio");
            inicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero final");
            final = int.Parse(Console.ReadLine());

            if (inicio > final)
            {
                Console.WriteLine("ERROR el numero de inicio es mayor que el el numero final ");
            }
            else
            {
                do
                {
                    bool NumeroPrimo = true;
                    int divisor = 2;
                    while (divisor * divisor <= inicio)
                    {
                        if (inicio % divisor == 0)
                        {
                            NumeroPrimo = false;
                            break;

                        }
                        divisor++;
                    }
                    if (NumeroPrimo == true)
                    {
                        Console.WriteLine($"{inicio}");
                    }
                    inicio++;

                } while (inicio <= final);
            }
            

        }
    }
}
