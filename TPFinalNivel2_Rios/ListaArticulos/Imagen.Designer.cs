namespace ListaArticulos
{
    partial class ImagenFRM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imagenPBOX = new System.Windows.Forms.PictureBox();
            this.cerrarImgBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPBOX)).BeginInit();
            this.SuspendLayout();
            // 
            // imagenPBOX
            // 
            this.imagenPBOX.Location = new System.Drawing.Point(0, 0);
            this.imagenPBOX.Name = "imagenPBOX";
            this.imagenPBOX.Size = new System.Drawing.Size(600, 600);
            this.imagenPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenPBOX.TabIndex = 0;
            this.imagenPBOX.TabStop = false;
            // 
            // cerrarImgBTN
            // 
            this.cerrarImgBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarImgBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarImgBTN.Location = new System.Drawing.Point(545, 0);
            this.cerrarImgBTN.Name = "cerrarImgBTN";
            this.cerrarImgBTN.Size = new System.Drawing.Size(55, 55);
            this.cerrarImgBTN.TabIndex = 1;
            this.cerrarImgBTN.Text = "X";
            this.cerrarImgBTN.UseVisualStyleBackColor = true;
            this.cerrarImgBTN.Click += new System.EventHandler(this.cerrarImgBTN_Click_1);
            this.cerrarImgBTN.MouseLeave += new System.EventHandler(this.cerrarImgBTN_MouseLeave_1);
            this.cerrarImgBTN.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cerrarImgBTN_MouseMove);
            // 
            // ImagenFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.cerrarImgBTN);
            this.Controls.Add(this.imagenPBOX);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImagenFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imagen";
            ((System.ComponentModel.ISupportInitialize)(this.imagenPBOX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagenPBOX;
        private System.Windows.Forms.Button cerrarImgBTN;
    }
}