namespace ejemplo2
{
    partial class EFICH
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EFICH));
            this.EFICHlbl = new System.Windows.Forms.Label();
            this.ingresarBTN = new System.Windows.Forms.Button();
            this.NombreTXTB = new System.Windows.Forms.TextBox();
            this.fechaDTP = new System.Windows.Forms.DateTimePicker();
            this.nombreLBL = new System.Windows.Forms.Label();
            this.dniLBL = new System.Windows.Forms.Label();
            this.dniTXTB = new System.Windows.Forms.TextBox();
            this.passwordLBL = new System.Windows.Forms.Label();
            this.passwordTXTB = new System.Windows.Forms.TextBox();
            this.fechaLBL = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pabloNovara = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pabloNovara)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EFICHlbl
            // 
            this.EFICHlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EFICHlbl.AutoSize = true;
            this.EFICHlbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EFICHlbl.Location = new System.Drawing.Point(304, -13);
            this.EFICHlbl.Name = "EFICHlbl";
            this.EFICHlbl.Size = new System.Drawing.Size(151, 46);
            this.EFICHlbl.TabIndex = 0;
            this.EFICHlbl.Text = "E-FICH";
            // 
            // ingresarBTN
            // 
            this.ingresarBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresarBTN.Location = new System.Drawing.Point(312, 263);
            this.ingresarBTN.Name = "ingresarBTN";
            this.ingresarBTN.Size = new System.Drawing.Size(75, 23);
            this.ingresarBTN.TabIndex = 4;
            this.ingresarBTN.Text = "&Ingresar";
            this.ingresarBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ingresarBTN.UseVisualStyleBackColor = true;
            this.ingresarBTN.Click += new System.EventHandler(this.ingresarBTN_Click);
            // 
            // NombreTXTB
            // 
            this.NombreTXTB.Location = new System.Drawing.Point(312, 64);
            this.NombreTXTB.Name = "NombreTXTB";
            this.NombreTXTB.Size = new System.Drawing.Size(167, 22);
            this.NombreTXTB.TabIndex = 0;
            // 
            // fechaDTP
            // 
            this.fechaDTP.Location = new System.Drawing.Point(312, 182);
            this.fechaDTP.Name = "fechaDTP";
            this.fechaDTP.Size = new System.Drawing.Size(200, 22);
            this.fechaDTP.TabIndex = 3;
            // 
            // nombreLBL
            // 
            this.nombreLBL.AutoSize = true;
            this.nombreLBL.Location = new System.Drawing.Point(252, 67);
            this.nombreLBL.Name = "nombreLBL";
            this.nombreLBL.Size = new System.Drawing.Size(59, 16);
            this.nombreLBL.TabIndex = 4;
            this.nombreLBL.Text = "Nombre:";
            // 
            // dniLBL
            // 
            this.dniLBL.AutoSize = true;
            this.dniLBL.Location = new System.Drawing.Point(263, 110);
            this.dniLBL.Name = "dniLBL";
            this.dniLBL.Size = new System.Drawing.Size(33, 16);
            this.dniLBL.TabIndex = 5;
            this.dniLBL.Text = "DNI:";
            this.dniLBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // dniTXTB
            // 
            this.dniTXTB.Location = new System.Drawing.Point(312, 104);
            this.dniTXTB.Name = "dniTXTB";
            this.dniTXTB.Size = new System.Drawing.Size(167, 22);
            this.dniTXTB.TabIndex = 1;
            // 
            // passwordLBL
            // 
            this.passwordLBL.AutoSize = true;
            this.passwordLBL.Location = new System.Drawing.Point(232, 144);
            this.passwordLBL.Name = "passwordLBL";
            this.passwordLBL.Size = new System.Drawing.Size(79, 16);
            this.passwordLBL.TabIndex = 7;
            this.passwordLBL.Text = "Contraseña:";
            // 
            // passwordTXTB
            // 
            this.passwordTXTB.Location = new System.Drawing.Point(312, 144);
            this.passwordTXTB.Name = "passwordTXTB";
            this.passwordTXTB.Size = new System.Drawing.Size(167, 22);
            this.passwordTXTB.TabIndex = 2;
            // 
            // fechaLBL
            // 
            this.fechaLBL.AutoSize = true;
            this.fechaLBL.Location = new System.Drawing.Point(173, 182);
            this.fechaLBL.Name = "fechaLBL";
            this.fechaLBL.Size = new System.Drawing.Size(138, 16);
            this.fechaLBL.TabIndex = 9;
            this.fechaLBL.Text = "Fecha de Nacimiento:";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ImagenDePrueba.png");
            // 
            // pabloNovara
            // 
            this.pabloNovara.Image = ((System.Drawing.Image)(resources.GetObject("pabloNovara.Image")));
            this.pabloNovara.Location = new System.Drawing.Point(565, 45);
            this.pabloNovara.Name = "pabloNovara";
            this.pabloNovara.Size = new System.Drawing.Size(149, 159);
            this.pabloNovara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pabloNovara.TabIndex = 10;
            this.pabloNovara.TabStop = false;
            this.pabloNovara.Click += new System.EventHandler(this.pabloNovara_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.formatoToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(805, 27);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.formatoToolStripMenuItem.Text = "Formato";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(111, 24);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 380);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(805, 26);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.perfilToolStripMenuItem.Text = "Perfil del inversor";
            this.perfilToolStripMenuItem.Click += new System.EventHandler(this.perfilToolStripMenuItem_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.abrirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // EFICH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(805, 406);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pabloNovara);
            this.Controls.Add(this.fechaLBL);
            this.Controls.Add(this.passwordTXTB);
            this.Controls.Add(this.passwordLBL);
            this.Controls.Add(this.dniTXTB);
            this.Controls.Add(this.dniLBL);
            this.Controls.Add(this.nombreLBL);
            this.Controls.Add(this.fechaDTP);
            this.Controls.Add(this.NombreTXTB);
            this.Controls.Add(this.ingresarBTN);
            this.Controls.Add(this.EFICHlbl);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EFICH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-FICH";
            this.Load += new System.EventHandler(this.EFICH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pabloNovara)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EFICHlbl;
        private System.Windows.Forms.Button ingresarBTN;
        private System.Windows.Forms.TextBox NombreTXTB;
        private System.Windows.Forms.DateTimePicker fechaDTP;
        private System.Windows.Forms.Label nombreLBL;
        private System.Windows.Forms.Label dniLBL;
        private System.Windows.Forms.TextBox dniTXTB;
        private System.Windows.Forms.Label passwordLBL;
        private System.Windows.Forms.TextBox passwordTXTB;
        private System.Windows.Forms.Label fechaLBL;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pabloNovara;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
    }
}