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
            this.MatrixLed = new System.Windows.Forms.Panel();
            this.ResetBTN = new System.Windows.Forms.Button();
            this.NumbersBox = new System.Windows.Forms.FlowLayoutPanel();
            this.led_Test1 = new Led.Led_Test();
            this.matriceLed1 = new Led.MatriceLed();
            this.SuspendLayout();
            // 
            // MatrixLed
            // 
            this.MatrixLed.AutoSize = true;
            this.MatrixLed.Location = new System.Drawing.Point(307, 24);
            this.MatrixLed.Name = "MatrixLed";
            this.MatrixLed.Size = new System.Drawing.Size(222, 305);
            this.MatrixLed.TabIndex = 1;
            // 
            // ResetBTN
            // 
            this.ResetBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ResetBTN.Location = new System.Drawing.Point(0, 300);
            this.ResetBTN.Name = "ResetBTN";
            this.ResetBTN.Size = new System.Drawing.Size(105, 43);
            this.ResetBTN.TabIndex = 4;
            this.ResetBTN.Text = "Reset";
            this.ResetBTN.UseVisualStyleBackColor = true;
            this.ResetBTN.Click += new System.EventHandler(this.Reset_Clicked);
            // 
            // NumbersBox
            // 
            this.NumbersBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NumbersBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NumbersBox.Location = new System.Drawing.Point(0, 386);
            this.NumbersBox.Name = "NumbersBox";
            this.NumbersBox.Size = new System.Drawing.Size(834, 103);
            this.NumbersBox.TabIndex = 5;
            // 
            // led_Test1
            // 
            this.led_Test1.Colore = System.Drawing.Color.Red;
            this.led_Test1.Dimensione = 10;
            this.led_Test1.Location = new System.Drawing.Point(148, 12);
            this.led_Test1.Name = "led_Test1";
            this.led_Test1.Size = new System.Drawing.Size(11, 11);
            this.led_Test1.TabIndex = 0;
            this.led_Test1.Text = "led_Test1";
            // 
            // matriceLed1
            // 
            this.matriceLed1.Location = new System.Drawing.Point(64, 130);
            this.matriceLed1.MatrixHeight = 5;
            this.matriceLed1.MatrixWidth = 5;
            this.matriceLed1.Name = "matriceLed1";
            this.matriceLed1.Size = new System.Drawing.Size(150, 150);
            this.matriceLed1.TabIndex = 6;
            this.matriceLed1.Text = "matriceLed1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 489);
            this.Controls.Add(this.matriceLed1);
            this.Controls.Add(this.NumbersBox);
            this.Controls.Add(this.ResetBTN);
            this.Controls.Add(this.MatrixLed);
            this.Controls.Add(this.led_Test1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Led_Test led_Test1;
        private System.Windows.Forms.Panel MatrixLed;
        private System.Windows.Forms.Button ResetBTN;
        private System.Windows.Forms.FlowLayoutPanel NumbersBox;
        private MatriceLed matriceLed1;
    }
}

