/*
 *  Ejercicio Nro 13	
 *  
 *  Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
 *  string DecimalBinario(int). Convierte un número de entero a binario.
 *  int BinarioDecimal(string). Convierte un número binario a entero.
 *  
 *  NOTA: no utilizar los atajos del lenguaje, hacerlo mediante estructuras repetitivas y de control.
 * 
 */

using System.Timers;

namespace Ejercicio_Nro_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 13";

            int numeroDecimal;
            string numeroBinario;
            bool esBinario;

            //solicitud y validacion de ingreso de dato por parte del user
            Console.Write($"Ingrese número entero: ");
            while (!int.TryParse(Console.ReadLine(), out numeroDecimal))
                Console.Write($"Ingrese número entero: ");                       

            do
            {
                esBinario = true;

                Console.Write($"Ingrese número binario: ");
                numeroBinario = Console.ReadLine();
                
                for (int i = 0; i < numeroBinario.Length; i++)
                {
                    if (numeroBinario[i] != '0' && numeroBinario[i] != '1')
                    {
                        esBinario = false;
                        break;
                    }
                }

            } while (!esBinario);

            Console.Clear();
            Console.WriteLine($"Numero Decimal ingresado: {numeroDecimal} es {Conversor.DecimalBinario(numeroDecimal)} en binario!");
            Console.WriteLine($"Numero Binario ingresado: {numeroBinario} es {Conversor.BinarioDecimal(numeroBinario)} en decimal!");

            Console.ReadKey();
        }
    }
}