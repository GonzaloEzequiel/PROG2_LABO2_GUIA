using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_21
{
    public class Kelvin
    {
        private double cantidad;        

        public Kelvin(double cantidad)
        {
            this.cantidad = cantidad;
        }

        //METODOS

        /// <summary>
        /// Construye explícitamente un objeto Kelvin, dada una cantidad
        /// </summary>
        /// <param name="d">cantidad</param>
        public static explicit operator Kelvin(double d)
        {
            return new Kelvin(d);
        }

        /// <summary>
        /// Construye explícitamente un objeto Fahrenheit, dado un objeto Kelvin
        /// </summary>
        /// <param name="k">objeto Kelvin</param>
        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit(k.GetCantidad() * 9/5 - 459.67);
        }

        /// <summary>
        /// Construye explícitamente un objeto Celsius, dado un objeto Kelvin
        /// </summary>
        /// <param name="k">objeto Kelvin</param>
        public static explicit operator Celsius(Kelvin k)
        {
            return new Celsius((((Fahrenheit)k).GetCantidad() - 32) * 5/9);
        }

        /// <summary>
        /// Muestra la cantidad de este objeto Kelvin
        /// </summary>
        /// <returns>la cantidad de grados</returns>
        public double GetCantidad()
        {
            return this.cantidad;
        }

        /// <summary>
        /// Compara si dos objetos Kelvin son iguales segun sus cantidad
        /// </summary>
        /// <param name="k1">primer objeto Kelvin</param>
        /// <param name="k2">segundo objeto Kelvin</param>
        /// <returns>true si son iguales, false si no lo son</returns>
        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            return k1.GetCantidad() == k2.GetCantidad();
        }

        /// <summary>
        /// Compara si un objeto Kelvin es igual a un objeto Fahrenheit, según la relación entre sus cantidades
        /// </summary>
        /// <param name="k">objeto Kelvin</param>
        /// <param name="f">objeto Fahrenheit</param>
        /// <returns>true si son iguales, false si no lo son</returns>
        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            return k.GetCantidad() == ((Kelvin)f).GetCantidad();
        }

        /// <summary>
        /// Compara si un objeto Kelvin es igual a un objeto Celsius, según la relación entre sus cantidades
        /// </summary>
        /// <param name="k">objeto Kelvin</param>
        /// <param name="c">objeto Celsius</param>
        /// <returns>true si son iguales, false si no lo son</returns>
        public static bool operator ==(Kelvin k, Celsius c)
        {
            return k.GetCantidad() == ((Kelvin)c).GetCantidad();
        }

        /// <summary>
        /// Compara si dos objetos Kelvin son distintos segun sus cantidad
        /// </summary>
        /// <param name="k1">primer objeto Kelvin</param>
        /// <param name="k2">segundo objeto Kelvin</param>
        /// <returns>true si son distintos, false si no lo son</returns>
        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            return !(k1 == k2);
        }

        /// <summary>
        /// Compara si un objeto Kelvin es distinto a un objeto Fahrenheit, según la relación entre sus cantidades
        /// </summary>
        /// <param name="k">objeto Kelvin</param>
        /// <param name="f">objeto Fahrenheit</param>
        /// <returns>true si son distintos, false si no lo son</returns>
        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(f == k);
        }

        /// <summary>
        /// Compara si un objeto Kelvin es distinto a un objeto Celsius, según la relación entre sus cantidades
        /// </summary>
        /// <param name="k">objeto Kelvin</param>
        /// <param name="c">objeto Celsius</param>
        /// <returns>true si son distintos, false si no lo son</returns>
        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !(k == c);
        }

        /// <summary>
        /// Suma un objeto Fahrenheit a un objeto Kelvin, según la relación entre sus cantidades
        /// </summary>
        /// <param name="k">objeto Kelvin</param>
        /// <param name="f">objeto Fahrenheit</param>
        /// <returns>Un nuevo objeto Kelvin con la suma de sus cantidades</returns>
        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(k.GetCantidad() + ((Kelvin)f).GetCantidad());
        }

        /// <summary>
        /// Suma un objeto Celsius a un objeto Kelvin, según la relación entre sus cantidades
        /// </summary>
        /// <param name="k">objeto Kelvin</param>
        /// <param name="c">objeto Celsius</param>
        /// <returns>Un nuevo objeto Fahrenheit con la suma de sus cantidades</returns>
        public static Kelvin operator +(Kelvin k, Celsius c)
        {
            return new Kelvin(k.GetCantidad() + ((Kelvin)c).GetCantidad());
        }

        /// <summary>
        /// Resta un objeto Fahrenheit a un objeto Kelvin, según la relación entre sus cantidades
        /// </summary>
        /// <param name="k">objeto Kelvin</param>
        /// <param name="f">objeto Fahrenheit</param>
        /// <returns>Un nuevo objeto Kelvin con la resta de sus cantidades</returns>
        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(k.GetCantidad() - ((Kelvin)f).GetCantidad());
        }

        /// <summary>
        /// Resta un objeto Celsius a un objeto Kelvin, según la relación entre sus cantidades
        /// </summary>
        /// <param name="k">objeto Kelvin</param>
        /// <param name="c">objeto Celsius</param>
        /// <returns>Un nuevo objeto Kelvin con la resta de sus cantidades</returns>
        public static Kelvin operator -(Kelvin k, Celsius c)
        {
            return new Kelvin(k.GetCantidad() - ((Kelvin)c).GetCantidad());
        }
    }
}
