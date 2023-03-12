namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnGato = new System.Windows.Forms.Button();
            this.btnPerro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.Location = new System.Drawing.Point(431, 170);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(234, 169);
            this.lblResultado.TabIndex = 5;
            // 
            // btnGato
            // 
            this.btnGato.Location = new System.Drawing.Point(136, 155);
            this.btnGato.Name = "btnGato";
            this.btnGato.Size = new System.Drawing.Size(77, 43);
            this.btnGato.TabIndex = 4;
            this.btnGato.Text = "Gato";
            this.btnGato.UseVisualStyleBackColor = true;
            this.btnGato.Click += new System.EventHandler(this.btnGato_Click_1);
            // 
            // btnPerro
            // 
            this.btnPerro.Location = new System.Drawing.Point(138, 111);
            this.btnPerro.Name = "btnPerro";
            this.btnPerro.Size = new System.Drawing.Size(75, 29);
            this.btnPerro.TabIndex = 3;
            this.btnPerro.Text = "Perro";
            this.btnPerro.UseVisualStyleBackColor = true;
            this.btnPerro.Click += new System.EventHandler(this.btnPerro_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnGato);
            this.Controls.Add(this.btnPerro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblResultado;
        internal System.Windows.Forms.Button btnGato;
        internal System.Windows.Forms.Button btnPerro;
    }
}

