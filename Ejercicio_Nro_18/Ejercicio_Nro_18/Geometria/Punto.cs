namespace Geometria
{
    public class Punto
    {
        private int x;
        private int y;

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// getter del atributo x
        /// </summary>
        /// <returns></returns>
        public int GetX()
        {
            return this.x;
        }

        /// <summary>
        /// getter del atributo y
        /// </summary>
        /// <returns></returns>
        public int GetY()
        {
            return this.y;
        }
    }
}