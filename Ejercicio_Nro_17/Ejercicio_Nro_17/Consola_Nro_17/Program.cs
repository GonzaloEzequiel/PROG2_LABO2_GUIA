/*
 *  Ejercicio Nro 17:
 *  
 *  Crear la clase Bolígrafo a partir del siguiente diagrama:
 *  
 *       -------------------------------------------------------
 *      |   Bolígrafo                                           |
 *      |     Fields                                            |
 *      |       (const) cantidadTintaMaxima : short             |
 *      |       (private) color : ConsoleColor                  |
 *      |       (private) tinta : short                         |
 *      |     Methods                                           |
 *      |       Boligrafo(short tinta, ConsoleColor color)      |
 *      |       GetColor() : ConsoleColor                       |
 *      |       GetTinta() : short                              |
 *      |       intar(short gasto, out string dibujo) : bool    |
 *      |       Recargar() : void                               |
 *      |       (private) SetTinta(short tinta) : void          |
 *      |_______________________________________________________|
 *      
 *  a.  La cantidad máxima de tinta para todos los bolígrafos será de 100. 
 *      Generar una constante en el Bolígrafo llamada cantidadTintaMaxima donde se guardará dicho valor.
 *      
 *  b.	Generar los métodos GetColor y GetTinta para los correspondientes atributos (sólo retornarán el valor del mismo).
 *  
 *  c.	Generar el método privado SetTinta que valide el nivel de tinta y asigne en el atributo.
 *          i.	tinta será el valor a agregar de tinta, pudiendo ser positivo (cargar tinta) o negativo (gastar tinta)
 *          ii.	Se deberá validar que el nivel de tinta quede entre los valores válidos mayor o igual a 0 y menor o igual a cantidadTintaMaxima.
 *      
 *  d.	Recargar() colocará a tinta en su nivel máximo de tinta. Reutilizar código.
 *  
 *  e.	En el Main, crear un bolígrafo de tinta azul (ConsoleColor.Blue) y una cantidad inicial de tinta de 100 
 *      y otro de tinta roja (ConsoleColor.Red) y 50 de tinta.
 * 
 *  f.	El método Pintar(short, out string) restará la tinta gastada (reutilizar código SetTinta), sin poder quedar el nivel en negativo, 
 *      avisando si pudo pintar (nivel de tinta mayor a 0). También informará mediante el out string tantos "*" como haya podido "gastar" 
 *      del nivel de tinta. O sea, si nivel de tinta es 10 y gasto es 2 valdrá "**" y si nivel de tinta es 3 y gasto es 10 "***". *  
 *  
 *  g.	Utilizar todos los métodos en el Main.
 *  
 *  h.	Al utilizar Pintar, si corresponde, se deberá dibujar por pantalla con el color de dicho bolígrafo.
 *  
 *  
 *  Nota: Crear el constructor que crea conveniente. La clase Bolígrafo y el Program deben estar en namespaces distintos.
 *  
 */

using Biblioteca_Nro_17;

namespace Consola_Nro_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);

            string dibujo = string.Empty;

            //metodo Recargar Azul no pasa pues está al máximo
            Console.WriteLine($"Nivel de tinta boligrafo Azul: {boligrafoAzul.GetTinta()}");

            //metodo Pintar Azul
            if(boligrafoAzul.Pintar(20, out dibujo))
                Console.WriteLine(dibujo);

            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine($"Nivel de tinta boligrafo Azul: {boligrafoAzul.GetTinta()}");

            Console.WriteLine("-------------------------------------");

            Console.WriteLine($"Nivel de tinta boligrafo Rojo: {boligrafoRojo.GetTinta()}");

            //metodo Pintar Rojo (negado pues no alcanza la tinta)
            if (!boligrafoRojo.Pintar(60, out dibujo))
                Console.WriteLine(dibujo);

            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine($"Nivel de tinta boligrafo Rojo: {boligrafoRojo.GetTinta()}");

            //metodo Recargar Rojo
            boligrafoRojo.Recargar();
            Console.WriteLine($"Se carga el boligrafo rojo... Nivel de Tinta: {boligrafoRojo.GetTinta()}");


            Console.ReadKey();
        }
    }
}