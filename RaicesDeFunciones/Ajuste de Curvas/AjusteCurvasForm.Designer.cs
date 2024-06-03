namespace RaicesDeFunciones.Ajuste_de_Curvas
{
    partial class AjusteCurvasForm
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
            this.tbx = new System.Windows.Forms.TextBox();
            this.tby = new System.Windows.Forms.TextBox();
            this.labelx = new System.Windows.Forms.Label();
            this.labely = new System.Windows.Forms.Label();
            this.btDelUlt = new System.Windows.Forms.Button();
            this.btDelTodo = new System.Windows.Forms.Button();
            this.gbPoints = new System.Windows.Forms.GroupBox();
            this.lbBorrar = new System.Windows.Forms.Label();
            this.lbxPoints = new System.Windows.Forms.ListBox();
            this.btDelSelect = new System.Windows.Forms.Button();
            this.gbEntradas = new System.Windows.Forms.GroupBox();
            this.nudGrado = new System.Windows.Forms.NumericUpDown();
            this.lbGrado = new System.Windows.Forms.Label();
            this.lbTolerancia = new System.Windows.Forms.Label();
            this.tbTolerancia = new System.Windows.Forms.TextBox();
            this.lbMetodo = new System.Windows.Forms.Label();
            this.cbMetodos = new System.Windows.Forms.ComboBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.gbSalidas = new System.Windows.Forms.GroupBox();
            this.tbEfecAjuste = new System.Windows.Forms.TextBox();
            this.lbEfecAjuste = new System.Windows.Forms.Label();
            this.lbEfectividad = new System.Windows.Forms.Label();
            this.tbEfectividad = new System.Windows.Forms.TextBox();
            this.tbFuncion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btVolver = new System.Windows.Forms.Button();
            this.pnlGrafica = new System.Windows.Forms.Panel();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.gbPoints.SuspendLayout();
            this.gbEntradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrado)).BeginInit();
            this.gbSalidas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx
            // 
            this.tbx.Location = new System.Drawing.Point(30, 26);
            this.tbx.Name = "tbx";
            this.tbx.Size = new System.Drawing.Size(100, 22);
            this.tbx.TabIndex = 0;
            // 
            // tby
            // 
            this.tby.Location = new System.Drawing.Point(175, 26);
            this.tby.Name = "tby";
            this.tby.Size = new System.Drawing.Size(100, 22);
            this.tby.TabIndex = 1;
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Location = new System.Drawing.Point(9, 29);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(18, 16);
            this.labelx.TabIndex = 2;
            this.labelx.Text = "X:";
            this.labelx.Click += new System.EventHandler(this.label1_Click);
            // 
            // labely
            // 
            this.labely.AutoSize = true;
            this.labely.Location = new System.Drawing.Point(154, 29);
            this.labely.Name = "labely";
            this.labely.Size = new System.Drawing.Size(19, 16);
            this.labely.TabIndex = 3;
            this.labely.Text = "Y:";
            // 
            // btDelUlt
            // 
            this.btDelUlt.Location = new System.Drawing.Point(146, 48);
            this.btDelUlt.Name = "btDelUlt";
            this.btDelUlt.Size = new System.Drawing.Size(120, 40);
            this.btDelUlt.TabIndex = 4;
            this.btDelUlt.Text = "Último";
            this.btDelUlt.UseVisualStyleBackColor = true;
            this.btDelUlt.Click += new System.EventHandler(this.btBorrarUlt_Click);
            // 
            // btDelTodo
            // 
            this.btDelTodo.Location = new System.Drawing.Point(146, 171);
            this.btDelTodo.Name = "btDelTodo";
            this.btDelTodo.Size = new System.Drawing.Size(120, 40);
            this.btDelTodo.TabIndex = 5;
            this.btDelTodo.Text = "Todos";
            this.btDelTodo.UseVisualStyleBackColor = true;
            this.btDelTodo.Click += new System.EventHandler(this.btBorrarTodos_Click);
            // 
            // gbPoints
            // 
            this.gbPoints.Controls.Add(this.lbBorrar);
            this.gbPoints.Controls.Add(this.lbxPoints);
            this.gbPoints.Controls.Add(this.btDelSelect);
            this.gbPoints.Controls.Add(this.btDelTodo);
            this.gbPoints.Controls.Add(this.btDelUlt);
            this.gbPoints.Location = new System.Drawing.Point(522, 3);
            this.gbPoints.Name = "gbPoints";
            this.gbPoints.Size = new System.Drawing.Size(276, 233);
            this.gbPoints.TabIndex = 6;
            this.gbPoints.TabStop = false;
            this.gbPoints.Text = "Puntos: 0";
            // 
            // lbBorrar
            // 
            this.lbBorrar.AutoSize = true;
            this.lbBorrar.Location = new System.Drawing.Point(187, 21);
            this.lbBorrar.Name = "lbBorrar";
            this.lbBorrar.Size = new System.Drawing.Size(44, 16);
            this.lbBorrar.TabIndex = 7;
            this.lbBorrar.Text = "Borrar";
            // 
            // lbxPoints
            // 
            this.lbxPoints.FormattingEnabled = true;
            this.lbxPoints.ItemHeight = 16;
            this.lbxPoints.Location = new System.Drawing.Point(6, 21);
            this.lbxPoints.Name = "lbxPoints";
            this.lbxPoints.Size = new System.Drawing.Size(134, 196);
            this.lbxPoints.TabIndex = 9;
            // 
            // btDelSelect
            // 
            this.btDelSelect.Location = new System.Drawing.Point(146, 110);
            this.btDelSelect.Name = "btDelSelect";
            this.btDelSelect.Size = new System.Drawing.Size(120, 40);
            this.btDelSelect.TabIndex = 6;
            this.btDelSelect.Text = "Seleccionado";
            this.btDelSelect.UseVisualStyleBackColor = true;
            this.btDelSelect.Click += new System.EventHandler(this.btBorrarSelect_Click);
            // 
            // gbEntradas
            // 
            this.gbEntradas.Controls.Add(this.nudGrado);
            this.gbEntradas.Controls.Add(this.lbGrado);
            this.gbEntradas.Controls.Add(this.lbTolerancia);
            this.gbEntradas.Controls.Add(this.tbTolerancia);
            this.gbEntradas.Controls.Add(this.lbMetodo);
            this.gbEntradas.Controls.Add(this.cbMetodos);
            this.gbEntradas.Controls.Add(this.btCalcular);
            this.gbEntradas.Controls.Add(this.btAgregar);
            this.gbEntradas.Controls.Add(this.labelx);
            this.gbEntradas.Controls.Add(this.tbx);
            this.gbEntradas.Controls.Add(this.tby);
            this.gbEntradas.Controls.Add(this.labely);
            this.gbEntradas.Location = new System.Drawing.Point(3, 3);
            this.gbEntradas.Name = "gbEntradas";
            this.gbEntradas.Size = new System.Drawing.Size(513, 135);
            this.gbEntradas.TabIndex = 7;
            this.gbEntradas.TabStop = false;
            this.gbEntradas.Text = "Entradas";
            // 
            // nudGrado
            // 
            this.nudGrado.Location = new System.Drawing.Point(214, 101);
            this.nudGrado.Name = "nudGrado";
            this.nudGrado.Size = new System.Drawing.Size(61, 22);
            this.nudGrado.TabIndex = 12;
            this.nudGrado.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lbGrado
            // 
            this.lbGrado.AutoSize = true;
            this.lbGrado.Location = new System.Drawing.Point(163, 104);
            this.lbGrado.Name = "lbGrado";
            this.lbGrado.Size = new System.Drawing.Size(48, 16);
            this.lbGrado.TabIndex = 10;
            this.lbGrado.Text = "Grado:";
            // 
            // lbTolerancia
            // 
            this.lbTolerancia.AutoSize = true;
            this.lbTolerancia.Location = new System.Drawing.Point(6, 104);
            this.lbTolerancia.Name = "lbTolerancia";
            this.lbTolerancia.Size = new System.Drawing.Size(78, 16);
            this.lbTolerancia.TabIndex = 9;
            this.lbTolerancia.Text = "Tolerancia: ";
            // 
            // tbTolerancia
            // 
            this.tbTolerancia.Location = new System.Drawing.Point(90, 101);
            this.tbTolerancia.Name = "tbTolerancia";
            this.tbTolerancia.Size = new System.Drawing.Size(67, 22);
            this.tbTolerancia.TabIndex = 8;
            this.tbTolerancia.Text = "80";
            // 
            // lbMetodo
            // 
            this.lbMetodo.AutoSize = true;
            this.lbMetodo.Location = new System.Drawing.Point(6, 66);
            this.lbMetodo.Name = "lbMetodo";
            this.lbMetodo.Size = new System.Drawing.Size(56, 16);
            this.lbMetodo.TabIndex = 7;
            this.lbMetodo.Text = "Método:";
            // 
            // cbMetodos
            // 
            this.cbMetodos.FormattingEnabled = true;
            this.cbMetodos.Items.AddRange(new object[] {
            "Regresión Lineal",
            "Regresión Polinomial"});
            this.cbMetodos.Location = new System.Drawing.Point(68, 62);
            this.cbMetodos.Name = "cbMetodos";
            this.cbMetodos.Size = new System.Drawing.Size(207, 24);
            this.cbMetodos.TabIndex = 6;
            this.cbMetodos.SelectedIndexChanged += new System.EventHandler(this.cbMetodos_SelectedIndexChanged);
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(299, 95);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 29);
            this.btCalcular.TabIndex = 5;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(299, 21);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 29);
            this.btAgregar.TabIndex = 4;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregarPunto_Click);
            // 
            // gbSalidas
            // 
            this.gbSalidas.Controls.Add(this.tbEfecAjuste);
            this.gbSalidas.Controls.Add(this.lbEfecAjuste);
            this.gbSalidas.Controls.Add(this.lbEfectividad);
            this.gbSalidas.Controls.Add(this.tbEfectividad);
            this.gbSalidas.Controls.Add(this.tbFuncion);
            this.gbSalidas.Controls.Add(this.label1);
            this.gbSalidas.Location = new System.Drawing.Point(3, 144);
            this.gbSalidas.Name = "gbSalidas";
            this.gbSalidas.Size = new System.Drawing.Size(513, 92);
            this.gbSalidas.TabIndex = 8;
            this.gbSalidas.TabStop = false;
            this.gbSalidas.Text = "Salidas";
            // 
            // tbEfecAjuste
            // 
            this.tbEfecAjuste.Location = new System.Drawing.Point(357, 52);
            this.tbEfecAjuste.Name = "tbEfecAjuste";
            this.tbEfecAjuste.Size = new System.Drawing.Size(145, 22);
            this.tbEfecAjuste.TabIndex = 5;
            // 
            // lbEfecAjuste
            // 
            this.lbEfecAjuste.AutoSize = true;
            this.lbEfecAjuste.Location = new System.Drawing.Point(213, 55);
            this.lbEfecAjuste.Name = "lbEfecAjuste";
            this.lbEfecAjuste.Size = new System.Drawing.Size(138, 16);
            this.lbEfecAjuste.TabIndex = 4;
            this.lbEfecAjuste.Text = "Efectividad del ajuste:";
            // 
            // lbEfectividad
            // 
            this.lbEfectividad.AutoSize = true;
            this.lbEfectividad.Location = new System.Drawing.Point(9, 55);
            this.lbEfectividad.Name = "lbEfectividad";
            this.lbEfectividad.Size = new System.Drawing.Size(92, 16);
            this.lbEfectividad.TabIndex = 3;
            this.lbEfectividad.Text = "Efectividad %:";
            // 
            // tbEfectividad
            // 
            this.tbEfectividad.Location = new System.Drawing.Point(108, 52);
            this.tbEfectividad.Name = "tbEfectividad";
            this.tbEfectividad.Size = new System.Drawing.Size(92, 22);
            this.tbEfectividad.TabIndex = 2;
            // 
            // tbFuncion
            // 
            this.tbFuncion.Location = new System.Drawing.Point(72, 21);
            this.tbFuncion.Name = "tbFuncion";
            this.tbFuncion.Size = new System.Drawing.Size(430, 22);
            this.tbFuncion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Función:";
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(3, 460);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(75, 29);
            this.btVolver.TabIndex = 9;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // pnlGrafica
            // 
            this.pnlGrafica.Location = new System.Drawing.Point(3, 243);
            this.pnlGrafica.Name = "pnlGrafica";
            this.pnlGrafica.Size = new System.Drawing.Size(795, 211);
            this.pnlGrafica.TabIndex = 10;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(723, 460);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 29);
            this.btLimpiar.TabIndex = 11;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // AjusteCurvasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.pnlGrafica);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.gbSalidas);
            this.Controls.Add(this.gbEntradas);
            this.Controls.Add(this.gbPoints);
            this.Name = "AjusteCurvasForm";
            this.Text = "AjusteCurvasForm";
            this.gbPoints.ResumeLayout(false);
            this.gbPoints.PerformLayout();
            this.gbEntradas.ResumeLayout(false);
            this.gbEntradas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrado)).EndInit();
            this.gbSalidas.ResumeLayout(false);
            this.gbSalidas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbx;
        private System.Windows.Forms.TextBox tby;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.Label labely;
        private System.Windows.Forms.Button btDelUlt;
        private System.Windows.Forms.Button btDelTodo;
        private System.Windows.Forms.GroupBox gbPoints;
        private System.Windows.Forms.Button btDelSelect;
        private System.Windows.Forms.Label lbBorrar;
        private System.Windows.Forms.GroupBox gbEntradas;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lbMetodo;
        private System.Windows.Forms.ComboBox cbMetodos;
        private System.Windows.Forms.ListBox lbxPoints;
        private System.Windows.Forms.GroupBox gbSalidas;
        private System.Windows.Forms.TextBox tbFuncion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Label lbTolerancia;
        private System.Windows.Forms.TextBox tbTolerancia;
        private System.Windows.Forms.Label lbGrado;
        private System.Windows.Forms.Label lbEfecAjuste;
        private System.Windows.Forms.Label lbEfectividad;
        private System.Windows.Forms.TextBox tbEfectividad;
        private System.Windows.Forms.TextBox tbEfecAjuste;
        private System.Windows.Forms.NumericUpDown nudGrado;
        private System.Windows.Forms.Panel pnlGrafica;
        private System.Windows.Forms.Button btLimpiar;
    }
}