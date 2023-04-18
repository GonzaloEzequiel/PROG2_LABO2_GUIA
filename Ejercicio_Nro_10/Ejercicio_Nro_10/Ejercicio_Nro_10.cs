/*
 *  Ejercicio Nro 10:
 *  
 *  Partiendo de la base del ejercicio anterior, se pide realizar un programa que imprima por pantalla una pirámide como la siguiente:
 *  
 *          *
 *         ***
 *        *****
 *       *******
 *      *********
 *      
 *  Nota: Utilizar estructuras repetitivas y selectivas.
 * 
 */

namespace Ejercicio_Nro_10
{
    internal class Ejercicio_Nro_10
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 10";

            int altura;
            string auxString;

            //seteo el tamaño de la consola para que ocupe la totalidad de la pantalla
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

            //rojo navideño
            Console.ForegroundColor = ConsoleColor.DarkRed;

            //ingreso y validación del número (altura) por parte del usuario
            Console.WriteLine("** Triángulo Equilátero **");
            Console.Write("Ingrese altura: ");
            auxString = Console.ReadLine();
            while (!int.TryParse(auxString, out altura) || altura <= 0)
            {
                Console.WriteLine("Error! Ingrese un numero entero postivo: ");
            }

            //iteracion de "altura" de la pirámide (cant pisos)
            for (int i = 1; i <= altura; i++)
            {
                //la primer iteracion setea el cursor en el centro del ancho y justo por debajo del texto impreso
                //por cada piso que imprime setea el cursor del siguiente una unidad a la izquierda y un piso más abajo
                Console.SetCursorPosition(Console.LargestWindowWidth / 2 - i, 1 + i);

                //iteracion de "ancho" del piso
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