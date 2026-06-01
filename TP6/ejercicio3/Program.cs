using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//cree una funcion llamada login que reciba nombre de usuario y contraseña, la funcion debe devolver un true si el usuario es "Admin" y la contraseña "1234" y permitir hasta 3 intentos, antes de bloquear el acceso. Mostrar en el programa prinvipal si el acceso fue concedido o denegado.
namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxIntentos = 3;
            string usuario;
            string contraseña;
            int intentos = 1;
            Console.WriteLine("BIENVENIDO A NUESTRO SISTEMA DE REGISTRO DE TRABAJOS DE  LA MATERIA PROYECTOS");
            do
            {
                
                Console.WriteLine("Ingrese su nombre de usuario: ");
                usuario = Console.ReadLine();
                Console.WriteLine("Ingrese su contraseña: ");
                contraseña = Console.ReadLine();
                
                bool verificador = Login(usuario, contraseña);

                switch (verificador)
                    {

                        case true:
                            Console.WriteLine("Acceso concedido > Bienvenido al sistema.");
                            intentos = 4;
                            break;
                        case false:
                        Console.WriteLine("Acceso denegado > Intente nuevamente.");
                            
                        break;
                    }
                intentos++;

            } while (intentos <= maxIntentos) ;
            if (intentos > maxIntentos)
            {
                Console.WriteLine("Demasiados intentos fallidos > Acceso bloqueado.");
            }   

        }
        public static bool Login(string usuario, string contraseña)
        {
            if (usuario == "admin" && contraseña == "123")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
