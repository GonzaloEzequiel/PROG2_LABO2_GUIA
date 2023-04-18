/*
 *  Ejercicio Nro 07:
 *  
 *  Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y calcule el número de días vividos 
 *  por esa persona hasta la fecha actual (tomar la fecha del sistema con DateTime.Now).
 *  Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos.
 * 
 */

namespace Ejercicio_Nro_07
{
    internal class Ejercicio_Nro_07
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 07";

            string fechaString;
            DateTime fechaNacimiento, hoy = DateTime.Now;
            int cantDias;

            //ingreso y validacion de la fecha por parte del user
            Console.WriteLine("Ingrese su fecha de nacimiento (día, mes y año): ");
            fechaString = Console.ReadLine();
            while (!DateTime.TryParse(fechaString, out fechaNacimiento))
            {
                Console.Clear();
                Console.WriteLine("Ingrese su fecha de nacimiento (día, mes y año): ");
                fechaString = Console.ReadLine();
            }

            cantDias = (hoy - fechaNacimiento).Days;

            //en el ejercicio anterior se calculó por formula cuándo un año es bisiesto, en este caso uso el método IsLeapYear(int year)
            //
            //itero entre los años vividos
            for (int i = fechaNacimiento.Year; i <= hoy.Year; i++)
            {
                //y si el año es bisiesto sumo un día
                if (DateTime.IsLeapYear(i))
                {
                    cantDias++;
                }
            }

            Console.WriteLine($"Número de días vividos: {cantDias}");
        }
    }
}