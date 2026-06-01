using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal dogui = 38.000M;
            decimal Tiernitos = 31.000M;
            decimal dogpro = 46.000M;

            decimal suma = 0M;

            int numeroCodigo = 0;
            int codigo1 = 1;
            int codigo2 = 2;
            int codigo3 = 3;
            int cantidad = 0;

            Console.WriteLine("Ingrese el codigo de producto");
            numeroCodigo = int.Parse(Console.ReadLine());

            if (numeroCodigo == codigo1) 
            {
                Console.WriteLine("Ingrese lacantidad de bolsas marca Dogui x 21kg ");
                cantidad = int.Parse(Console.ReadLine());

                if (cantidad == 1 )
                {
                    Console.WriteLine("El costo de una bolsa es de 38.000 pesos");
                    
                }
                else
                {
                    if (cantidad == 2)
                    {
                        suma = dogui * 2;
                        Console.WriteLine($"El costo de dos bolsas Dogui son:{suma}");
                    }
                    else
                    {
                        if (cantidad == 3)
                        {
                            suma = dogui * 3;
                            Console.WriteLine($"El costo de tres bolsas Dogui son:{suma}");
                            
                        }
                        else
                        {
                            if (cantidad == 4)
                            {
                                suma = dogui * 4;
                                Console.WriteLine($"El costo de cuatro bolsas Dogui son:{suma} ");
                                
                            }
                        }
                    }
                }
                if (cantidad >= 5 & cantidad <= 10)
                {
                    dogui = 36.000M;
                    suma = cantidad * dogui;
                    Console.WriteLine($"El costo de {cantidad} bolsas Dogui son {suma}");
                }
                else
                {
                    if ( cantidad >= 11)
                    {
                        dogui = 34.000M;
                        suma = cantidad * dogui;
                        Console.WriteLine($"El costo de {cantidad} bolsas Dogui son {suma}");
                    }
                }
            }
            else
            {
                if (numeroCodigo == codigo2)
                {
                    Console.WriteLine("Ingrese lacantidad de bolsas marca Tiernitos ");
                    cantidad = int.Parse(Console.ReadLine());

                    if (cantidad == 1)
                    {
                        Console.WriteLine("El costo de una bolsa es de 31.000 pesos");

                    }
                    else
                    {
                        if (cantidad == 2)
                        {
                            suma = Tiernitos * 2;
                            Console.WriteLine($"El costo de dos bolsas Tiernitos son:{suma}");
                        }
                        else
                        {
                            if (cantidad == 3)
                            {
                                suma = Tiernitos * 3;
                                Console.WriteLine($"El costo de tres bolsas Tiernitos son:{suma}");

                            }
                            else
                            {
                                if (cantidad == 4)
                                {
                                    suma = Tiernitos * 4;
                                    Console.WriteLine($"El costo de cuatro bolsas Tiernitos son:{suma} ");

                                }
                            }
                        }
                    }
                    if (cantidad >= 5 & cantidad <= 10)
                    {
                        Tiernitos = 29.000M;
                        suma = cantidad * Tiernitos;
                        Console.WriteLine($"El costo de {cantidad} bolsas Tiernitos son {suma}");
                    }
                    else
                    {
                        if (cantidad >= 11)
                        {
                            Tiernitos = 27.000M;
                            suma = cantidad * Tiernitos;
                            Console.WriteLine($"El costo de {cantidad} bolsas Tiernitos son {suma}");
                        }
                    }
                }
            }
            if (numeroCodigo == codigo3)
            {
                Console.WriteLine("Ingrese la cantidad de bolsas marca Dogpro ");
                cantidad = int.Parse(Console.ReadLine());

                if (cantidad == 1)
                {
                    Console.WriteLine("El costo de una bolsa es de 46.000 pesos");

                }
                else
                {
                    if (cantidad == 2)
                    {
                        suma = dogpro * 2;
                        Console.WriteLine($"El costo de dos bolsas dogpro son:{suma}");
                    }
                    else
                    {
                        if (cantidad == 3)
                        {
                            suma = dogpro * 3;
                            Console.WriteLine($"El costo de tres bolsas dogpro son:{suma}");

                        }
                        else
                        {
                            if (cantidad == 4)
                            {
                                suma = dogpro * 4;
                                Console.WriteLine($"El costo de cuatro bolsas dogpro son:{suma} ");

                            }
                        }
                    }
                }
                if (cantidad >= 5 & cantidad <= 10)
                {
                    dogpro = 44.000M;
                    suma = cantidad * dogpro;
                    Console.WriteLine($"El costo de {cantidad} bolsa de dogpro son {suma}");
                }
                else
                {
                    if (cantidad >= 11)
                    {
                        dogpro = 42.000M;
                        suma = cantidad * dogpro;
                        Console.WriteLine($"El costo de {cantidad} bolsas dogpro son {suma}");
                    }
                }
            }
        }


    }

}

