/*
 *  Ejercicio Nro 15
 *  
 *  Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división). 
 *  Para ello se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (pulsando el caracter +, -, * o /).
 *  El usuario decidirá cuándo finalizar el programa.
 *  
 *  Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
 *      Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la operación matemática. 
 *      El método devolverá el resultado de la operación.
 *      
 *      Validar (privado): Recibirá como parámetro el segundo número. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN.
 *      Este método devolverá TRUE si el número es distinto de CERO.
 * 
 */

namespace Ejercicio_Nro_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 15";

            char salir = 'N';

            double operando1, operando2;
            double? resultado;
            char operacion;

            string auxString;

            do
            {
                Console.Clear();

                Console.Write("Ingrese primer número: ");
                auxString = Console.ReadLine();
                while (!double.TryParse(auxString, out operando1))
                {
                    Console.Write("Error! Ingrese primer número: ");
                    auxString = Console.ReadLine();
                }

                Console.Write("Ingrese segundo número: ");
                auxString = Console.ReadLine();
                while (!double.TryParse(auxString, out operando2))
                {
                    Console.Write("Error! Ingrese segundo número: ");
                    auxString = Console.ReadLine();
                }

                do
                {
                    Console.Write("Ingrese operacion [+ - * /] : ");
                    char.TryParse(Console.ReadLine(), out operacion);

                } while (operacion != '+' && operacion != '-' && operacion != '*' && operacion != '/');

                resultado = Calculadora.Calcular(operando1, operando2, operacion);

                if (resultado != null)
                    Console.WriteLine($"{operando1} {operacion} {operando2} = {resultado}");
                else
                    Console.WriteLine("No es posible dividir por CERO");

                Console.WriteLine("¿Desea Salir? S/N");
                char.TryParse(Console.ReadLine().ToUpper(), out salir);

            } while (salir != 'S');

            Console.ReadKey();
        }
    }
}