namespace ejemplo2
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.lvElementos = new System.Windows.Forms.ListView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.CheckboxInvAnt = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gBoxInvFav = new System.Windows.Forms.GroupBox();
            this.RadButAcc = new System.Windows.Forms.RadioButton();
            this.RadButBon = new System.Windows.Forms.RadioButton();
            this.RadButFCI = new System.Windows.Forms.RadioButton();
            this.lblColorFav = new System.Windows.Forms.Label();
            this.cBoxColores = new System.Windows.Forms.ComboBox();
            this.nUDEdad = new System.Windows.Forms.NumericUpDown();
            this.lblEdad = new System.Windows.Forms.Label();
            this.ButtonVerPerfil = new System.Windows.Forms.Button();
            this.gBoxInvFav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(421, 376);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtElemento
            // 
            this.txtElemento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtElemento.Location = new System.Drawing.Point(322, 82);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(100, 22);
            this.txtElemento.TabIndex = 1;
            // 
            // lvElementos
            // 
            this.lvElementos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvElementos.HideSelection = false;
            this.lvElementos.Location = new System.Drawing.Point(294, 341);
            this.lvElementos.Name = "lvElementos";
            this.lvElementos.Size = new System.Drawing.Size(121, 97);
            this.lvElementos.TabIndex = 2;
            this.lvElementos.UseCompatibleStateImageBehavior = false;
            this.lvElementos.View = System.Windows.Forms.View.List;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Location = new System.Drawing.Point(322, 110);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 3;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(181, 115);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(135, 16);
            this.lblFechaNac.TabIndex = 4;
            this.lblFechaNac.Text = "Fecha de Nacimiento";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(260, 85);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // CheckboxInvAnt
            // 
            this.CheckboxInvAnt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckboxInvAnt.AutoSize = true;
            this.CheckboxInvAnt.Location = new System.Drawing.Point(280, 298);
            this.CheckboxInvAnt.Name = "CheckboxInvAnt";
            this.CheckboxInvAnt.Size = new System.Drawing.Size(154, 20);
            this.CheckboxInvAnt.TabIndex = 6;
            this.CheckboxInvAnt.Text = "Ya he invertido antes";
            this.CheckboxInvAnt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Perfil de Usuario";
            // 
            // gBoxInvFav
            // 
            this.gBoxInvFav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxInvFav.Controls.Add(this.RadButFCI);
            this.gBoxInvFav.Controls.Add(this.RadButBon);
            this.gBoxInvFav.Controls.Add(this.RadButAcc);
            this.gBoxInvFav.Location = new System.Drawing.Point(51, 138);
            this.gBoxInvFav.Name = "gBoxInvFav";
            this.gBoxInvFav.Size = new System.Drawing.Size(672, 130);
            this.gBoxInvFav.TabIndex = 8;
            this.gBoxInvFav.TabStop = false;
            this.gBoxInvFav.Text = "Inversión favorita";
            // 
            // RadButAcc
            // 
            this.RadButAcc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadButAcc.AutoSize = true;
            this.RadButAcc.Location = new System.Drawing.Point(20, 47);
            this.RadButAcc.Name = "RadButAcc";
            this.RadButAcc.Size = new System.Drawing.Size(84, 20);
            this.RadButAcc.TabIndex = 0;
            this.RadButAcc.TabStop = true;
            this.RadButAcc.Text = "Acciones";
            this.RadButAcc.UseVisualStyleBackColor = true;
            // 
            // RadButBon
            // 
            this.RadButBon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadButBon.AutoSize = true;
            this.RadButBon.Location = new System.Drawing.Point(280, 47);
            this.RadButBon.Name = "RadButBon";
            this.RadButBon.Size = new System.Drawing.Size(67, 20);
            this.RadButBon.TabIndex = 1;
            this.RadButBon.TabStop = true;
            this.RadButBon.Text = "Bonos";
            this.RadButBon.UseVisualStyleBackColor = true;
            this.RadButBon.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // RadButFCI
            // 
            this.RadButFCI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadButFCI.AutoSize = true;
            this.RadButFCI.Location = new System.Drawing.Point(510, 47);
            this.RadButFCI.Name = "RadButFCI";
            this.RadButFCI.Size = new System.Drawing.Size(58, 20);
            this.RadButFCI.TabIndex = 2;
            this.RadButFCI.TabStop = true;
            this.RadButFCI.Text = "FCI\'s";
            this.RadButFCI.UseVisualStyleBackColor = true;
            // 
            // lblColorFav
            // 
            this.lblColorFav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColorFav.AutoSize = true;
            this.lblColorFav.Location = new System.Drawing.Point(211, 275);
            this.lblColorFav.Name = "lblColorFav";
            this.lblColorFav.Size = new System.Drawing.Size(94, 16);
            this.lblColorFav.TabIndex = 9;
            this.lblColorFav.Text = "Color Favorito:";
            // 
            // cBoxColores
            // 
            this.cBoxColores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cBoxColores.FormattingEnabled = true;
            this.cBoxColores.Location = new System.Drawing.Point(313, 274);
            this.cBoxColores.Name = "cBoxColores";
            this.cBoxColores.Size = new System.Drawing.Size(121, 24);
            this.cBoxColores.TabIndex = 10;
            // 
            // nUDEdad
            // 
            this.nUDEdad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nUDEdad.Location = new System.Drawing.Point(322, 319);
            this.nUDEdad.Name = "nUDEdad";
            this.nUDEdad.Size = new System.Drawing.Size(120, 22);
            this.nUDEdad.TabIndex = 11;
            // 
            // lblEdad
            // 
            this.lblEdad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(273, 321);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(43, 16);
            this.lblEdad.TabIndex = 12;
            this.lblEdad.Text = "Edad:";
            // 
            // ButtonVerPerfil
            // 
            this.ButtonVerPerfil.Location = new System.Drawing.Point(71, 313);
            this.ButtonVerPerfil.Name = "ButtonVerPerfil";
            this.ButtonVerPerfil.Size = new System.Drawing.Size(75, 23);
            this.ButtonVerPerfil.TabIndex = 13;
            this.ButtonVerPerfil.Text = "Ver Perfil";
            this.ButtonVerPerfil.UseVisualStyleBackColor = true;
            this.ButtonVerPerfil.Click += new System.EventHandler(this.ButtonVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonVerPerfil);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.nUDEdad);
            this.Controls.Add(this.cBoxColores);
            this.Controls.Add(this.lblColorFav);
            this.Controls.Add(this.gBoxInvFav);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckboxInvAnt);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lvElementos);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBoxInvFav.ResumeLayout(false);
            this.gBoxInvFav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.ListView lvElementos;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.CheckBox CheckboxInvAnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBoxInvFav;
        private System.Windows.Forms.RadioButton RadButFCI;
        private System.Windows.Forms.RadioButton RadButBon;
        private System.Windows.Forms.RadioButton RadButAcc;
        private System.Windows.Forms.Label lblColorFav;
        private System.Windows.Forms.ComboBox cBoxColores;
        private System.Windows.Forms.NumericUpDown nUDEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Button ButtonVerPerfil;
    }
}

