using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_11
{
    internal static class Validación
    {
        /// <summary>
        /// Valida si un número, se encuentra acotado entre dos valores, mínimo y máximo respectivamente
        /// </summary>
        /// <param name="valor">Número a evaluar</param>
        /// <param name="min">Valor mínimo / cota inferior</param>
        /// <param name="max">Valor máximo / cota superior</param>
        /// <returns>(boolean) true si encuentra entre los valres, false si no</returns>
        internal static bool Validar(int valor, int min, int max)
        {
            return (valor >= min && valor <= max);
        }
    }
}
