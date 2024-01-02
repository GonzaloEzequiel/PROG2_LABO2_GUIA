using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_21
{
    public class Celsius
    {
        private double cantidad;

        public Celsius(double cantidad)
        {
            this.cantidad = cantidad;
        }

        // METODOS

        /// <summary>
        /// Construye implicitamente un objeto Celsius, dado un valor double
        /// </summary>
        /// <param name="d">cantidad</param>
        public static explicit operator Celsius(double d)
        {
            return new Celsius(d);
        }

        /// <summary>
        /// Construye explicitamente un objeto Fahrenheit, dado un objeto Celsius
        /// </summary>
        /// <param name="c">objeto Celsius</param>
        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit(c.GetCantidad() * 9/5 + 32);
        }

        /// <summary>
        /// Construye explicitamente un objeto Kelvin, dado un objeto Celsius
        /// </summary>
        /// <param name="c">objeto Celsius</param>
        public static explicit operator Kelvin(Celsius c)
        {
            return new Kelvin((((Fahrenheit)c).GetCantidad() + 459.67) * 5/9);
        }

        /// <summary>
        /// Muestra la cantidad de este objeto Celsius
        /// </summary>
        /// <returns>la cantidad de grados</returns>
        public double GetCantidad()
        {
            return this.cantidad;
        }

        /// <summary>
        /// Compara si dos objetos Celsius son iguales segun sus cantidad
        /// </summary>
        /// <param name="c1">primer objeto Celsius</param>
        /// <param name="c2">segundo objeto Celsius</param>
        /// <returns>true si son iguales, false si no lo son</returns>
        public static bool operator ==(Celsius c1, Celsius c2)
        {
            return c1.GetCantidad() == c2.GetCantidad();
        }

        /// <summary>
        /// Compara si un objeto Celsius es igual a un objeto Kelvin, según la relación entre sus cantidades
        /// </summary>
        /// <param name="c">objeto Celsius</param>
        /// <param name="k">objeto Kelvin</param>
        /// <returns>true si son iguales, false si no lo son</returns>
        public static bool operator ==(Celsius c, Kelvin k)
        {
            return c.GetCantidad() == ((Celsius)k).GetCantidad();
        }

        /// <summary>
        /// Compara si un objeto Celsius es igual a un objeto Fahrenheit, según la relación entre sus cantidades
        /// </summary>
        /// <param name="c">objeto Celsius</param>
        /// <param name="f">objeto Fahrenheit</param>
        /// <returns>true si son iguales, false si no lo son</returns>
        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            return c.GetCantidad() == ((Celsius)f).GetCantidad();
        }

        /// <summary>
        /// Compara si dos objetos Celsius son distintos segun sus cantidad
        /// </summary>
        /// <param name="c1">primer objeto Celsius</param>
        /// <param name="c2">segundo objeto Celsius</param>
        /// <returns>true si son distintos, false si no lo son</returns>
        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1 == c2);
        }

        /// <summary>
        /// Compara si un objeto Celsius es distinto a un objeto Kelvin, según la relación entre sus cantidades
        /// </summary>
        /// <param name="c">objeto Celsius</param>
        /// <param name="k">objeto Kelvin</param>
        /// <returns>true si son distintos, false si no lo son</returns>
        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c == k);
        }

        /// <summary>
        /// Compara si un objeto Celsius es distinto a un objeto Fahrenheit, según la relación entre sus cantidades
        /// </summary>
        /// <param name="c">objeto Celsius</param>
        /// <param name="f">objeto Fahrenheit</param>
        /// <returns>true si son distintos, false si no lo son</returns>
        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(c == f);
        }

        /// <summary>
        /// Suma un objeto Fahrenheit a un objeto Celsius, según la relación entre sus cantidades
        /// </summary>
        /// <param name="c">objeto Celsius</param>
        /// <param name="f">objeto Fahrenheit</param>
        /// <returns>Un nuevo objeto Celsius con la suma de sus cantidades</returns>
        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.GetCantidad() + ((Celsius)f).GetCantidad());
        }

        /// <summary>
        /// Suma un objeto Kelvin a un objeto Celsius, según la relación entre sus cantidades
        /// </summary>
        /// <param name="c">objeto Celsius</param>
        /// <param name="k">objeto Kelvin</param>
        /// <returns>Un nuevo objeto Celsius con la suma de sus cantidades</returns>
        public static Celsius operator +(Celsius c, Kelvin k)
        {
            return new Celsius(c.GetCantidad() + ((Celsius)k).GetCantidad());
        }

        /// <summary>
        /// Resta un objeto Fahrenheit a un objeto Celsius, según la relación entre sus cantidades
        /// </summary>
        /// <param name="c">objeto Celsius</param>
        /// <param name="f">objeto Fahrenheit</param>
        /// <returns>Un nuevo objeto Celsius con la resta de sus cantidades</returns>
        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.GetCantidad() - ((Celsius)f).GetCantidad());
        }

        /// <summary>
        /// Resta un objeto Kelvin a un objeto Celsius, según la relación entre sus cantidades
        /// </summary>
        /// <param name="c">objeto Celsius</param>
        /// <param name="k">objeto Kelvin</param>
        /// <returns>Un nuevo objeto Celsius con la resta de sus cantidades</returns>
        public static Celsius operator -(Celsius c, Kelvin k)
        {
            return new Celsius(k.GetCantidad() - ((Celsius)c).GetCantidad());
        }
    }
}
