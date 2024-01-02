namespace Ejercicio_Nro_63
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHora = new Label();
            rtbCuadro = new RichTextBox();
            btnParar = new Button();
            SuspendLayout();
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(15, 12);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(38, 15);
            lblHora.TabIndex = 0;
            lblHora.Text = "label1";
            // 
            // rtbCuadro
            // 
            rtbCuadro.Location = new Point(12, 39);
            rtbCuadro.Name = "rtbCuadro";
            rtbCuadro.Size = new Size(359, 346);
            rtbCuadro.TabIndex = 1;
            rtbCuadro.Text = "";
            // 
            // btnParar
            // 
            btnParar.Location = new Point(296, 8);
            btnParar.Name = "btnParar";
            btnParar.Size = new Size(75, 23);
            btnParar.TabIndex = 2;
            btnParar.Text = "Parar Reloj";
            btnParar.UseVisualStyleBackColor = true;
            btnParar.Click += btnParar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 397);
            Controls.Add(btnParar);
            Controls.Add(rtbCuadro);
            Controls.Add(lblHora);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHora;
        private RichTextBox rtbCuadro;
        private Button btnParar;
    }
}