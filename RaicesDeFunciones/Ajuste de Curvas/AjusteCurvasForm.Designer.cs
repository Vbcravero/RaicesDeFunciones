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
            this.lbMetodo = new System.Windows.Forms.Label();
            this.cbMetodos = new System.Windows.Forms.ComboBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.gbSalidas = new System.Windows.Forms.GroupBox();
            this.tbFuncion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btVolver = new System.Windows.Forms.Button();
            this.gbPoints.SuspendLayout();
            this.gbEntradas.SuspendLayout();
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
            this.btDelUlt.Location = new System.Drawing.Point(146, 70);
            this.btDelUlt.Name = "btDelUlt";
            this.btDelUlt.Size = new System.Drawing.Size(120, 40);
            this.btDelUlt.TabIndex = 4;
            this.btDelUlt.Text = "Último";
            this.btDelUlt.UseVisualStyleBackColor = true;
            this.btDelUlt.Click += new System.EventHandler(this.btBorrarUlt_Click);
            // 
            // btDelTodo
            // 
            this.btDelTodo.Location = new System.Drawing.Point(146, 181);
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
            this.gbPoints.Size = new System.Drawing.Size(276, 250);
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
            this.lbxPoints.Size = new System.Drawing.Size(134, 212);
            this.lbxPoints.TabIndex = 9;
            // 
            // btDelSelect
            // 
            this.btDelSelect.Location = new System.Drawing.Point(146, 126);
            this.btDelSelect.Name = "btDelSelect";
            this.btDelSelect.Size = new System.Drawing.Size(120, 40);
            this.btDelSelect.TabIndex = 6;
            this.btDelSelect.Text = "Seleccionado";
            this.btDelSelect.UseVisualStyleBackColor = true;
            this.btDelSelect.Click += new System.EventHandler(this.btBorrarSelect_Click);
            // 
            // gbEntradas
            // 
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
            "Regresión lineal"});
            this.cbMetodos.Location = new System.Drawing.Point(68, 62);
            this.cbMetodos.Name = "cbMetodos";
            this.cbMetodos.Size = new System.Drawing.Size(207, 24);
            this.cbMetodos.TabIndex = 6;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(299, 60);
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
            this.gbSalidas.Controls.Add(this.tbFuncion);
            this.gbSalidas.Controls.Add(this.label1);
            this.gbSalidas.Location = new System.Drawing.Point(3, 144);
            this.gbSalidas.Name = "gbSalidas";
            this.gbSalidas.Size = new System.Drawing.Size(513, 109);
            this.gbSalidas.TabIndex = 8;
            this.gbSalidas.TabStop = false;
            this.gbSalidas.Text = "Salidas";
            // 
            // tbFuncion
            // 
            this.tbFuncion.Location = new System.Drawing.Point(68, 21);
            this.tbFuncion.Name = "tbFuncion";
            this.tbFuncion.Size = new System.Drawing.Size(434, 22);
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
            this.btVolver.Location = new System.Drawing.Point(712, 415);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(75, 23);
            this.btVolver.TabIndex = 9;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            // 
            // AjusteCurvasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}