using System;

namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal cantidadPasajes = 0M;
            decimal precioPasaje = 0M;
            decimal precioFinal = 0M;
            decimal precioFinalDescuent = 0M;

            Console.WriteLine("Ingrese la cantidad de pasajes que compro");
            cantidadPasajes = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el precio unitario de cada pasaje");
            precioPasaje = decimal.Parse(Console.ReadLine());

            precioFinal = cantidadPasajes * precioPasaje;

            if (cantidadPasajes > 3)
            {
                if (precioFinal >= 500000M)
                {
                    Console.WriteLine("ENTRO AL 15%");
                    precioFinalDescuent = precioFinal - (precioFinal * 0.15M);
                    Console.WriteLine($"El precio final con el descuentos es{precioFinalDescuent}");

                }
                else
                {
                    if (precioFinal >= 250000M & precioFinal < 500000M)
                    {
                        Console.WriteLine("ENTRO AL 11%");
                        precioFinalDescuent = precioFinal - (precioFinal * 0.11M);
                        Console.WriteLine($"El precio final con el descuentos es{precioFinalDescuent}");

                    }
                    else
                    {
                        Console.WriteLine("no tiene descunto");
                    }
                }
            }
            else
            {
                Console.WriteLine("no tiene descunto");
            }


        }
    }
}
