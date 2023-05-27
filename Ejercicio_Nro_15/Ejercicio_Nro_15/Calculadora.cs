using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_15
{
    internal class Calculadora
    {
        public delegate double DelegadoOperacion(double a, double b);       

        /// <summary>
        /// Realiza una operación entre dos opereandos y devuelve su resultado
        /// </summary>
        /// <param name="numero1">Primero operando</param>
        /// <param name="numero2">Segundo operando</param>
        /// <param name="operacion">Operación seleccionada</param>
        /// <returns>El método devuelve el resultado de la operación seleccionada</returns>
        public static double? Calcular(double numero1, double numero2, char operacion)
        {
            double? resultado = null;

            //DelegadoOperacion dele = new DelegadoOperacion(numero1, numero2);

            switch (operacion)
            {
                case '+':
                    resultado = numero1 + numero2;
                    //double r = (numero1, numero2) => numero1 + numero2;
                    break;
                case '-':
                    resultado = numero1 - numero2;
                    break;
                case '*':
                    resultado = numero1 * numero2;
                    break;
                case '/':
                    if (Calculadora.Validar(numero2))
                        resultado = numero1 / numero2;
                    break;
                default:
                    break;
            }

            return resultado;
        }

        /// <summary>
        /// Valida si el número es distinto de CERO.
        /// </summary>
        /// <param name="denominador"></param>
        /// <returns>Este método devolverá TRUE si el número es distinto de CERO.</returns>
        public static bool Validar(double denominador)
        {
            return denominador != 0;
        }
    }
}
