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
            this.cbMetodo = new System.Windows.Forms.ComboBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.panelMatriz = new System.Windows.Forms.Panel();
            this.buttonVolverInicio = new System.Windows.Forms.Button();
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
            this.buttonGenerar.Location = new System.Drawing.Point(198, 11);
            this.buttonGenerar.Name = "buttonGenerar";
            this.buttonGenerar.Size = new System.Drawing.Size(80, 30);
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
            this.labelMetodo.Location = new System.Drawing.Point(483, 18);
            this.labelMetodo.Name = "labelMetodo";
            this.labelMetodo.Size = new System.Drawing.Size(56, 16);
            this.labelMetodo.TabIndex = 3;
            this.labelMetodo.Text = "Método:";
            this.labelMetodo.Click += new System.EventHandler(this.labelMetodo_Click);
            // 
            // cbMetodo
            // 
            this.cbMetodo.FormattingEnabled = true;
            this.cbMetodo.Items.AddRange(new object[] {
            "GAUSS-JORDAN",
            "GAUSS-SEIDEL"});
            this.cbMetodo.Location = new System.Drawing.Point(545, 13);
            this.cbMetodo.Name = "cbMetodo";
            this.cbMetodo.Size = new System.Drawing.Size(162, 24);
            this.cbMetodo.TabIndex = 4;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(713, 10);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(80, 30);
            this.buttonCalcular.TabIndex = 5;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // panelMatriz
            // 
            this.panelMatriz.Location = new System.Drawing.Point(8, 59);
            this.panelMatriz.Name = "panelMatriz";
            this.panelMatriz.Size = new System.Drawing.Size(619, 379);
            this.panelMatriz.TabIndex = 6;
            // 
            // buttonVolverInicio
            // 
            this.buttonVolverInicio.Location = new System.Drawing.Point(678, 403);
            this.buttonVolverInicio.Name = "buttonVolverInicio";
            this.buttonVolverInicio.Size = new System.Drawing.Size(75, 23);
            this.buttonVolverInicio.TabIndex = 7;
            this.buttonVolverInicio.Text = "Volver";
            this.buttonVolverInicio.UseVisualStyleBackColor = true;
            this.buttonVolverInicio.Click += new System.EventHandler(this.buttonVolverClick);
            // 
            // Matriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVolverInicio);
            this.Controls.Add(this.panelMatriz);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.cbMetodo);
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
        private System.Windows.Forms.ComboBox cbMetodo;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Panel panelMatriz;
        private System.Windows.Forms.Button buttonVolverInicio;
    }
}