using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//conversion de moneda argentina a dolar.
namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal monedaArgentina = 0M;
            decimal cotizacionDolarHoy = 1.440M;
            decimal cantidadDolares = 0M;
            Console.WriteLine("Ingrese la cantidad de pesos argentinos que quiere cambiar a dolares()");
            monedaArgentina = decimal.Parse(Console.ReadLine());
            cantidadDolares = (monedaArgentina / cotizacionDolarHoy);
            Console.WriteLine($"La cantidad de dolares que recibe por {monedaArgentina} pesos argentinos, son {cantidadDolares} Dolares");





        }
    }
}
