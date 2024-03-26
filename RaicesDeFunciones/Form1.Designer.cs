namespace RaicesDeFunciones
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
            this.titulo = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.metodo = new System.Windows.Forms.Label();
            this.comboMetodos = new System.Windows.Forms.ComboBox();
            this.textFuncion = new System.Windows.Forms.TextBox();
            this.textIteracion = new System.Windows.Forms.TextBox();
            this.textTolerancia = new System.Windows.Forms.TextBox();
            this.textXi = new System.Windows.Forms.TextBox();
            this.textXd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.groupBoxEntrada = new System.Windows.Forms.GroupBox();
            this.labelXd = new System.Windows.Forms.Label();
            this.labelTolerancia = new System.Windows.Forms.Label();
            this.labelXi = new System.Windows.Forms.Label();
            this.labelIteracionesMax = new System.Windows.Forms.Label();
            this.labelFuncion = new System.Windows.Forms.Label();
            this.groupBoxSalida = new System.Windows.Forms.GroupBox();
            this.textBoxMetodo = new System.Windows.Forms.TextBox();
            this.textBoxCantIteracion = new System.Windows.Forms.TextBox();
            this.textBoxConverge = new System.Windows.Forms.TextBox();
            this.labelConverge = new System.Windows.Forms.Label();
            this.textBoxRaiz = new System.Windows.Forms.TextBox();
            this.labelCantInteracion = new System.Windows.Forms.Label();
            this.metodoUtilizado = new System.Windows.Forms.Label();
            this.labelRaiz = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.textBoxError = new System.Windows.Forms.TextBox();
            this.groupBoxEntrada.SuspendLayout();
            this.groupBoxSalida.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(606, 277);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(148, 17);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "RAÍCES DE FUNCIONES";
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(708, 408);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(80, 30);
            this.buttonCalcular.TabIndex = 1;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // metodo
            // 
            this.metodo.AutoSize = true;
            this.metodo.Location = new System.Drawing.Point(606, 48);
            this.metodo.Name = "metodo";
            this.metodo.Size = new System.Drawing.Size(56, 16);
            this.metodo.TabIndex = 2;
            this.metodo.Text = "Método:";
            // 
            // comboMetodos
            // 
            this.comboMetodos.FormattingEnabled = true;
            this.comboMetodos.Items.AddRange(new object[] {
            "Bisección",
            "Regla falsa",
            "Tangente",
            "Secante"});
            this.comboMetodos.Location = new System.Drawing.Point(667, 43);
            this.comboMetodos.Name = "comboMetodos";
            this.comboMetodos.Size = new System.Drawing.Size(121, 24);
            this.comboMetodos.TabIndex = 4;
            // 
            // textFuncion
            // 
            this.textFuncion.Location = new System.Drawing.Point(105, 24);
            this.textFuncion.Name = "textFuncion";
            this.textFuncion.Size = new System.Drawing.Size(374, 22);
            this.textFuncion.TabIndex = 5;
            // 
            // textIteracion
            // 
            this.textIteracion.Location = new System.Drawing.Point(336, 59);
            this.textIteracion.Name = "textIteracion";
            this.textIteracion.Size = new System.Drawing.Size(142, 22);
            this.textIteracion.TabIndex = 6;
            this.textIteracion.Text = "25";
            // 
            // textTolerancia
            // 
            this.textTolerancia.Location = new System.Drawing.Point(336, 92);
            this.textTolerancia.Name = "textTolerancia";
            this.textTolerancia.Size = new System.Drawing.Size(142, 22);
            this.textTolerancia.TabIndex = 7;
            this.textTolerancia.Text = "0.0001";
            // 
            // textXi
            // 
            this.textXi.Location = new System.Drawing.Point(49, 59);
            this.textXi.Name = "textXi";
            this.textXi.Size = new System.Drawing.Size(142, 22);
            this.textXi.TabIndex = 8;
            // 
            // textXd
            // 
            this.textXd.Location = new System.Drawing.Point(49, 92);
            this.textXd.Name = "textXd";
            this.textXd.Size = new System.Drawing.Size(142, 22);
            this.textXd.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(642, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(15, 415);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 11;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // groupBoxEntrada
            // 
            this.groupBoxEntrada.Controls.Add(this.labelXd);
            this.groupBoxEntrada.Controls.Add(this.labelTolerancia);
            this.groupBoxEntrada.Controls.Add(this.labelXi);
            this.groupBoxEntrada.Controls.Add(this.labelIteracionesMax);
            this.groupBoxEntrada.Controls.Add(this.labelFuncion);
            this.groupBoxEntrada.Controls.Add(this.textFuncion);
            this.groupBoxEntrada.Controls.Add(this.textIteracion);
            this.groupBoxEntrada.Controls.Add(this.textTolerancia);
            this.groupBoxEntrada.Controls.Add(this.textXd);
            this.groupBoxEntrada.Controls.Add(this.textXi);
            this.groupBoxEntrada.Location = new System.Drawing.Point(15, 21);
            this.groupBoxEntrada.Name = "groupBoxEntrada";
            this.groupBoxEntrada.Size = new System.Drawing.Size(570, 181);
            this.groupBoxEntrada.TabIndex = 12;
            this.groupBoxEntrada.TabStop = false;
            this.groupBoxEntrada.Text = "Datos de Entrada";
            // 
            // labelXd
            // 
            this.labelXd.AutoSize = true;
            this.labelXd.Location = new System.Drawing.Point(9, 95);
            this.labelXd.Name = "labelXd";
            this.labelXd.Size = new System.Drawing.Size(34, 16);
            this.labelXd.TabIndex = 14;
            this.labelXd.Text = "xd = ";
            // 
            // labelTolerancia
            // 
            this.labelTolerancia.AutoSize = true;
            this.labelTolerancia.Location = new System.Drawing.Point(213, 95);
            this.labelTolerancia.Name = "labelTolerancia";
            this.labelTolerancia.Size = new System.Drawing.Size(75, 16);
            this.labelTolerancia.TabIndex = 13;
            this.labelTolerancia.Text = "Tolerancia:";
            // 
            // labelXi
            // 
            this.labelXi.AutoSize = true;
            this.labelXi.Location = new System.Drawing.Point(9, 62);
            this.labelXi.Name = "labelXi";
            this.labelXi.Size = new System.Drawing.Size(26, 16);
            this.labelXi.TabIndex = 13;
            this.labelXi.Text = "xi =";
            // 
            // labelIteracionesMax
            // 
            this.labelIteracionesMax.AutoSize = true;
            this.labelIteracionesMax.Location = new System.Drawing.Point(213, 62);
            this.labelIteracionesMax.Name = "labelIteracionesMax";
            this.labelIteracionesMax.Size = new System.Drawing.Size(112, 16);
            this.labelIteracionesMax.TabIndex = 13;
            this.labelIteracionesMax.Text = "Iteraciones (Máx):";
            // 
            // labelFuncion
            // 
            this.labelFuncion.AutoSize = true;
            this.labelFuncion.Location = new System.Drawing.Point(9, 27);
            this.labelFuncion.Name = "labelFuncion";
            this.labelFuncion.Size = new System.Drawing.Size(89, 16);
            this.labelFuncion.TabIndex = 13;
            this.labelFuncion.Text = "Función F(x) =";
            // 
            // groupBoxSalida
            // 
            this.groupBoxSalida.Controls.Add(this.textBoxError);
            this.groupBoxSalida.Controls.Add(this.labelError);
            this.groupBoxSalida.Controls.Add(this.textBoxMetodo);
            this.groupBoxSalida.Controls.Add(this.textBoxCantIteracion);
            this.groupBoxSalida.Controls.Add(this.textBoxConverge);
            this.groupBoxSalida.Controls.Add(this.labelConverge);
            this.groupBoxSalida.Controls.Add(this.textBoxRaiz);
            this.groupBoxSalida.Controls.Add(this.labelCantInteracion);
            this.groupBoxSalida.Controls.Add(this.metodoUtilizado);
            this.groupBoxSalida.Controls.Add(this.labelRaiz);
            this.groupBoxSalida.Location = new System.Drawing.Point(15, 209);
            this.groupBoxSalida.Name = "groupBoxSalida";
            this.groupBoxSalida.Size = new System.Drawing.Size(571, 181);
            this.groupBoxSalida.TabIndex = 13;
            this.groupBoxSalida.TabStop = false;
            this.groupBoxSalida.Text = "Resultado";
            // 
            // textBoxMetodo
            // 
            this.textBoxMetodo.Location = new System.Drawing.Point(128, 29);
            this.textBoxMetodo.Name = "textBoxMetodo";
            this.textBoxMetodo.Size = new System.Drawing.Size(100, 22);
            this.textBoxMetodo.TabIndex = 7;
            // 
            // textBoxCantIteracion
            // 
            this.textBoxCantIteracion.Location = new System.Drawing.Point(128, 65);
            this.textBoxCantIteracion.Name = "textBoxCantIteracion";
            this.textBoxCantIteracion.Size = new System.Drawing.Size(100, 22);
            this.textBoxCantIteracion.TabIndex = 6;
            // 
            // textBoxConverge
            // 
            this.textBoxConverge.Location = new System.Drawing.Point(378, 25);
            this.textBoxConverge.Name = "textBoxConverge";
            this.textBoxConverge.Size = new System.Drawing.Size(100, 22);
            this.textBoxConverge.TabIndex = 5;
            // 
            // labelConverge
            // 
            this.labelConverge.AutoSize = true;
            this.labelConverge.Location = new System.Drawing.Point(288, 32);
            this.labelConverge.Name = "labelConverge";
            this.labelConverge.Size = new System.Drawing.Size(69, 16);
            this.labelConverge.TabIndex = 4;
            this.labelConverge.Text = "Converge:";
            // 
            // textBoxRaiz
            // 
            this.textBoxRaiz.Location = new System.Drawing.Point(378, 66);
            this.textBoxRaiz.Name = "textBoxRaiz";
            this.textBoxRaiz.Size = new System.Drawing.Size(100, 22);
            this.textBoxRaiz.TabIndex = 3;
            // 
            // labelCantInteracion
            // 
            this.labelCantInteracion.AutoSize = true;
            this.labelCantInteracion.Location = new System.Drawing.Point(12, 68);
            this.labelCantInteracion.Name = "labelCantInteracion";
            this.labelCantInteracion.Size = new System.Drawing.Size(109, 16);
            this.labelCantInteracion.TabIndex = 2;
            this.labelCantInteracion.Text = "Cant. Iteraciones:";
            // 
            // metodoUtilizado
            // 
            this.metodoUtilizado.AutoSize = true;
            this.metodoUtilizado.Location = new System.Drawing.Point(9, 32);
            this.metodoUtilizado.Name = "metodoUtilizado";
            this.metodoUtilizado.Size = new System.Drawing.Size(112, 16);
            this.metodoUtilizado.TabIndex = 1;
            this.metodoUtilizado.Text = "Método aplicado:";
            // 
            // labelRaiz
            // 
            this.labelRaiz.AutoSize = true;
            this.labelRaiz.Location = new System.Drawing.Point(288, 69);
            this.labelRaiz.Name = "labelRaiz";
            this.labelRaiz.Size = new System.Drawing.Size(65, 16);
            this.labelRaiz.TabIndex = 0;
            this.labelRaiz.Text = "Raíz (xr) =";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(622, 408);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(80, 30);
            this.buttonLimpiar.TabIndex = 14;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(12, 110);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(86, 16);
            this.labelError.TabIndex = 8;
            this.labelError.Text = "Error relativo:";
            // 
            // textBoxError
            // 
            this.textBoxError.Location = new System.Drawing.Point(127, 104);
            this.textBoxError.Name = "textBoxError";
            this.textBoxError.Size = new System.Drawing.Size(351, 22);
            this.textBoxError.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.groupBoxSalida);
            this.Controls.Add(this.groupBoxEntrada);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboMetodos);
            this.Controls.Add(this.metodo);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxEntrada.ResumeLayout(false);
            this.groupBoxEntrada.PerformLayout();
            this.groupBoxSalida.ResumeLayout(false);
            this.groupBoxSalida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label metodo;
        private System.Windows.Forms.ComboBox comboMetodos;
        private System.Windows.Forms.TextBox textFuncion;
        private System.Windows.Forms.TextBox textIteracion;
        private System.Windows.Forms.TextBox textTolerancia;
        private System.Windows.Forms.TextBox textXi;
        private System.Windows.Forms.TextBox textXd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.GroupBox groupBoxEntrada;
        private System.Windows.Forms.Label labelTolerancia;
        private System.Windows.Forms.Label labelIteracionesMax;
        private System.Windows.Forms.Label labelFuncion;
        private System.Windows.Forms.Label labelXd;
        private System.Windows.Forms.Label labelXi;
        private System.Windows.Forms.GroupBox groupBoxSalida;
        private System.Windows.Forms.Label labelRaiz;
        private System.Windows.Forms.Label metodoUtilizado;
        private System.Windows.Forms.Label labelCantInteracion;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.TextBox textBoxRaiz;
        private System.Windows.Forms.TextBox textBoxConverge;
        private System.Windows.Forms.Label labelConverge;
        private System.Windows.Forms.TextBox textBoxCantIteracion;
        private System.Windows.Forms.TextBox textBoxMetodo;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TextBox textBoxError;
    }
}

