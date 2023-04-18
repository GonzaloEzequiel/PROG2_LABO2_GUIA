/*
 *  Ejercicio Nro 11
 * 
 *  Realizar una clase llamada Validación  que posea un método estático llamado Validar con la siguiente firma:     
 *  bool Validar(int valor, int min, int max)
 *      a. valor: dato a validar.
 *      b. min y max : rango en el cual deberá estar la variable valor.
 *  
 *  Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.
 *  Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
 *  Nota: Utilizar variables escalares, NO utilizar vectores.
 *  
 */

using System.Text;

namespace Ejercicio_Nro_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 11";

            int numeroIngresado;
            int cotaInferior = -100;
            int cotaSuperior = 100;
            int cantNumeros = 10;

            int minimoValorIngresado = 0;
            int maximoValorIngresado = 0;
            int acumulador = 0;
            float promedio;

            string auxString;

            for(int i=0; i< cantNumeros; i++)
            {
                //ingreso y validacion de datos
                Console.Write($"Ingrese un numero {i + 1}°: ");
                auxString = Console.ReadLine();
                while (!int.TryParse(auxString, out numeroIngresado))
                {
                    Console.Write("Error! Ingrese un numero: ");
                    auxString = Console.ReadLine();
                }                

                //valido si el número ingresado está entre los valores
                if (Validación.Validar(numeroIngresado, cotaInferior, cotaSuperior))
                {
                    Console.WriteLine($"Numero Ingresado, entre {cotaInferior} y {cotaSuperior} !");
                }

                //manejo de datos segun criterio
                if (i==0)
                {
                    minimoValorIngresado = numeroIngresado;
                    maximoValorIngresado = numeroIngresado;
                }
                else if (numeroIngresado > maximoValorIngresado)
                {
                    maximoValorIngresado = numeroIngresado;
                }
                else if (numeroIngresado < minimoValorIngresado)
                {
                    minimoValorIngresado = numeroIngresado;
                }

                acumulador += numeroIngresado;
            }

            promedio = acumulador / cantNumeros;

            //Muestro en pantalla
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Valor mínimo ingresado: {minimoValorIngresado}");
            sb.AppendLine($"Valor máximo ingresado: {maximoValorIngresado}");
            sb.AppendLine($"Promedio de los números ingresados: {promedio}");

            Console.WriteLine(sb.ToString());

            Console.ReadKey();
        }
    }
}
