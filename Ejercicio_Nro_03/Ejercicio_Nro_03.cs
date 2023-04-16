/*
 *  Ejercicio Nro 03:	
 *  
 *  Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
 *  Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
 *
 */

namespace Ejercicio_Nro_03
{
    internal class Ejercicio_Nro_03
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 03";

            int numero;
            bool primo;

            string numeroString;

            //ingreso del numero por parte del user
            Console.WriteLine("Ingrese un número: ");
            numeroString = Console.ReadLine();

            //validacion del dato ingresado
            while (!int.TryParse(numeroString, out numero))
            {
                Console.WriteLine("Error! Reingrese un número: ");
                numeroString = Console.ReadLine();
            }

            Console.Clear();
            Console.WriteLine($"Números primos del 1 al {numero}:");

            //itero desde el 1 al numero ingresado (numerador)
            for (int i = 1; i < numero; i++)
            {
                primo = true;

                //itero desde i hasta el 1 (denominador)
                for (int j = i; j >= 1; j--)
                {
                    //un numero es primo si no tiene divisores (unicamente x 1 y x el mismo)
                    //yo asumo (en linea 39) que SÍ es primo, y si existe un divisor distinto de 1 rompo iteración
                    if ((i % j) == 0 && (j != 1 && j != i))
                    {
                        primo = false;
                        break;
                    }

                }

                //si es primo lo muestro
                if (primo)
                {
                    Console.Write($"{i}  ");
                }
            }
        }
    }
}