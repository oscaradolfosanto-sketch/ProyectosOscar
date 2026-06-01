using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Cree una funcion CalcularPotencia que reciba dos numeros enteros, base y exponente) y devuelva el resultado de elevar la base al exponente.
namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseNum = 0;
            int exponente = 0;

            Console.WriteLine("Ingrese la base: ");
            baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el exponente: ");
            exponente = int.Parse(Console.ReadLine());

            
            int resultado = CalcularPorsentaje(baseNum, exponente);
            Console.WriteLine($"El resultado de {baseNum} elevado a {exponente} es: {resultado}");
        }
        public static int CalcularPorsentaje(int baseNum, int exponente)
        { 
            
            int resultado = 1;
            for (int i = 0; i < exponente; i++)
            {
                resultado =baseNum * resultado;
            }
             return resultado;

        }
    }
}
