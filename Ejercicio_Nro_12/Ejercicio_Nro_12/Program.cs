/*
 *  Ejercicio Nro 12
 * 
 *  Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de un mensaje "¿Continuar? (S/N)".
 *  En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de opciones.V
 *  El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
 *  
 */

namespace Ejercicio_Nro_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 12";

            int numeroIngresado;
            int acumulador = 0;
            char auxChar;
            int i = 1;

            do
            {
                //solicitud y validacion de ingreso de dato por parte del user
                Console.Write($"Ingrese número {i}°: ");
                while (!int.TryParse(Console.ReadLine(), out numeroIngresado))
                    Console.Write($"Error! Reingrese número {i}°: ");

                //se suma al total en cada iteración, el numero ingresado por el usuario
                acumulador += numeroIngresado;
                i++;
                                
                Console.Write("¿Desea Continuar? S/N ");
                while (!char.TryParse(Console.ReadLine().ToUpper(), out auxChar))
                    Console.Write("¿Desea Continuar? S/N ");

                Console.WriteLine();

            } while (ValidarRespuesta.ValidaS_N(auxChar));

            Console.Clear();
            Console.Write($"El total sumado es {acumulador}");
        }
    }
}