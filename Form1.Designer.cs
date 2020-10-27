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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cbVehiculos = new System.Windows.Forms.ComboBox();
            this.cbVehiculosConChofer = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1210, 24);
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
            // 
            // modificarValoresDeAlquilerToolStripMenuItem
            // 
            this.modificarValoresDeAlquilerToolStripMenuItem.Name = "modificarValoresDeAlquilerToolStripMenuItem";
            this.modificarValoresDeAlquilerToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.modificarValoresDeAlquilerToolStripMenuItem.Text = "Modificar valores de alquiler";
            this.modificarValoresDeAlquilerToolStripMenuItem.Click += new System.EventHandler(this.modificarValoresDeAlquilerToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(215, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(319, 303);
            this.listBox1.TabIndex = 2;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(573, 63);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(329, 303);
            this.listBox2.TabIndex = 3;
            this.listBox2.Click += new System.EventHandler(this.listBox2_Click);
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            this.listBox2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vehiculos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vehiculos con Chofer";
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(919, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(90, 391);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(129, 26);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cbVehiculos
            // 
            this.cbVehiculos.FormattingEnabled = true;
            this.cbVehiculos.Items.AddRange(new object[] {
            "Marca y Modelo",
            "Capacidad",
            "Tipo de Combustible"});
            this.cbVehiculos.Location = new System.Drawing.Point(291, 34);
            this.cbVehiculos.Name = "cbVehiculos";
            this.cbVehiculos.Size = new System.Drawing.Size(121, 21);
            this.cbVehiculos.TabIndex = 14;
            this.cbVehiculos.Text = "Ordenar";
            this.cbVehiculos.SelectedIndexChanged += new System.EventHandler(this.cbVehiculos_SelectedIndexChanged);
            // 
            // cbVehiculosConChofer
            // 
            this.cbVehiculosConChofer.FormattingEnabled = true;
            this.cbVehiculosConChofer.Items.AddRange(new object[] {
            "Marca y Modelo",
            "Capacidad",
            "Tipo de Combustible"});
            this.cbVehiculosConChofer.Location = new System.Drawing.Point(684, 34);
            this.cbVehiculosConChofer.Name = "cbVehiculosConChofer";
            this.cbVehiculosConChofer.Size = new System.Drawing.Size(121, 21);
            this.cbVehiculosConChofer.TabIndex = 15;
            this.cbVehiculosConChofer.Text = "Ordenar";
            this.cbVehiculosConChofer.SelectedIndexChanged += new System.EventHandler(this.cbVehiculosConChofer_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 450);
            this.Controls.Add(this.cbVehiculosConChofer);
            this.Controls.Add(this.cbVehiculos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem conChoferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinChoferToolStripMenuItem;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.ComboBox cbVehiculos;
        public System.Windows.Forms.ComboBox cbVehiculosConChofer;
    }
}

