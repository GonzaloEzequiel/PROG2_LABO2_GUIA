using BibliotecaDeClases;

namespace ConsolaDeEjecucion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoDeFutbol = new Torneo<EquipoFutbol>("Liga Profesional de Futbol");
            Torneo<EquipoBasquet> torneoDeBasquet = new Torneo<EquipoBasquet>("National Basquet League");

            EquipoFutbol futbol1 = new EquipoFutbol("Racing");
            EquipoFutbol futbol2 = new EquipoFutbol("Boca");
            EquipoFutbol futbol3 = new EquipoFutbol("Tigre");

            EquipoBasquet basquet1 = new EquipoBasquet("Bahia Blanca");
            EquipoBasquet basquet2 = new EquipoBasquet("RacingBasquet");
            EquipoBasquet basquet3 = new EquipoBasquet("SKT T1");

            bool aux;

            aux = torneoDeFutbol + futbol1;
            aux = torneoDeFutbol + futbol2;
            aux = torneoDeFutbol + futbol3;

            aux = torneoDeBasquet + basquet1;
            aux = torneoDeBasquet + basquet2;
            aux = torneoDeBasquet + basquet3;


            Console.WriteLine(torneoDeFutbol.Mostrar());
            for(int i=0; i<3; i++)
            {
                Console.WriteLine(torneoDeFutbol.JugarPartido);
            }

            Console.WriteLine("\n ----------------------------------------------------- \n");

            Console.WriteLine(torneoDeBasquet.Mostrar());
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(torneoDeBasquet.JugarPartido);
            }
        }
    }
}
