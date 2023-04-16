/*
 *  Ejercicio Nro 02:
 *  
 *  Ingresar un número y mostrar: el cuadrado y el cubo del mismo. 
 *  Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
 *  Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
 */

using System.Text;

namespace Ejercicio_Nro_02
{
    internal class Ejercicio_Nro_02
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02";

            double numeroIngresado;
            string auxString;

            //ingreso del numero por parte del user
            Console.Write("Ingrese un número positivo: ");
            auxString = Console.ReadLine();

            //validacion del dato ingresado
            while (!double.TryParse(auxString, out numeroIngresado) || numeroIngresado <= 0)
            {
                Console.Clear();
                Console.Write("Error, Reingrese un número positivo: ");
                auxString = Console.ReadLine();
            }

            Console.Clear();

            StringBuilder respuesta = new StringBuilder();
            respuesta.AppendLine($"El cuadrado de {numeroIngresado, 0:#,###.00} es: {Math.Pow(numeroIngresado, 2), 10:#,###.00}");
            respuesta.AppendLine($"El cubo de {numeroIngresado, 0:#,###.00} es: {Math.Pow(numeroIngresado, 3), 14:#,###.00}");

            Console.WriteLine(respuesta.ToString());
        }
    }
}