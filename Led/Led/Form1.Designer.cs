namespace Led
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.led_Test1 = new Led.Led_Test();
            this.SuspendLayout();
            // 
            // led_Test1
            // 
            this.led_Test1.Colore = System.Drawing.Color.Red;
            this.led_Test1.Dimensione = 10;
            this.led_Test1.Location = new System.Drawing.Point(161, 63);
            this.led_Test1.Name = "led_Test1";
            this.led_Test1.Size = new System.Drawing.Size(11, 11);
            this.led_Test1.TabIndex = 0;
            this.led_Test1.Text = "led_Test1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.led_Test1);
            this.Name = "Form1";
            this.Text = "Window";
            this.ResumeLayout(false);

        }

        #endregion

        private Led_Test led_Test1;
    }
}

