using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//programa que solicite una cantidad de horas y calcular los minutos y segundos de esas horas
namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                decimal cantidadHoras = 0M;
                decimal cantidadMinutos = 0M;
                decimal cantidadSegundos = 0M;

                Console.WriteLine("Ingrese la cantidad de horas");
                cantidadHoras = decimal.Parse(Console.ReadLine());
                cantidadMinutos = cantidadHoras * 60M;
                cantidadSegundos = cantidadMinutos * 60M;
                Console.WriteLine($"La cantidad de minutos y segundos que hay en {cantidadHoras}Hs son {cantidadMinutos}m y {cantidadSegundos}s ");




            }
        }
    }
}
