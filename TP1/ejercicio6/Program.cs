using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//calculo de velocidad
namespace ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal distancia = 0M;
            decimal tiempoHs = 0M;
            decimal velocidad = 0M;

            Console.WriteLine("Ingrese la distancia en km");
            distancia = decimal.Parse(Console.ReadLine());
          
            Console.WriteLine("Ingrese la cantidad de tiempo en horas que le tomo el rrecorrio");
            tiempoHs = decimal.Parse(Console.ReadLine());

            velocidad = ( distancia / tiempoHs);
            Console.WriteLine($"La velocidad promedio es de {velocidad}km/h");
        }
    }
}
