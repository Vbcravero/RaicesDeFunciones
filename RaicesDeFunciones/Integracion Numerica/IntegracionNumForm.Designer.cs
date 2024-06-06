namespace RaicesDeFunciones.Integracion_Numerica
{
    partial class IntegracionNumForm
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
            this.gbEntradas = new System.Windows.Forms.GroupBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.lbCantSubinter = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbMetodo = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lbB = new System.Windows.Forms.Label();
            this.lbA = new System.Windows.Forms.Label();
            this.lbFx = new System.Windows.Forms.Label();
            this.txtFx = new System.Windows.Forms.TextBox();
            this.nudCantSI = new System.Windows.Forms.NumericUpDown();
            this.gbSalidas = new System.Windows.Forms.GroupBox();
            this.lbArea = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.gbEntradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantSI)).BeginInit();
            this.gbSalidas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEntradas
            // 
            this.gbEntradas.Controls.Add(this.nudCantSI);
            this.gbEntradas.Controls.Add(this.btCalcular);
            this.gbEntradas.Controls.Add(this.lbCantSubinter);
            this.gbEntradas.Controls.Add(this.comboBox1);
            this.gbEntradas.Controls.Add(this.lbMetodo);
            this.gbEntradas.Controls.Add(this.txtB);
            this.gbEntradas.Controls.Add(this.txtA);
            this.gbEntradas.Controls.Add(this.lbB);
            this.gbEntradas.Controls.Add(this.lbA);
            this.gbEntradas.Controls.Add(this.lbFx);
            this.gbEntradas.Controls.Add(this.txtFx);
            this.gbEntradas.Location = new System.Drawing.Point(13, 13);
            this.gbEntradas.Name = "gbEntradas";
            this.gbEntradas.Size = new System.Drawing.Size(775, 220);
            this.gbEntradas.TabIndex = 0;
            this.gbEntradas.TabStop = false;
            this.gbEntradas.Text = "Entradas";
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(6, 176);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(474, 29);
            this.btCalcular.TabIndex = 9;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // lbCantSubinter
            // 
            this.lbCantSubinter.AutoSize = true;
            this.lbCantSubinter.Location = new System.Drawing.Point(6, 148);
            this.lbCantSubinter.Name = "lbCantSubinter";
            this.lbCantSubinter.Size = new System.Drawing.Size(184, 16);
            this.lbCantSubinter.TabIndex = 8;
            this.lbCantSubinter.Text = "Cantidad de subintervalos (n):";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Trapecio simple",
            "Trapecios múltiples",
            "Simpson 1/3 simple",
            "Simpson 1/3 múltiples",
            "Simpson 3/8 simple"});
            this.comboBox1.Location = new System.Drawing.Point(89, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(391, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // lbMetodo
            // 
            this.lbMetodo.AutoSize = true;
            this.lbMetodo.Location = new System.Drawing.Point(6, 110);
            this.lbMetodo.Name = "lbMetodo";
            this.lbMetodo.Size = new System.Drawing.Size(56, 16);
            this.lbMetodo.TabIndex = 6;
            this.lbMetodo.Text = "Método:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(329, 63);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(151, 22);
            this.txtB.TabIndex = 5;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(89, 63);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(151, 22);
            this.txtA.TabIndex = 4;
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(267, 66);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(56, 16);
            this.lbB.TabIndex = 3;
            this.lbB.Text = "Punto B:";
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(6, 66);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(56, 16);
            this.lbA.TabIndex = 2;
            this.lbA.Text = "Punto A:";
            // 
            // lbFx
            // 
            this.lbFx.AutoSize = true;
            this.lbFx.Location = new System.Drawing.Point(6, 27);
            this.lbFx.Name = "lbFx";
            this.lbFx.Size = new System.Drawing.Size(77, 16);
            this.lbFx.TabIndex = 1;
            this.lbFx.Text = "Función (fx):";
            // 
            // txtFx
            // 
            this.txtFx.Location = new System.Drawing.Point(89, 24);
            this.txtFx.Name = "txtFx";
            this.txtFx.Size = new System.Drawing.Size(391, 22);
            this.txtFx.TabIndex = 0;
            // 
            // nudCantSI
            // 
            this.nudCantSI.Location = new System.Drawing.Point(203, 146);
            this.nudCantSI.Name = "nudCantSI";
            this.nudCantSI.Size = new System.Drawing.Size(277, 22);
            this.nudCantSI.TabIndex = 10;
            // 
            // gbSalidas
            // 
            this.gbSalidas.Controls.Add(this.txtArea);
            this.gbSalidas.Controls.Add(this.lbArea);
            this.gbSalidas.Location = new System.Drawing.Point(13, 240);
            this.gbSalidas.Name = "gbSalidas";
            this.gbSalidas.Size = new System.Drawing.Size(775, 198);
            this.gbSalidas.TabIndex = 1;
            this.gbSalidas.TabStop = false;
            this.gbSalidas.Text = "Salidas";
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Location = new System.Drawing.Point(6, 27);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(39, 16);
            this.lbArea.TabIndex = 0;
            this.lbArea.Text = "Área:";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(89, 27);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(391, 22);
            this.txtArea.TabIndex = 1;
            // 
            // IntegracionNumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbSalidas);
            this.Controls.Add(this.gbEntradas);
            this.Name = "IntegracionNumForm";
            this.Text = "IntegracionNumForm";
            this.gbEntradas.ResumeLayout(false);
            this.gbEntradas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantSI)).EndInit();
            this.gbSalidas.ResumeLayout(false);
            this.gbSalidas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEntradas;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbFx;
        private System.Windows.Forms.TextBox txtFx;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbMetodo;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lbCantSubinter;
        private System.Windows.Forms.NumericUpDown nudCantSI;
        private System.Windows.Forms.GroupBox gbSalidas;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lbArea;
    }
}