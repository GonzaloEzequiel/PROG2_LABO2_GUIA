/*
 *  Ejercicio Nro 19
 *  
 * 	Realizar una aplicación de consola. Agregar la clase Sumador.
 * 
 *   -------------------------------------------------------
 *  |   Sumador                                             |
 *  |     Fields                                            |
 *  |       (private) cantidadSumas : int                   |
 *  |     Properties                                        |
 *  |       CaballosDeFuereza { get; set; } : short         |
 *  |     Methods                                           |
 *  |       explicit operator int(Sumador s) : int          |
 *  |       operator |(Sumdaror s1, Sumador s1) : bool      |
 *  |       operator +(Sumdaror s1, Sumador s1) : long      | 
 *  |       Sumador()                                       |
 *  |       Sumador(int cantidadSumas)                      |
 *  |       Sumar(long a, long b) : long                    |
 *  |       Sumar(string a, string b) : string              |
 *  |_______________________________________________________|
 * 
 *  a.	Crear dos constructores:
 *      i.	Sumador(int) inicializa cantidadSumas en el valor recibido por parámetros.
 *      ii.	Sumador() inicializa cantidadSumas en 0. Reutilizará al primer constructor.
 *      
 *  b.	El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la siguiente lógica:
 *      i.	En el caso de Sumar(long, long) sumará los valores numéricos
 *      ii.	En el de Sumar(string, string) concatenará las cadenas de texto.
 *          
 *  Antes de continuar, agregar un objeto del tipo Sumador en el Main y probar el código.
 *  
 *  c.	Generar una conversión explícita que retorne cantidadSumas.
 *  
 *  d.	Sobrecargar el operador + (suma) para que puedan sumar cantidadSumas y retornen un long con dicho valor.
 *  
 *  e.	Sobrecargar el operador | (pipe) para que retorne True si ambos sumadores tienen igual cantidadSumas.
 *  
 *  
 *  Agregar un segundo objeto del tipo Sumador en el Main y probar el código.
 * 
 */

namespace Consola_Nro_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //primera instancia contructor vacio
            Sumador sumadorLoco = new Sumador();
            //prueba de metodo Sumar con sus dos sobrecargas
            Console.WriteLine(sumadorLoco.Sumar(4, 5));
            Console.WriteLine(sumadorLoco.Sumar("Hola", "Mundo"));
            //prueba de la sobrecarga explícita y muestra en consola
            int auxContador = (int)sumadorLoco;
            Console.WriteLine($"Total sumas de sumadorLoco: {auxContador}");
            //segunda instancia contructor con int
            Sumador sumadorCuerdo = new Sumador(20);
            auxContador = (int)sumadorCuerdo;
            //prueba de la sobrecarga comparativa (|)
            if (sumadorLoco | sumadorCuerdo)
                Console.WriteLine("Ambos tienen la misma cantidad de sumas");
            else
                Console.WriteLine("Los Sumadores tienen distintas cantidades de sumas");
            //prueba de la sobrecarga sumadora (+)
            long auxContador2 = sumadorLoco + sumadorCuerdo;
            Console.WriteLine($"Cantidad de sumas totales: {auxContador2}");

            Console.ReadKey();
        }
    }
}