namespace WinFormActs
{
    partial class practicaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(practicaForm));
            this.label1 = new System.Windows.Forms.Label();
            this.boton1 = new System.Windows.Forms.Button();
            this.soyuntextoLBL = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(147, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // boton1
            // 
            this.boton1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.boton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boton1.Image = ((System.Drawing.Image)(resources.GetObject("boton1.Image")));
            this.boton1.Location = new System.Drawing.Point(594, 134);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(107, 61);
            this.boton1.TabIndex = 1;
            this.boton1.Text = "Presionar";
            this.boton1.UseVisualStyleBackColor = false;
            this.boton1.Click += new System.EventHandler(this.boton1_Click_1);
            // 
            // soyuntextoLBL
            // 
            this.soyuntextoLBL.AutoSize = true;
            this.soyuntextoLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.soyuntextoLBL.Font = new System.Drawing.Font("Microsoft YaHei", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soyuntextoLBL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.soyuntextoLBL.Location = new System.Drawing.Point(150, 197);
            this.soyuntextoLBL.Name = "soyuntextoLBL";
            this.soyuntextoLBL.Size = new System.Drawing.Size(287, 59);
            this.soyuntextoLBL.TabIndex = 2;
            this.soyuntextoLBL.Text = "Soy un texto";
            this.soyuntextoLBL.Click += new System.EventHandler(this.soyuntextoLBL_Click);
            this.soyuntextoLBL.MouseLeave += new System.EventHandler(this.soyuntextoLBL_MouseLeave);
            this.soyuntextoLBL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.soyuntextoLBL_MouseMove);
            // 
            // txtBox
            // 
            this.txtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBox.Location = new System.Drawing.Point(594, 43);
            this.txtBox.MaxLength = 128;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(100, 22);
            this.txtBox.TabIndex = 3;
            this.txtBox.Click += new System.EventHandler(this.txtBox_Click);
            this.txtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // textbox2
            // 
            this.textbox2.Location = new System.Drawing.Point(897, 64);
            this.textbox2.Multiline = true;
            this.textbox2.Name = "textbox2";
            this.textbox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox2.Size = new System.Drawing.Size(100, 22);
            this.textbox2.TabIndex = 4;
            this.textbox2.Leave += new System.EventHandler(this.textbox2_Leave);
            // 
            // practicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1329, 606);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.soyuntextoLBL);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "practicaForm";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrácticaU4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.practicaForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.practicaForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Label soyuntextoLBL;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.TextBox textbox2;
    }
}

