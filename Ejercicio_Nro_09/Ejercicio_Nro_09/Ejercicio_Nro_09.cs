/*
 *  Ejercicio Nro 09:
 *  
 *  Escribir un programa que imprima por consola un triángulo como el siguiente:
 *  
 *  *
 *  ***
 *  *****
 *  *******
 *  *********
 *  
 *  El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. Para el ejemplo anterior, la altura ingresada fue de 5.  
 *  Nota: Utilizar estructuras repetitivas y selectivas.
 * 
 */

using System.Text;

namespace Ejercicio_Nro_09
{
    internal class Ejercicio_Nro_09
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 09";

            int altura;
            string auxString;

            //ingreso y validación del número (altura) por parte del usuario
            Console.WriteLine("** Triángulo Rectángulo **");
            Console.Write("Ingrese altura: ");
            auxString = Console.ReadLine();
            while (!int.TryParse(auxString, out altura) || altura <= 0)
            {
                Console.WriteLine("Error! Ingrese un numero entero postivo: ");
            }

            Console.WriteLine();

            //iteracion de "altura" de la pirámide (cant de pisos)
            for (int i = 1; i <= altura; i++)
            {
                //iteracion del "ancho" del piso
                for (int j = i + (i - 1); j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}