using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_14
{
    internal class CalculoDeArea
    {
        /// <summary>
        /// Calcula el area de un cuadrado
        /// </summary>
        /// <param name="longitudLado">double longitud del lado del cuadrado</param>
        /// <returns>double el valor del area segun el valor ingresado</returns>
        public static double CalcularCuadrado(double longitudLado)
        {
            return Math.Pow(longitudLado, 2);
        }

        /// <summary>
        /// Calcula el area de un triángulo
        /// </summary>
        /// <param name="longitudLado">double longitud de la base del triángulo</param>
        /// <param name="longitudLado">double longitud de la altura del triángulo</param>
        /// <returns>double el valor del area segun los valores ingresados</returns>
        public static double CalcularTriangulo(double base1, double altura)
        {
            return (base1 * altura) / 2;
        }

        /// <summary>
        /// Calcula el area de un circulo
        /// </summary>
        /// <param name="longitudLado">double longitud del radio de la cuircunferencia</param>
        /// <returns>double el valor del area segun el valor ingresado</returns>
        public static double CalcularCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
