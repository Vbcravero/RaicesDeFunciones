﻿namespace RaicesDeFunciones
{
    partial class Inicio
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAjusteCurva = new System.Windows.Forms.Button();
            this.buttonMatrices = new System.Windows.Forms.Button();
            this.buttonRaizFx = new System.Windows.Forms.Button();
            this.imagen = new System.Windows.Forms.Panel();
            this.buttonIntegracionNum = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonIntegracionNum);
            this.panel2.Controls.Add(this.buttonAjusteCurva);
            this.panel2.Controls.Add(this.buttonMatrices);
            this.panel2.Controls.Add(this.buttonRaizFx);
            this.panel2.Location = new System.Drawing.Point(1, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 389);
            this.panel2.TabIndex = 1;
            // 
            // buttonAjusteCurva
            // 
            this.buttonAjusteCurva.Location = new System.Drawing.Point(27, 225);
            this.buttonAjusteCurva.Name = "buttonAjusteCurva";
            this.buttonAjusteCurva.Size = new System.Drawing.Size(150, 40);
            this.buttonAjusteCurva.TabIndex = 2;
            this.buttonAjusteCurva.Text = "Ajuste de Curvas";
            this.buttonAjusteCurva.UseVisualStyleBackColor = true;
            this.buttonAjusteCurva.Click += new System.EventHandler(this.AjusteCurva_Click);
            // 
            // buttonMatrices
            // 
            this.buttonMatrices.Location = new System.Drawing.Point(27, 167);
            this.buttonMatrices.Name = "buttonMatrices";
            this.buttonMatrices.Size = new System.Drawing.Size(150, 40);
            this.buttonMatrices.TabIndex = 1;
            this.buttonMatrices.Text = "Sistemas de Ecuaciones";
            this.buttonMatrices.UseVisualStyleBackColor = true;
            this.buttonMatrices.Click += new System.EventHandler(this.SistEcuaciones_Click);
            // 
            // buttonRaizFx
            // 
            this.buttonRaizFx.Location = new System.Drawing.Point(27, 112);
            this.buttonRaizFx.Name = "buttonRaizFx";
            this.buttonRaizFx.Size = new System.Drawing.Size(150, 40);
            this.buttonRaizFx.TabIndex = 0;
            this.buttonRaizFx.Text = "Raíces de Funciones";
            this.buttonRaizFx.UseVisualStyleBackColor = true;
            this.buttonRaizFx.Click += new System.EventHandler(this.RaicesFx_Click);
            // 
            // imagen
            // 
            this.imagen.Location = new System.Drawing.Point(207, 58);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(592, 389);
            this.imagen.TabIndex = 2;
            this.imagen.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // buttonIntegracionNum
            // 
            this.buttonIntegracionNum.Location = new System.Drawing.Point(27, 284);
            this.buttonIntegracionNum.Name = "buttonIntegracionNum";
            this.buttonIntegracionNum.Size = new System.Drawing.Size(150, 40);
            this.buttonIntegracionNum.TabIndex = 3;
            this.buttonIntegracionNum.Text = "Integración Numérica";
            this.buttonIntegracionNum.UseVisualStyleBackColor = true;
            this.buttonIntegracionNum.Click += new System.EventHandler(this.buttonIntegracionNum_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.panel2);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel imagen;
        private System.Windows.Forms.Button buttonRaizFx;
        private System.Windows.Forms.Button buttonMatrices;
        private System.Windows.Forms.Button buttonAjusteCurva;
        private System.Windows.Forms.Button buttonIntegracionNum;
    }
}