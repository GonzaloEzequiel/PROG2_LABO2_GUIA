using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_13
{
    internal static class Conversor
    {
        /// <summary>
        /// Convierte un número decimal a un número binario
        /// </summary>
        /// <param name="numeroEntero">int numeroBinario decimal a convertir</param>
        /// <returns>string retorna el número decimal converitdo a binario como una cadena</returns>
        internal static string DecimalBinario(int numeroEntero)
        {
            int[] numeroBinario = new int[50];
            int i = 0;

            do
            {
                //almacena en el array de enteros, los restos de dividir constantemente el numeroBinario en 2. Esto resulta en tener invertido lo indices del numeroBinario binario.
                numeroBinario[i] = numeroEntero % 2;
                numeroEntero /= 2;
                i++;

            } while (numeroEntero > 0);

            StringBuilder reordenamiento = new StringBuilder();

            //se itera la misma cantidad de veces que en el paso anterior, reordenando (de atras hacia adelante) el array de enteros para mostrarlo como cadena
            for (int j = i - 1; j >= 0; j--)
            {
                reordenamiento.Append(numeroBinario[j]);
            }

            return reordenamiento.ToString();
        }

        /// <summary>
        /// Convierte un string previamente validado de binario a decimal
        /// </summary>
        /// <param name="numeroBinario">número a convertir a decimal</param>
        /// <returns>(int) el número convertido a decimal</returns>
        public static int BinarioDecimal(string numeroBinario)
        {
            //return Convert.ToInt32(numeroBinario, 2);

            int auxint = 0;

            for (int index = (numeroBinario.Length - 1); index >= 0; index--)
            {
                auxint += int.Parse(numeroBinario[index].ToString()) * (int)Math.Pow(2, ((numeroBinario.Length - 1) - index));
            }

            return auxint;
        }
    }
}