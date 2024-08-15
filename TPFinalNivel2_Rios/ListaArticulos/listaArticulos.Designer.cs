namespace ListaArticulos
{
    partial class listaArticulosFRM
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
            this.listaArticulosDGV = new System.Windows.Forms.DataGridView();
            this.imagenArticuloPBOX = new System.Windows.Forms.PictureBox();
            this.agregarBTN = new System.Windows.Forms.Button();
            this.eliminarBTN = new System.Windows.Forms.Button();
            this.modificarBTN = new System.Windows.Forms.Button();
            this.buscarTXTB = new System.Windows.Forms.TextBox();
            this.filtroAvanBTN = new System.Windows.Forms.Button();
            this.catalogoLBL = new System.Windows.Forms.Label();
            this.ayudaBTN = new System.Windows.Forms.Button();
            this.buscarAvanTXTB = new System.Windows.Forms.TextBox();
            this.condicionCBOX = new System.Windows.Forms.ComboBox();
            this.campoCBOX = new System.Windows.Forms.ComboBox();
            this.campoLBL = new System.Windows.Forms.Label();
            this.condicionLBL = new System.Windows.Forms.Label();
            this.buscarAvanBTN = new System.Windows.Forms.Button();
            this.busquedaRapLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaArticulosDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenArticuloPBOX)).BeginInit();
            this.SuspendLayout();
            // 
            // listaArticulosDGV
            // 
            this.listaArticulosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaArticulosDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.listaArticulosDGV.Location = new System.Drawing.Point(28, 83);
            this.listaArticulosDGV.Name = "listaArticulosDGV";
            this.listaArticulosDGV.RowHeadersWidth = 51;
            this.listaArticulosDGV.RowTemplate.Height = 24;
            this.listaArticulosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaArticulosDGV.Size = new System.Drawing.Size(934, 414);
            this.listaArticulosDGV.TabIndex = 0;
            this.listaArticulosDGV.SelectionChanged += new System.EventHandler(this.listaArticulosDGV_SelectionChanged);
            // 
            // imagenArticuloPBOX
            // 
            this.imagenArticuloPBOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagenArticuloPBOX.Location = new System.Drawing.Point(968, 83);
            this.imagenArticuloPBOX.Name = "imagenArticuloPBOX";
            this.imagenArticuloPBOX.Size = new System.Drawing.Size(399, 414);
            this.imagenArticuloPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenArticuloPBOX.TabIndex = 1;
            this.imagenArticuloPBOX.TabStop = false;
            this.imagenArticuloPBOX.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // agregarBTN
            // 
            this.agregarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarBTN.Location = new System.Drawing.Point(26, 503);
            this.agregarBTN.Name = "agregarBTN";
            this.agregarBTN.Size = new System.Drawing.Size(116, 58);
            this.agregarBTN.TabIndex = 1;
            this.agregarBTN.Text = "Agregar";
            this.agregarBTN.UseVisualStyleBackColor = true;
            this.agregarBTN.Click += new System.EventHandler(this.agregarBTN_Click);
            this.agregarBTN.MouseLeave += new System.EventHandler(this.agregarBTN_MouseLeave);
            this.agregarBTN.MouseMove += new System.Windows.Forms.MouseEventHandler(this.agregarBTN_MouseMove);
            // 
            // eliminarBTN
            // 
            this.eliminarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarBTN.Location = new System.Drawing.Point(148, 503);
            this.eliminarBTN.Name = "eliminarBTN";
            this.eliminarBTN.Size = new System.Drawing.Size(116, 58);
            this.eliminarBTN.TabIndex = 2;
            this.eliminarBTN.Text = "Eliminar";
            this.eliminarBTN.UseVisualStyleBackColor = true;
            this.eliminarBTN.Click += new System.EventHandler(this.eliminarBTN_Click);
            this.eliminarBTN.MouseLeave += new System.EventHandler(this.eliminarBTN_MouseLeave);
            this.eliminarBTN.MouseMove += new System.Windows.Forms.MouseEventHandler(this.eliminarBTN_MouseMove);
            // 
            // modificarBTN
            // 
            this.modificarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarBTN.Location = new System.Drawing.Point(270, 503);
            this.modificarBTN.Name = "modificarBTN";
            this.modificarBTN.Size = new System.Drawing.Size(116, 58);
            this.modificarBTN.TabIndex = 3;
            this.modificarBTN.Text = "Modificar";
            this.modificarBTN.UseVisualStyleBackColor = true;
            this.modificarBTN.Click += new System.EventHandler(this.modificarBTN_Click);
            this.modificarBTN.MouseLeave += new System.EventHandler(this.modificarBTN_MouseLeave);
            this.modificarBTN.MouseMove += new System.Windows.Forms.MouseEventHandler(this.modificarBTN_MouseMove);
            // 
            // buscarTXTB
            // 
            this.buscarTXTB.Location = new System.Drawing.Point(445, 40);
            this.buscarTXTB.Name = "buscarTXTB";
            this.buscarTXTB.Size = new System.Drawing.Size(412, 22);
            this.buscarTXTB.TabIndex = 0;
            this.buscarTXTB.TextChanged += new System.EventHandler(this.buscarTXTB_TextChanged);
            this.buscarTXTB.Enter += new System.EventHandler(this.buscarTXTB_Enter);
            this.buscarTXTB.Leave += new System.EventHandler(this.buscarTXTB_Leave);
            // 
            // filtroAvanBTN
            // 
            this.filtroAvanBTN.Location = new System.Drawing.Point(426, 518);
            this.filtroAvanBTN.Name = "filtroAvanBTN";
            this.filtroAvanBTN.Size = new System.Drawing.Size(130, 31);
            this.filtroAvanBTN.TabIndex = 4;
            this.filtroAvanBTN.Text = "Filtro Avanzado";
            this.filtroAvanBTN.UseVisualStyleBackColor = true;
            this.filtroAvanBTN.Click += new System.EventHandler(this.filtroAvanBTN_Click);
            // 
            // catalogoLBL
            // 
            this.catalogoLBL.AutoSize = true;
            this.catalogoLBL.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalogoLBL.Location = new System.Drawing.Point(20, 26);
            this.catalogoLBL.Name = "catalogoLBL";
            this.catalogoLBL.Size = new System.Drawing.Size(379, 44);
            this.catalogoLBL.TabIndex = 8;
            this.catalogoLBL.Text = "Catálogo de Artículos";
            // 
            // ayudaBTN
            // 
            this.ayudaBTN.Location = new System.Drawing.Point(1287, 34);
            this.ayudaBTN.Name = "ayudaBTN";
            this.ayudaBTN.Size = new System.Drawing.Size(80, 40);
            this.ayudaBTN.TabIndex = 9;
            this.ayudaBTN.Text = "Ayuda";
            this.ayudaBTN.UseVisualStyleBackColor = true;
            this.ayudaBTN.Click += new System.EventHandler(this.ayudaBTN_Click);
            // 
            // buscarAvanTXTB
            // 
            this.buscarAvanTXTB.Enabled = false;
            this.buscarAvanTXTB.Location = new System.Drawing.Point(1082, 523);
            this.buscarAvanTXTB.Name = "buscarAvanTXTB";
            this.buscarAvanTXTB.Size = new System.Drawing.Size(205, 22);
            this.buscarAvanTXTB.TabIndex = 7;
            this.buscarAvanTXTB.Visible = false;
            this.buscarAvanTXTB.WordWrap = false;
            this.buscarAvanTXTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buscarAvanTXTB_KeyPress);
            this.buscarAvanTXTB.Leave += new System.EventHandler(this.buscarAvanTXTB_Leave);
            // 
            // condicionCBOX
            // 
            this.condicionCBOX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.condicionCBOX.Enabled = false;
            this.condicionCBOX.FormattingEnabled = true;
            this.condicionCBOX.Location = new System.Drawing.Point(904, 523);
            this.condicionCBOX.Name = "condicionCBOX";
            this.condicionCBOX.Size = new System.Drawing.Size(153, 24);
            this.condicionCBOX.TabIndex = 6;
            this.condicionCBOX.Visible = false;
            // 
            // campoCBOX
            // 
            this.campoCBOX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.campoCBOX.Enabled = false;
            this.campoCBOX.FormattingEnabled = true;
            this.campoCBOX.Location = new System.Drawing.Point(645, 523);
            this.campoCBOX.Name = "campoCBOX";
            this.campoCBOX.Size = new System.Drawing.Size(153, 24);
            this.campoCBOX.TabIndex = 5;
            this.campoCBOX.Visible = false;
            this.campoCBOX.SelectedIndexChanged += new System.EventHandler(this.campoCBOX_SelectedIndexChanged);
            // 
            // campoLBL
            // 
            this.campoLBL.AutoSize = true;
            this.campoLBL.Enabled = false;
            this.campoLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoLBL.Location = new System.Drawing.Point(571, 523);
            this.campoLBL.Name = "campoLBL";
            this.campoLBL.Size = new System.Drawing.Size(62, 20);
            this.campoLBL.TabIndex = 13;
            this.campoLBL.Text = "Campo";
            this.campoLBL.Visible = false;
            // 
            // condicionLBL
            // 
            this.condicionLBL.AutoSize = true;
            this.condicionLBL.Enabled = false;
            this.condicionLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condicionLBL.Location = new System.Drawing.Point(809, 523);
            this.condicionLBL.Name = "condicionLBL";
            this.condicionLBL.Size = new System.Drawing.Size(83, 20);
            this.condicionLBL.TabIndex = 14;
            this.condicionLBL.Text = "Condición";
            this.condicionLBL.Visible = false;
            // 
            // buscarAvanBTN
            // 
            this.buscarAvanBTN.Enabled = false;
            this.buscarAvanBTN.Location = new System.Drawing.Point(1295, 519);
            this.buscarAvanBTN.Name = "buscarAvanBTN";
            this.buscarAvanBTN.Size = new System.Drawing.Size(75, 31);
            this.buscarAvanBTN.TabIndex = 8;
            this.buscarAvanBTN.Text = "Buscar";
            this.buscarAvanBTN.UseVisualStyleBackColor = true;
            this.buscarAvanBTN.Visible = false;
            this.buscarAvanBTN.Click += new System.EventHandler(this.buscarAvanBTN_Click);
            // 
            // busquedaRapLBL
            // 
            this.busquedaRapLBL.AutoSize = true;
            this.busquedaRapLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaRapLBL.Location = new System.Drawing.Point(863, 40);
            this.busquedaRapLBL.Name = "busquedaRapLBL";
            this.busquedaRapLBL.Size = new System.Drawing.Size(135, 20);
            this.busquedaRapLBL.TabIndex = 17;
            this.busquedaRapLBL.Text = "Búsqueda rápida";
            // 
            // listaArticulosFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1382, 573);
            this.Controls.Add(this.busquedaRapLBL);
            this.Controls.Add(this.buscarAvanBTN);
            this.Controls.Add(this.condicionLBL);
            this.Controls.Add(this.campoLBL);
            this.Controls.Add(this.campoCBOX);
            this.Controls.Add(this.condicionCBOX);
            this.Controls.Add(this.buscarAvanTXTB);
            this.Controls.Add(this.ayudaBTN);
            this.Controls.Add(this.catalogoLBL);
            this.Controls.Add(this.filtroAvanBTN);
            this.Controls.Add(this.buscarTXTB);
            this.Controls.Add(this.modificarBTN);
            this.Controls.Add(this.eliminarBTN);
            this.Controls.Add(this.agregarBTN);
            this.Controls.Add(this.imagenArticuloPBOX);
            this.Controls.Add(this.listaArticulosDGV);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1400, 620);
            this.MinimumSize = new System.Drawing.Size(1400, 620);
            this.Name = "listaArticulosFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de Artículos";
            this.Load += new System.EventHandler(this.listaArticulosFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaArticulosDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenArticuloPBOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listaArticulosDGV;
        private System.Windows.Forms.PictureBox imagenArticuloPBOX;
        private System.Windows.Forms.Button agregarBTN;
        private System.Windows.Forms.Button eliminarBTN;
        private System.Windows.Forms.Button modificarBTN;
        private System.Windows.Forms.TextBox buscarTXTB;
        private System.Windows.Forms.Button filtroAvanBTN;
        private System.Windows.Forms.Label catalogoLBL;
        private System.Windows.Forms.Button ayudaBTN;
        private System.Windows.Forms.TextBox buscarAvanTXTB;
        private System.Windows.Forms.ComboBox condicionCBOX;
        private System.Windows.Forms.ComboBox campoCBOX;
        private System.Windows.Forms.Label campoLBL;
        private System.Windows.Forms.Label condicionLBL;
        private System.Windows.Forms.Button buscarAvanBTN;
        private System.Windows.Forms.Label busquedaRapLBL;
    }
}

