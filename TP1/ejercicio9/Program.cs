using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//porsentaje de asistencia
namespace ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal cantidadDiasClases = 0M;
            decimal cantidadDiasAsistidos = 0M;
            decimal porcentajeAsistencia = 0M;

            Console.WriteLine("Ingrese la cantidad de dias de clases");
            cantidadDiasClases = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de dias asistidos del alumno");
            cantidadDiasAsistidos = decimal.Parse(Console.ReadLine());

            porcentajeAsistencia = ((cantidadDiasAsistidos / cantidadDiasClases) * 100M);
            Console.WriteLine($"El porcentaje de asistencia del alumno es de {porcentajeAsistencia}%");



        }
    }
}
