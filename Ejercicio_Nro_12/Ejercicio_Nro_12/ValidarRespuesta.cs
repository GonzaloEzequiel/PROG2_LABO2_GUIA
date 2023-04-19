using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_12
{
    internal static class ValidarRespuesta
    {
        /// <summary>
        /// Valida si el caracter ingresado es o no es 'S'
        /// </summary>
        /// <param name="c">caracter ingresado</param>
        /// <returns>(boolean) true si el caracter ingresado es una 'S', false si es cualquier otro valor</returns>
        internal static bool ValidaS_N(char c)
        {
            return c == 'S';
        }
    }
}
