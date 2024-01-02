/*
 *  47.	Crear una nueva solución:
 *      a.	Crear un proyecto del tipo Biblioteca de Clases:
 *          i.	Generar la clase Torneo con un tipo genérico.
 *              1.	Restringir el tipo genérico para que deba ser del tipo Equipo o sus derivados.
 *              2.	Tendrá un atributo equipos : List<T> y otro nombre : string.
 *              3.	Sobrecargar el operador == para que controle si un equipo ya está inscripto al torneo.
 *              4.	Sobrecargar el operador + para agregar un equipo a la lista, siempre y cuando este no se encuentre ya en el torneo.
 *              5.	El método Mostrar retornará los datos del torneo y de los equipos participantes.
 *              6.	El método privado CalcularPartido(T, T): string recibirá dos elementos del tipo T, 
 *                  que deberán ser del tipo Equipo o sus herencias, y calculará utilizando Random un resultado del partido. 
 *                  Retornará el resultado con el siguiente formato: “[EQUIPO1] [RESULTADO1] – [RESULTADO2] [EQUIPO2]”, 
 *                  siendo EQUIPOX el nombre del equipo y RESULTADOX la cantidad de goles/puntos.
 *              7.	La propiedad pública JugarPartido tomará dos equipos de la lista al azar y calculará el resultado del partido 
 *                  a través del método CalcularPartido.
 *                  
 *          ii.	Generar la clase Equipo abstracta.
 *              1.	Agregar un atributo nombre : string y otro fechaCreacion : datetime.
 *              2.	Dos equipos serán iguales si comparten el mismo nombre y fecha de creación.
 *              3.	El método Ficha retornará el nombre del equipo y su fecha de creación con el siguiente formato “[EQUIPO] fundado el [FECHA]”.
 *              
 *          iii.	Generar la clase EquipoFutbol que herede de Equipo.
 *          
 *          iv.	Generar la clase EquipoBasquet que herede de Equipo
 *          
 *      b.	Crear un proyecto del tipo Console:
 *          i.	Crear un programa que genere 2 torneos, uno de Futbol y otro de Basquet.
 *          ii.	Crear 3 equipos de cada tipo.
 *          iii.	Agregar los equipos en tantos torneos como se pueda.
 *          iv.	Llamar al método Mostrar de Torneo e imprimir su retorno por pantalla.
 *          v.	Llamar al menos 3 veces a la propiedad JugarPartido de cada torneo e imprimir su respuesta por pantalla.
 * 
 */

using System.Text;

namespace BibliotecaDeClases
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        public string JugarPartido
        {
            get
            {
                return CalcularPartido(this.equipos[new Random().Next(equipos.Count)], this.equipos[new Random().Next(equipos.Count)]);
            }
        }

        public Torneo(string nombre)
        {
            this.nombre = nombre;
            this.equipos = new List<T>();
        }

        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            //return torneo.equipos.Contains(equipo);  NO SE USA NO SE POR QUEEEEE

            foreach (Equipo e in torneo.equipos)
            {
                if (e == equipo)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        public static bool operator +(Torneo<T> torneo, T equipo)
        {
            if (torneo != equipo)
            {
                torneo.equipos.Add(equipo);
                return true;
            }

            return false;
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Torneo: {this.nombre}");
            retorno.AppendLine("Equipos: ");
            foreach(T equipo in this.equipos )
            {
                retorno.AppendLine(equipo.Ficha());
            }

            return retorno.ToString();
        }

        private string CalcularPartido(T equipo1, T equipo2)
        {
            return $"{equipo1.nombre} {new Random().Next(10)} - {new Random().Next(10)} {equipo2.nombre}";
        }
    }
}