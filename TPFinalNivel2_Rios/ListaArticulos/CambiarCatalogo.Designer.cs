namespace ListaArticulos
{
    partial class CambiarCatalogoFRM
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
            this.codigoArtLBL = new System.Windows.Forms.Label();
            this.descripcionLBL = new System.Windows.Forms.Label();
            this.marcaLBL = new System.Windows.Forms.Label();
            this.nombreLBL = new System.Windows.Forms.Label();
            this.categoriaLBL = new System.Windows.Forms.Label();
            this.precioLBL = new System.Windows.Forms.Label();
            this.imagenPBOX = new System.Windows.Forms.PictureBox();
            this.marcaCBOX = new System.Windows.Forms.ComboBox();
            this.categoriaCBOX = new System.Windows.Forms.ComboBox();
            this.cargarImagenLBL = new System.Windows.Forms.Label();
            this.aceptarBTN = new System.Windows.Forms.Button();
            this.cancelarBTN = new System.Windows.Forms.Button();
            this.codigoArtTXTB = new System.Windows.Forms.TextBox();
            this.nombreTXTB = new System.Windows.Forms.TextBox();
            this.descripcionTXTB = new System.Windows.Forms.TextBox();
            this.imagenTXTB = new System.Windows.Forms.TextBox();
            this.precioTXTB = new System.Windows.Forms.TextBox();
            this.importarBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPBOX)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoArtLBL
            // 
            this.codigoArtLBL.AutoSize = true;
            this.codigoArtLBL.Location = new System.Drawing.Point(12, 63);
            this.codigoArtLBL.Name = "codigoArtLBL";
            this.codigoArtLBL.Size = new System.Drawing.Size(116, 16);
            this.codigoArtLBL.TabIndex = 0;
            this.codigoArtLBL.Text = "Código de artículo";
            // 
            // descripcionLBL
            // 
            this.descripcionLBL.AutoSize = true;
            this.descripcionLBL.Location = new System.Drawing.Point(49, 142);
            this.descripcionLBL.Name = "descripcionLBL";
            this.descripcionLBL.Size = new System.Drawing.Size(79, 16);
            this.descripcionLBL.TabIndex = 1;
            this.descripcionLBL.Text = "Descripción";
            // 
            // marcaLBL
            // 
            this.marcaLBL.AutoSize = true;
            this.marcaLBL.Location = new System.Drawing.Point(83, 180);
            this.marcaLBL.Name = "marcaLBL";
            this.marcaLBL.Size = new System.Drawing.Size(45, 16);
            this.marcaLBL.TabIndex = 2;
            this.marcaLBL.Text = "Marca";
            // 
            // nombreLBL
            // 
            this.nombreLBL.AutoSize = true;
            this.nombreLBL.Location = new System.Drawing.Point(72, 101);
            this.nombreLBL.Name = "nombreLBL";
            this.nombreLBL.Size = new System.Drawing.Size(56, 16);
            this.nombreLBL.TabIndex = 3;
            this.nombreLBL.Text = "Nombre";
            // 
            // categoriaLBL
            // 
            this.categoriaLBL.AutoSize = true;
            this.categoriaLBL.Location = new System.Drawing.Point(62, 218);
            this.categoriaLBL.Name = "categoriaLBL";
            this.categoriaLBL.Size = new System.Drawing.Size(66, 16);
            this.categoriaLBL.TabIndex = 4;
            this.categoriaLBL.Text = "Categoría";
            // 
            // precioLBL
            // 
            this.precioLBL.AutoSize = true;
            this.precioLBL.Location = new System.Drawing.Point(82, 311);
            this.precioLBL.Name = "precioLBL";
            this.precioLBL.Size = new System.Drawing.Size(46, 16);
            this.precioLBL.TabIndex = 5;
            this.precioLBL.Text = "Precio";
            // 
            // imagenPBOX
            // 
            this.imagenPBOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagenPBOX.Location = new System.Drawing.Point(383, 12);
            this.imagenPBOX.Name = "imagenPBOX";
            this.imagenPBOX.Size = new System.Drawing.Size(476, 467);
            this.imagenPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenPBOX.TabIndex = 6;
            this.imagenPBOX.TabStop = false;
            this.imagenPBOX.Click += new System.EventHandler(this.imagenPBOX_Click);
            // 
            // marcaCBOX
            // 
            this.marcaCBOX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marcaCBOX.FormattingEnabled = true;
            this.marcaCBOX.Location = new System.Drawing.Point(134, 177);
            this.marcaCBOX.Name = "marcaCBOX";
            this.marcaCBOX.Size = new System.Drawing.Size(214, 24);
            this.marcaCBOX.TabIndex = 3;
            // 
            // categoriaCBOX
            // 
            this.categoriaCBOX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaCBOX.FormattingEnabled = true;
            this.categoriaCBOX.Location = new System.Drawing.Point(134, 215);
            this.categoriaCBOX.Name = "categoriaCBOX";
            this.categoriaCBOX.Size = new System.Drawing.Size(214, 24);
            this.categoriaCBOX.TabIndex = 4;
            // 
            // cargarImagenLBL
            // 
            this.cargarImagenLBL.AutoSize = true;
            this.cargarImagenLBL.Location = new System.Drawing.Point(32, 258);
            this.cargarImagenLBL.Name = "cargarImagenLBL";
            this.cargarImagenLBL.Size = new System.Drawing.Size(96, 16);
            this.cargarImagenLBL.TabIndex = 9;
            this.cargarImagenLBL.Text = "Cargar Imagen";
            // 
            // aceptarBTN
            // 
            this.aceptarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptarBTN.Location = new System.Drawing.Point(40, 357);
            this.aceptarBTN.Name = "aceptarBTN";
            this.aceptarBTN.Size = new System.Drawing.Size(120, 50);
            this.aceptarBTN.TabIndex = 7;
            this.aceptarBTN.Text = "Aceptar";
            this.aceptarBTN.UseVisualStyleBackColor = true;
            this.aceptarBTN.Click += new System.EventHandler(this.aceptarBTN_Click);
            this.aceptarBTN.MouseLeave += new System.EventHandler(this.aceptarBTN_MouseLeave);
            this.aceptarBTN.MouseMove += new System.Windows.Forms.MouseEventHandler(this.aceptarBTN_MouseMove);
            // 
            // cancelarBTN
            // 
            this.cancelarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarBTN.Location = new System.Drawing.Point(228, 357);
            this.cancelarBTN.Name = "cancelarBTN";
            this.cancelarBTN.Size = new System.Drawing.Size(120, 50);
            this.cancelarBTN.TabIndex = 8;
            this.cancelarBTN.Text = "Cancelar";
            this.cancelarBTN.UseVisualStyleBackColor = true;
            this.cancelarBTN.Click += new System.EventHandler(this.cancelarBTN_Click);
            this.cancelarBTN.MouseLeave += new System.EventHandler(this.cancelarBTN_MouseLeave);
            this.cancelarBTN.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cancelarBTN_MouseMove);
            // 
            // codigoArtTXTB
            // 
            this.codigoArtTXTB.Location = new System.Drawing.Point(135, 61);
            this.codigoArtTXTB.Name = "codigoArtTXTB";
            this.codigoArtTXTB.Size = new System.Drawing.Size(213, 22);
            this.codigoArtTXTB.TabIndex = 0;
            // 
            // nombreTXTB
            // 
            this.nombreTXTB.Location = new System.Drawing.Point(134, 99);
            this.nombreTXTB.Name = "nombreTXTB";
            this.nombreTXTB.Size = new System.Drawing.Size(214, 22);
            this.nombreTXTB.TabIndex = 1;
            // 
            // descripcionTXTB
            // 
            this.descripcionTXTB.Location = new System.Drawing.Point(134, 140);
            this.descripcionTXTB.Name = "descripcionTXTB";
            this.descripcionTXTB.Size = new System.Drawing.Size(214, 22);
            this.descripcionTXTB.TabIndex = 2;
            // 
            // imagenTXTB
            // 
            this.imagenTXTB.Location = new System.Drawing.Point(134, 256);
            this.imagenTXTB.Name = "imagenTXTB";
            this.imagenTXTB.Size = new System.Drawing.Size(214, 22);
            this.imagenTXTB.TabIndex = 5;
            this.imagenTXTB.Leave += new System.EventHandler(this.imagenTXTB_Leave);
            // 
            // precioTXTB
            // 
            this.precioTXTB.Location = new System.Drawing.Point(134, 309);
            this.precioTXTB.Name = "precioTXTB";
            this.precioTXTB.Size = new System.Drawing.Size(214, 22);
            this.precioTXTB.TabIndex = 6;
            this.precioTXTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precioTXTB_KeyPress);
            // 
            // importarBTN
            // 
            this.importarBTN.Location = new System.Drawing.Point(273, 280);
            this.importarBTN.Name = "importarBTN";
            this.importarBTN.Size = new System.Drawing.Size(75, 23);
            this.importarBTN.TabIndex = 10;
            this.importarBTN.Text = "Importar";
            this.importarBTN.UseVisualStyleBackColor = true;
            this.importarBTN.Click += new System.EventHandler(this.importarBTN_Click);
            // 
            // CambiarCatalogoFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 491);
            this.Controls.Add(this.importarBTN);
            this.Controls.Add(this.precioTXTB);
            this.Controls.Add(this.imagenTXTB);
            this.Controls.Add(this.descripcionTXTB);
            this.Controls.Add(this.nombreTXTB);
            this.Controls.Add(this.codigoArtTXTB);
            this.Controls.Add(this.cancelarBTN);
            this.Controls.Add(this.aceptarBTN);
            this.Controls.Add(this.cargarImagenLBL);
            this.Controls.Add(this.categoriaCBOX);
            this.Controls.Add(this.marcaCBOX);
            this.Controls.Add(this.imagenPBOX);
            this.Controls.Add(this.precioLBL);
            this.Controls.Add(this.categoriaLBL);
            this.Controls.Add(this.nombreLBL);
            this.Controls.Add(this.marcaLBL);
            this.Controls.Add(this.descripcionLBL);
            this.Controls.Add(this.codigoArtLBL);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(910, 538);
            this.MinimumSize = new System.Drawing.Size(910, 538);
            this.Name = "CambiarCatalogoFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Catálogo";
            this.Load += new System.EventHandler(this.CambiarCatalogoFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenPBOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codigoArtLBL;
        private System.Windows.Forms.Label descripcionLBL;
        private System.Windows.Forms.Label marcaLBL;
        private System.Windows.Forms.Label nombreLBL;
        private System.Windows.Forms.Label categoriaLBL;
        private System.Windows.Forms.Label precioLBL;
        private System.Windows.Forms.PictureBox imagenPBOX;
        private System.Windows.Forms.ComboBox marcaCBOX;
        private System.Windows.Forms.ComboBox categoriaCBOX;
        private System.Windows.Forms.Label cargarImagenLBL;
        private System.Windows.Forms.Button aceptarBTN;
        private System.Windows.Forms.Button cancelarBTN;
        private System.Windows.Forms.TextBox codigoArtTXTB;
        private System.Windows.Forms.TextBox nombreTXTB;
        private System.Windows.Forms.TextBox descripcionTXTB;
        private System.Windows.Forms.TextBox imagenTXTB;
        private System.Windows.Forms.TextBox precioTXTB;
        private System.Windows.Forms.Button importarBTN;
    }
}