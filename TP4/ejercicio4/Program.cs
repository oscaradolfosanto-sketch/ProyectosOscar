using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//cree un programa para registrae productos en un inventario el ususario ingresa:nombre, precio, cantidad, el programa debe mostrar el valor total 
namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            string NombreProducto = "";
            int precio  = 0;
            int cantidad = 0;
            string valida = " ";

            int total = 0;
            do
            {
                Console.WriteLine("Ingrese el nombre del producto");
                    NombreProducto = Console.ReadLine();

                if (NombreProducto != "")
                {
                 
                    Console.WriteLine("Ingrese el precio del producto");
                    precio = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad del producto");
                    cantidad = int.Parse(Console.ReadLine());

                    
                    if (precio > 0 && cantidad >= 0)
                    {
                        total = precio * cantidad;
                        Console.WriteLine($"El precio total del producto {NombreProducto} es: {total}");
                        bool Validar = true;
                    }
                    else
                    {
                        Console.WriteLine("ERROR precio tiene que ser mayor a 0 y cantidad tienen que ser mayor o igual 0");

                    }
                    
                }
                else
                {
                        Console.WriteLine("No se ingreso un nombre de producto, el programa se cerrara");
                }

                    
                
                
            } while (NombreProducto != "");
            
        }
    }
}
