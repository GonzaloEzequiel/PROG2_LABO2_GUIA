using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_21
{
    public class Fahrenheit
    {
        private double cantidad;

        public Fahrenheit(double cantidad)
        {
            this.cantidad = cantidad;
        }

        //METODOS

        /// <summary>
        /// Construye explicitamente un objeto Fahrenheit, dada una cantidad
        /// </summary>
        /// <param name="d">cantidad</param>
        public static explicit operator Fahrenheit(double d)
        {
            return new Fahrenheit(d);
        }

        /// <summary>
        /// Construye explícitamente un objeto Celsius, dado un objeto Farenheit
        /// </summary>
        /// <param name="f">objeto Fahrenheit</param>
        public static explicit operator Celsius(Fahrenheit f)
        {
            return new Celsius((f.GetCantidad() - 32) * 5 / 9);
        }

        /// <summary>
        /// Construye explícitamente un objeto Kelvin, dado u objeto Farenheit
        /// </summary>
        /// <param name="f">objeto Fahrenheit</param>
        public static explicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin((f.GetCantidad() + 459.67) * 5 / 9);
        }

        /// <summary>
        /// Muestra la cantidad de este objeto Fahrenheit
        /// </summary>
        /// <returns>la cantidad de grados</returns>
        public double GetCantidad()
        {
            return this.cantidad;
        }

        /// <summary>
        /// Compara si dos objetos Fahrenheit son iguales segun sus cantidad
        /// </summary>
        /// <param name="f1">primer objeto Fahrenheit</param>
        /// <param name="f2">segundo objeto Fahrenheit</param>
        /// <returns>true si son iguales, false si no lo son</returns>
        public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
        {
            return f1.GetCantidad() == f2.GetCantidad();
        }

        /// <summary>
        /// Compara si un objeto Fahrenheit es igual a un objeto Kelvin, según la relación entre sus cantidades
        /// </summary>
        /// <param name="f">objeto Fahrenheit</param>
        /// <param name="k">objeto Kelvin</param>
        /// <returns>true si son iguales, false si no lo son</returns>
        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            return f.GetCantidad() == ((Fahrenheit)k).GetCantidad();
        }

        /// <summary>
        /// Compara si un objeto Fahrenheit es igual a un objeto Celsius, según la relación entre sus cantidades
        /// </summary>
        /// <param name="f">objeto Fahrenheit</param>
        /// <param name="c">objeto Celsius</param>
        /// <returns>true si son iguales, false si no lo son</returns>
        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            return f.GetCantidad() == ((Fahrenheit)c).GetCantidad();
        }

        /// <summary>
        /// Compara si dos objetos Fahrenheit son distintos segun sus cantidad
        /// </summary>
        /// <param name="f1">primer objeto Fahrenheit</param>
        /// <param name="f2">segundo objeto Fahrenheit</param>
        /// <returns>true si son distintos, false si no lo son</returns>
        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1 == f2);
        }

        /// <summary>
        /// Compara si un objeto Fahrenheit es distinto a un objeto Kelvin, según la relación entre sus cantidades
        /// </summary>
        /// <param name="f">objeto Fahrenheit</param>
        /// <param name="k">objeto Kelvin</param>
        /// <returns>true si son distintos, false si no lo son</returns>
        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !(f == k);
        }

        /// <summary>
        /// Compara si un objeto Fahrenheit es distinto a un objeto Celsius, según la relación entre sus cantidades
        /// </summary>
        /// <param name="f">objeto Fahrenheit</param>
        /// <param name="c">objeto Celsius</param>
        /// <returns>true si son distintos, false si no lo son</returns>
        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            return !(f == c);
        }

        /// <summary>
        /// Suma un objeto Kelvin a un objeto Fahrenheit, según la relación entre sus cantidades
        /// </summary>
        /// <param name="f">objeto Fahrenheit</param>
        /// <param name="k">objeto Kelvin</param>
        /// <returns>Un nuevo objeto Fahrenheit con la suma de sus cantidades</returns>
        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.GetCantidad() + ((Fahrenheit)k).GetCantidad());
        }

        /// <summary>
        /// Suma un objeto Celsius a un objeto Fahrenheit, según la relación entre sus cantidades
        /// </summary>
        /// <param name="f">objeto Fahrenheit</param>
        /// <param name="c">objeto Celsius</param>
        /// <returns>Un nuevo objeto Fahrenheit con la suma de sus cantidades</returns>
        public static Fahrenheit operator +(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.GetCantidad() + ((Fahrenheit)c).GetCantidad());
        }

        /// <summary>
        /// Resta un objeto Kelvin a un objeto Fahrenheit, según la relación entre sus cantidades
        /// </summary>
        /// <param name="f">objeto Fahrenheit</param>
        /// <param name="k">objeto Kelvin</param>
        /// <returns>Un nuevo objeto Fahrenheit con la resta de sus cantidades</returns>
        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.GetCantidad() - ((Fahrenheit)k).GetCantidad());
        }

        /// <summary>
        /// Resta un objeto Celsius a un objeto Fahrenheit, según la relación entre sus cantidades
        /// </summary>
        /// <param name="f">objeto Fahrenheit</param>
        /// <param name="c">objeto Celsius</param>
        /// <returns>Un nuevo objeto Fahrenheit con la resta de sus cantidades</returns>
        public static Fahrenheit operator -(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.GetCantidad() - ((Fahrenheit)c).GetCantidad());
        }
    }
}
