/*
 *  Ejercicio Nro 01:
 *  
 *  Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
 *  
 */

using System.Text;

namespace Ejercicio_Nro_01
{
    internal class Ejercicio_Nro_01
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";

            string auxString;
            double numeroIngresado, maxVal=0, minVal=0, promedio, acum=0;

            for(int i = 1; i <= 5; i++)
            {
                do
                {
                    //ingreso del numero por parte del user
                    Console.Write($"Ingrese el {i}° número: ");
                    auxString = Console.ReadLine();

                    //iteración hasta validacion del dato ingresado
                } while (!double.TryParse(auxString, out numeroIngresado));
                
                if (i==1)
                { 
                    maxVal = numeroIngresado;
                    minVal = numeroIngresado;
                } 
                else if(numeroIngresado > maxVal)
                {
                    maxVal = numeroIngresado;
                } 
                else if (numeroIngresado < minVal)
                {
                    minVal = numeroIngresado;
                }

                acum += numeroIngresado;                
            }

            promedio = acum / 5;
            Console.Clear();

            StringBuilder respuesta = new StringBuilder();
            respuesta.AppendLine($"Mayor número ingresado : {maxVal, 0:#,###.00}");
            respuesta.AppendLine($"Menor número ingresado : {minVal, 0:#,###.00}");
            respuesta.AppendLine($"Promedio: 				{promedio, 0:#,###.00}");

            Console.WriteLine(respuesta.ToString());
        }
    }
}