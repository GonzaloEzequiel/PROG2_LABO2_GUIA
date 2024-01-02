/*
 *  Ejercicio Nro 63	
 *  
 *  Crear un proyecto de formularios con un RichTextBox y un Label dentro.
 *      a.	Crear el m�todo AsignarHora que se encargar� de imprimir la hora en la Label lblHora.
 *      b.	En el Label se deber� mostrar la fecha y hora actual, con segundos incluidos, y refresc�ndose una vez por segundo.
 *      c.	Generar tres pr�cticas, independientes, en el orden planteado:
 *          i.	Realizar la actualizaci�n de la hora 1 vez por segundo utilizando alguna estructura de control dada en clase.
 *          ii.	Agregar un objeto del tipo Timer para refrescar la hora actual cada 1 segundo.
 *          iii.	Resolver el mismo ejercicio con Tasks.
 *          
 */

namespace Ejercicio_Nro_63
{
    public partial class Form1 : Form
    {
        CancellationTokenSource cancellation;

        public Form1()
        {
            InitializeComponent();
            this.cancellation = new CancellationTokenSource();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarReloj();            
        }


        private void MostrarReloj()
        {
            CancellationToken token = cancellation.Token;

            Task.Run(() =>
            {

                do
                {
                    AsignarHora();
                    Thread.Sleep(1000);
                }
                while (!this.cancellation.IsCancellationRequested);

            }, token);
        }

        private void AsignarHora()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(() => AsignarHora());
            }
            else
            {
                this.lblHora.Text = DateTime.Now.ToString();
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            this.cancellation.Cancel();
        }
    }
}