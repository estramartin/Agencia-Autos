namespace Agencia_Autos
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conChoferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinChoferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarRegistrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarValoresDeAlquilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.CMARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMOODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCAPACIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCOMBUSTIBLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CKMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDISPONIBILE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbChofer = new System.Windows.Forms.ComboBox();
            this.cbVehiculos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PrintTicket = new System.Drawing.Printing.PrintDocument();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1302, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.borrarRegistrosToolStripMenuItem,
            this.modificarValoresDeAlquilerToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menúToolStripMenuItem.Text = "Menú";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conChoferToolStripMenuItem,
            this.sinChoferToolStripMenuItem});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.agregarToolStripMenuItem.Text = "Agregar Vehículo";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // conChoferToolStripMenuItem
            // 
            this.conChoferToolStripMenuItem.Name = "conChoferToolStripMenuItem";
            this.conChoferToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.conChoferToolStripMenuItem.Text = "Con Chofer";
            this.conChoferToolStripMenuItem.Click += new System.EventHandler(this.conChoferToolStripMenuItem_Click);
            // 
            // sinChoferToolStripMenuItem
            // 
            this.sinChoferToolStripMenuItem.Name = "sinChoferToolStripMenuItem";
            this.sinChoferToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.sinChoferToolStripMenuItem.Text = "Sin Chofer";
            this.sinChoferToolStripMenuItem.Click += new System.EventHandler(this.sinChoferToolStripMenuItem_Click);
            // 
            // borrarRegistrosToolStripMenuItem
            // 
            this.borrarRegistrosToolStripMenuItem.Name = "borrarRegistrosToolStripMenuItem";
            this.borrarRegistrosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.borrarRegistrosToolStripMenuItem.Text = "Borrar Registros";
            this.borrarRegistrosToolStripMenuItem.Click += new System.EventHandler(this.borrarRegistrosToolStripMenuItem_Click);
            // 
            // modificarValoresDeAlquilerToolStripMenuItem
            // 
            this.modificarValoresDeAlquilerToolStripMenuItem.Name = "modificarValoresDeAlquilerToolStripMenuItem";
            this.modificarValoresDeAlquilerToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.modificarValoresDeAlquilerToolStripMenuItem.Text = "Modificar valores de alquiler";
            this.modificarValoresDeAlquilerToolStripMenuItem.Click += new System.EventHandler(this.modificarValoresDeAlquilerToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 30);
            this.button3.TabIndex = 7;
            this.button3.Text = "Ver lista de Alquileres";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 222);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 35);
            this.button4.TabIndex = 8;
            this.button4.Text = "Ver Historico";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1041, 361);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(21, 510);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(129, 26);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(481, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 41);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // DGV1
            // 
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CMARCA,
            this.CMOODELO,
            this.CCAPACIDAD,
            this.CCOMBUSTIBLE,
            this.CKMS,
            this.CDISPONIBILE,
            this.CPRECIO});
            this.DGV1.Location = new System.Drawing.Point(184, 110);
            this.DGV1.Name = "DGV1";
            this.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV1.Size = new System.Drawing.Size(748, 406);
            this.DGV1.TabIndex = 17;
            this.DGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellContentClick);
            this.DGV1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellContentDoubleClick);
            this.DGV1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellDoubleClick);
            // 
            // CMARCA
            // 
            this.CMARCA.HeaderText = "MARCA";
            this.CMARCA.Name = "CMARCA";
            this.CMARCA.ReadOnly = true;
            // 
            // CMOODELO
            // 
            this.CMOODELO.HeaderText = "MODELO";
            this.CMOODELO.Name = "CMOODELO";
            this.CMOODELO.ReadOnly = true;
            // 
            // CCAPACIDAD
            // 
            this.CCAPACIDAD.HeaderText = "CAPACIDAD";
            this.CCAPACIDAD.Name = "CCAPACIDAD";
            this.CCAPACIDAD.ReadOnly = true;
            // 
            // CCOMBUSTIBLE
            // 
            this.CCOMBUSTIBLE.HeaderText = "COMBUSTIBLE";
            this.CCOMBUSTIBLE.Name = "CCOMBUSTIBLE";
            this.CCOMBUSTIBLE.ReadOnly = true;
            // 
            // CKMS
            // 
            this.CKMS.HeaderText = "KMS";
            this.CKMS.Name = "CKMS";
            this.CKMS.ReadOnly = true;
            // 
            // CDISPONIBILE
            // 
            this.CDISPONIBILE.HeaderText = "DISPONIBLE";
            this.CDISPONIBILE.Name = "CDISPONIBILE";
            this.CDISPONIBILE.ReadOnly = true;
            // 
            // CPRECIO
            // 
            this.CPRECIO.HeaderText = "PRECIO";
            this.CPRECIO.Name = "CPRECIO";
            this.CPRECIO.ReadOnly = true;
            // 
            // cbChofer
            // 
            this.cbChofer.FormattingEnabled = true;
            this.cbChofer.Items.AddRange(new object[] {
            "CON CHOFER",
            "SIN CHOFER"});
            this.cbChofer.Location = new System.Drawing.Point(810, 85);
            this.cbChofer.Name = "cbChofer";
            this.cbChofer.Size = new System.Drawing.Size(121, 21);
            this.cbChofer.TabIndex = 18;
            this.cbChofer.Text = "Con/Sin";
            this.cbChofer.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbVehiculos
            // 
            this.cbVehiculos.FormattingEnabled = true;
            this.cbVehiculos.Items.AddRange(new object[] {
            "Marca y Modelos",
            "Capacidad",
            "Tipo de Combustible"});
            this.cbVehiculos.Location = new System.Drawing.Point(810, 27);
            this.cbVehiculos.Name = "cbVehiculos";
            this.cbVehiculos.Size = new System.Drawing.Size(121, 21);
            this.cbVehiculos.TabIndex = 14;
            this.cbVehiculos.Text = "Filtrar por";
            this.cbVehiculos.SelectedIndexChanged += new System.EventHandler(this.cbVehiculos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(763, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Chofer:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(938, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // PrintTicket
            // 
            this.PrintTicket.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintTicket_PrintPage);
            // 
            // tbFiltro
            // 
            this.tbFiltro.Location = new System.Drawing.Point(810, 54);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(121, 20);
            this.tbFiltro.TabIndex = 20;
            this.tbFiltro.TextChanged += new System.EventHandler(this.tbFiltro_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 548);
            this.Controls.Add(this.tbFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbChofer);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbVehiculos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ALQUILAUTO 1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarRegistrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarValoresDeAlquilerToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem conChoferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinChoferToolStripMenuItem;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMOODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCAPACIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCOMBUSTIBLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CKMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDISPONIBILE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPRECIO;
        public System.Windows.Forms.ComboBox cbChofer;
        public System.Windows.Forms.ComboBox cbVehiculos;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument PrintTicket;
        private System.Windows.Forms.TextBox tbFiltro;
    }
}

