using System.Text;

namespace Biblioteca_Nro_17
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        /// <summary>
        /// getter del atributo color de la instancia
        /// </summary>
        /// <returns>el color del bolígrafo</returns>
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        /// <summary>
        /// getter del atributo tinta de la instancia
        /// </summary>
        /// <returns>la cantidad de tinta restante del bolígrafo</returns>
        public short GetTinta()
        {
            return this.tinta;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gasto"></param>
        /// <param name="dibujo"></param>
        /// <returns></returns>
        public bool Pintar(short gasto, out string dibujo)
        {
            StringBuilder dibujando = new StringBuilder();

            Console.BackgroundColor = this.color;
            for (int i = 0; this.tinta - gasto > 0 ? i < gasto : i < this.tinta; i++)
            {
                //dibujando.Append(i+1);
                dibujando.Append('*');             
            }

            this.SetTinta((short)(0 - gasto));

            dibujo = dibujando.ToString();

            if(gasto <= this.tinta)
            {
                Console.WriteLine($"Se pudo pintar todo ({gasto})");
                return true;
            }
            else
            {
                Console.WriteLine($"No se pudo pintar todo ({gasto})");
                return false;
            }
        }

        /// <summary>
        /// Recarga al bolígrafo a su máximo de tinta
        /// </summary>
        public void Recargar()
        {
            this.SetTinta((short)(Boligrafo.cantidadTintaMaxima - this.tinta));
        }

        /// <summary>
        /// Establece la cantidad de tinta del bolígrafo, tanto para cuando se carga como cuando se usa
        /// </summary>
        /// <param name="tinta">cantindad de tinta en cuestión</param>
        private void SetTinta(short tinta)
        {
            this.tinta += tinta;

            if (this.tinta > 100)
                this.tinta = 100;

            if (this.tinta < 0)
                this.tinta = 0;
        }
    }
}