/*
 *  Ejerecicio Nro 21.	
 *  
 *  Crear tres clases: Fahrenheit, Celsius y Kelvin. 
 *  Realizar un ejercicio similar al anterior, teniendo en cuenta que:
 *  
 *      F = C * (9/5) + 32
 *      C = (F-32) * 5/9
 *      
 *      F = K * 9/5 – 459.67
 *      K = (F + 459.67) * 5/9
 * 
 */

namespace Ejercicio_Nro_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Fahrenheit f1 = new Fahrenheit(40);

            Kelvin k1 = new Kelvin(40);

            Console.WriteLine($"Fahrenheint = {f1.GetCantidad()}°");
            Console.WriteLine($"Kelvin = {k1.GetCantidad()}°");

            Fahrenheit f2 = (Fahrenheit)k1;

            Console.WriteLine($"Kelvin = {f2.GetCantidad()}°F");

            Fahrenheit f3 = f1 + k1;

            Fahrenheit f4 = f1 - k1;

            Console.WriteLine($"Suma = {f3.GetCantidad()}");
            Console.WriteLine($"Resta = {f4.GetCantidad()}");

        }
    }
}