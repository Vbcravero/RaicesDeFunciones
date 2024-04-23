namespace RaicesDeFunciones
{
    partial class Matriz
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
            this.textDimension = new System.Windows.Forms.TextBox();
            this.buttonGenerar = new System.Windows.Forms.Button();
            this.labelDimension = new System.Windows.Forms.Label();
            this.labelMetodo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.panelMatriz = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textDimension
            // 
            this.textDimension.Location = new System.Drawing.Point(92, 15);
            this.textDimension.Name = "textDimension";
            this.textDimension.Size = new System.Drawing.Size(100, 22);
            this.textDimension.TabIndex = 0;
            // 
            // buttonGenerar
            // 
            this.buttonGenerar.Location = new System.Drawing.Point(198, 15);
            this.buttonGenerar.Name = "buttonGenerar";
            this.buttonGenerar.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerar.TabIndex = 1;
            this.buttonGenerar.Text = "Generar";
            this.buttonGenerar.UseVisualStyleBackColor = true;
            this.buttonGenerar.Click += new System.EventHandler(this.buttonGenerar_Click);
            // 
            // labelDimension
            // 
            this.labelDimension.AutoSize = true;
            this.labelDimension.Location = new System.Drawing.Point(12, 18);
            this.labelDimension.Name = "labelDimension";
            this.labelDimension.Size = new System.Drawing.Size(74, 16);
            this.labelDimension.TabIndex = 2;
            this.labelDimension.Text = "Dimensión:";
            // 
            // labelMetodo
            // 
            this.labelMetodo.AutoSize = true;
            this.labelMetodo.Location = new System.Drawing.Point(447, 20);
            this.labelMetodo.Name = "labelMetodo";
            this.labelMetodo.Size = new System.Drawing.Size(53, 16);
            this.labelMetodo.TabIndex = 3;
            this.labelMetodo.Text = "Método";
            this.labelMetodo.Click += new System.EventHandler(this.labelMetodo_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "GAUSS-JORDAN",
            "GAUSS-SEIDEL"});
            this.comboBox1.Location = new System.Drawing.Point(506, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(656, 14);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(75, 23);
            this.buttonCalc.TabIndex = 5;
            this.buttonCalc.Text = "Calcular";
            this.buttonCalc.UseVisualStyleBackColor = true;
            // 
            // panelMatriz
            // 
            this.panelMatriz.Location = new System.Drawing.Point(8, 59);
            this.panelMatriz.Name = "panelMatriz";
            this.panelMatriz.Size = new System.Drawing.Size(619, 379);
            this.panelMatriz.TabIndex = 6;
            // 
            // Matriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMatriz);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelMetodo);
            this.Controls.Add(this.labelDimension);
            this.Controls.Add(this.buttonGenerar);
            this.Controls.Add(this.textDimension);
            this.Name = "Matriz";
            this.Text = "Matriz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDimension;
        private System.Windows.Forms.Button buttonGenerar;
        private System.Windows.Forms.Label labelDimension;
        private System.Windows.Forms.Label labelMetodo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Panel panelMatriz;
    }
}