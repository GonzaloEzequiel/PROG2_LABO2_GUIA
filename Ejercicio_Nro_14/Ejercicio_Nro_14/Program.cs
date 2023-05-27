/*
 *  Ejercicio Nro 14
 * 
 *  Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) que realicen el cálculo del área que corresponda:
 *      double CalcularCuadrado(double)
 *      double CalcularTriangulo(double, double)
 *      double CalcularCirculo(double)
 *      
 *  El ingreso de los datos como la visualización se deberán realizar desde el método Main().
 * 
 */

namespace Ejercicio_Nro_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 14";

            char opcion;
            double numeroIngresado1, numeroIngresado2, resultado = 0;

            string auxString = string.Empty;

            //Menú principal
            do
            {
                Console.WriteLine("** CALCULADORA DE AREA **");

                Console.WriteLine("¿Qué Desea Calcular?");
                Console.WriteLine("a. Cuadrado");
                Console.WriteLine("b. Triángulo");
                Console.WriteLine("c. Círculo");

                char.TryParse(Console.ReadLine(), out opcion);

            } while (opcion != 'a' && opcion != 'b' && opcion != 'c');

            switch (opcion)
            {
                case 'a':
                    Console.Write("Ingresar Lado: ");
                    auxString = Console.ReadLine();
                    while (!double.TryParse(auxString, out numeroIngresado1))
                    {
                        Console.Write("Error ingrese un número: ");
                        auxString = Console.ReadLine();
                    }
                    auxString = "cuadrado";
                    resultado = CalculoDeArea.CalcularCuadrado(numeroIngresado1);
                    break;

                case 'b':
                    Console.Write("Ingresar Base: ");
                    auxString = Console.ReadLine();
                    while (!double.TryParse(auxString, out numeroIngresado1))
                    {
                        Console.Write("Error ingrese un número: ");
                        auxString = Console.ReadLine();
                    }
                    Console.Write("Ingresar Altura: ");
                    auxString = Console.ReadLine();
                    while (!double.TryParse(auxString, out numeroIngresado2))
                    {
                        Console.Write("Error ingrese un número: ");
                        auxString = Console.ReadLine();
                    }

                    auxString = "triángulo";
                    resultado = CalculoDeArea.CalcularTriangulo(numeroIngresado1, numeroIngresado2);
                    break;

                case 'c':
                    Console.Write("Ingresar Radio: ");
                    auxString = Console.ReadLine();
                    while (!double.TryParse(auxString, out numeroIngresado1))
                    {
                        Console.Write("Error ingrese un número: ");
                        auxString = Console.ReadLine();
                    }
                    auxString = "cuadrado";
                    resultado = CalculoDeArea.CalcularCirculo(numeroIngresado1);
                    break;

                default:
                    break;
            }

            Console.WriteLine($"El area del {auxString} es: {resultado} unidades");

            Console.ReadKey();
        }
    }
}