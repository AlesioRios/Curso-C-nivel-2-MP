namespace pruebaDateTime
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
            this.calendarioMC = new System.Windows.Forms.MonthCalendar();
            this.fechaDTP = new System.Windows.Forms.DateTimePicker();
            this.fechaBTN = new System.Windows.Forms.Button();
            this.calendarioBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calendarioMC
            // 
            this.calendarioMC.Location = new System.Drawing.Point(226, 180);
            this.calendarioMC.Name = "calendarioMC";
            this.calendarioMC.TabIndex = 0;
            // 
            // fechaDTP
            // 
            this.fechaDTP.Location = new System.Drawing.Point(248, 117);
            this.fechaDTP.Name = "fechaDTP";
            this.fechaDTP.Size = new System.Drawing.Size(200, 22);
            this.fechaDTP.TabIndex = 1;
            // 
            // fechaBTN
            // 
            this.fechaBTN.Location = new System.Drawing.Point(501, 116);
            this.fechaBTN.Name = "fechaBTN";
            this.fechaBTN.Size = new System.Drawing.Size(75, 23);
            this.fechaBTN.TabIndex = 2;
            this.fechaBTN.Text = "Fecha";
            this.fechaBTN.UseVisualStyleBackColor = true;
            this.fechaBTN.Click += new System.EventHandler(this.fechaBTN_Click);
            // 
            // calendarioBTN
            // 
            this.calendarioBTN.Location = new System.Drawing.Point(500, 225);
            this.calendarioBTN.Name = "calendarioBTN";
            this.calendarioBTN.Size = new System.Drawing.Size(87, 23);
            this.calendarioBTN.TabIndex = 3;
            this.calendarioBTN.Text = "Calendario";
            this.calendarioBTN.UseVisualStyleBackColor = true;
            this.calendarioBTN.Click += new System.EventHandler(this.calendarioBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calendarioBTN);
            this.Controls.Add(this.fechaBTN);
            this.Controls.Add(this.fechaDTP);
            this.Controls.Add(this.calendarioMC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendarioMC;
        private System.Windows.Forms.DateTimePicker fechaDTP;
        private System.Windows.Forms.Button fechaBTN;
        private System.Windows.Forms.Button calendarioBTN;
    }
}

