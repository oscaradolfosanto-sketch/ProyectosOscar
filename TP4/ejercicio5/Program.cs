using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//cree un programa que genere un numero aleatorio enntre 1 y 50. El usuario debe adivinarlo  pero ahora: con un pistas de frio, tibio, caliente
namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int NumeroAleatorio = random.Next(1, 51);
            int contaror = 1;
            int NumeroUsuario = 0;
            int distancia = 0;
            Console.WriteLine("Bienvenido al juego de adivinar el numero aleatorio entre 1 y 50 ");
            while (contaror <= 5)
            {
                Console.WriteLine("Ingrese un numero entre 1 y 50");
                Console.WriteLine("Solo tiene 5 intentos ");
                NumeroUsuario = int.Parse(Console.ReadLine());

                distancia = Math.Abs(NumeroAleatorio - NumeroUsuario);
                switch (distancia)
                {
                    case 0:
                        Console.WriteLine("Felicidades adivinaste el numero");
                        contaror = 6;
                        break;
                    case 1:
                        Console.WriteLine("MUY Caliente");
                        break;
                    case 2:
                    case 3:
                    case 4:
                        Console.WriteLine("Caliente");
                        break;
                    case 5:
                    case 6:
                    case 7:
                        Console.WriteLine("Tibio");
                        break;
                    case 8:
                    case 9:
                    case 10:
                        Console.WriteLine("Frio");
                        break;
                    default:
                        Console.WriteLine("Muy Frio");
                        break;
                }
                contaror++;
            }
        }
    }
} 
