using System.Text;

namespace Biblioteca_Nro_16
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        /// <summary>
        /// Establece la primera y la segunda nota del alumno
        /// </summary>
        /// <param name="notaUno">Puntaje primer nota</param>
        /// <param name="notaDos">Puntaje segunda nota</param>
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        /// <summary>
        /// Coloca una nota final siempre y cuando las nota uno y dos, seas mayores o iguales que 4
        /// </summary>
        public void CalcularFinal()
        {
            if (this.nota1 >= 4 && this.nota2 >= 4)
                this.notaFinal = new Random().Next(1, 10);
            else
                this.notaFinal = -1;
        }

        /// <summary>
        /// arma una cadena de texto con todos los datos del alumno
        /// </summary>
        /// <returns>los datos del alumno</returns>
        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendFormat(" {0, -10} {1, -10}     {2, -10}       {3, -10}    {4, -10}", this.nombre, this.apellido, this.legajo, this.nota1, this.nota2);

            this.CalcularFinal();
            if (this.notaFinal != -1)
                retorno.AppendFormat("{0, 10}", this.notaFinal);
            else
                retorno.Append("Alumno desaprobado");

            return retorno.ToString();
        }
    }
}