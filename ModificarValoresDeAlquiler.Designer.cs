namespace Agencia_Autos
{
    partial class ModificarValoresDeAlquiler
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbModificarValorDeAlquiler = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMostrarValorActual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(408, 309);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbModificarValorDeAlquiler
            // 
            this.tbModificarValorDeAlquiler.Location = new System.Drawing.Point(204, 137);
            this.tbModificarValorDeAlquiler.Name = "tbModificarValorDeAlquiler";
            this.tbModificarValorDeAlquiler.Size = new System.Drawing.Size(171, 20);
            this.tbModificarValorDeAlquiler.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Actualizar Valores de Cobro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor expresado en pesos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor actual:";
            // 
            // lblMostrarValorActual
            // 
            this.lblMostrarValorActual.AutoSize = true;
            this.lblMostrarValorActual.Location = new System.Drawing.Point(204, 194);
            this.lblMostrarValorActual.Name = "lblMostrarValorActual";
            this.lblMostrarValorActual.Size = new System.Drawing.Size(35, 13);
            this.lblMostrarValorActual.TabIndex = 6;
            this.lblMostrarValorActual.Text = "label4";
            // 
            // ModificarValoresDeAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 384);
            this.Controls.Add(this.lblMostrarValorActual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbModificarValorDeAlquiler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAceptar);
            this.Name = "ModificarValoresDeAlquiler";
            this.Text = "ModificarValoresDeAlquiler";
            this.Load += new System.EventHandler(this.ModificarValoresDeAlquiler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.TextBox tbModificarValorDeAlquiler;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblMostrarValorActual;
    }
}