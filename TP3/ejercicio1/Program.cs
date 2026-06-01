using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//crea un programa quepermita al usuario elegir mediante unmenu un numero del 1 al 4 que conversion desea realizar
namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            decimal numero;

            decimal centimetros = 0;
            decimal pulgadas = 0;

            decimal kilometros = 0;
            decimal millas = 0;

           decimal kilogramos = 0;
           decimal libras = 0;

            decimal celsius = 0;
            decimal fahrenheit = 0;

            Console.WriteLine("Elija mediante l numero cual conversion desea realizar");
            Console.WriteLine("1.Centimetros a Pulgadas");
            Console.WriteLine("2.kilometros a Millas");
            Console.WriteLine("3.Kilogramos a Libras");
            Console.WriteLine("4.Celsius a  Fahrenheit ");
            numero = decimal.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Ingrese la cantidad de centimetros que quiere convertir a pulgadas");
                    centimetros = decimal.Parse(Console.ReadLine());

                    pulgadas = centimetros / 2.54M;
                    Console.WriteLine($"{centimetros} Centimetros = {pulgadas} Pulgadas");
                    break;

                case 2:
                    Console.WriteLine("Ingrese la cantidad de Kilometros que quiere convertir a Millas ");
                    kilometros = decimal.Parse(Console.ReadLine());

                    millas = kilometros * 0.621371M;
                    Console.WriteLine($"{kilometros} Kilometros = {millas} Millas");
                    break;

                case 3:
                    Console.WriteLine("Ingrese la cantidad de Kilogramos que quiere convertir a Libras ");
                    kilogramos = decimal.Parse(Console.ReadLine());

                    libras = kilogramos * 2.2046M;
                    Console.WriteLine($"{kilogramos} Kilogramos = {libras} Libras");
                    break;

                case 4:
                    Console.WriteLine("Ingrese la cantidad de Celsius que quiere convertir a Fahreheit ");
                    celsius = decimal.Parse(Console.ReadLine());

                    fahrenheit = (celsius * 1.8M) + 32;
                    Console.WriteLine($"{celsius} Celius = {fahrenheit} Fahrenheit");
                    break;

                default:
                    Console.WriteLine("El codigo no es valido ");
                    break;
            }


        }
    }
}
