namespace RaicesDeFunciones
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
            this.buttonMetCerrados = new System.Windows.Forms.Button();
            this.buttonMetAbiertos = new System.Windows.Forms.Button();
            this.imagen = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonMetCerrados);
            this.panel2.Controls.Add(this.buttonMetAbiertos);
            this.panel2.Location = new System.Drawing.Point(1, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 389);
            this.panel2.TabIndex = 1;
            // 
            // buttonMetCerrados
            // 
            this.buttonMetCerrados.Location = new System.Drawing.Point(36, 176);
            this.buttonMetCerrados.Name = "buttonMetCerrados";
            this.buttonMetCerrados.Size = new System.Drawing.Size(135, 40);
            this.buttonMetCerrados.TabIndex = 1;
            this.buttonMetCerrados.Text = "Métodos Cerrados";
            this.buttonMetCerrados.UseVisualStyleBackColor = true;
            this.buttonMetCerrados.Click += new System.EventHandler(this.MetCerrados_Click);
            // 
            // buttonMetAbiertos
            // 
            this.buttonMetAbiertos.Location = new System.Drawing.Point(36, 116);
            this.buttonMetAbiertos.Name = "buttonMetAbiertos";
            this.buttonMetAbiertos.Size = new System.Drawing.Size(135, 40);
            this.buttonMetAbiertos.TabIndex = 0;
            this.buttonMetAbiertos.Text = "Métodos Abiertos";
            this.buttonMetAbiertos.UseVisualStyleBackColor = true;
            this.buttonMetAbiertos.Click += new System.EventHandler(this.MetAbiertos_Click);
            // 
            // imagen
            // 
            this.imagen.Location = new System.Drawing.Point(207, 58);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(592, 389);
            this.imagen.TabIndex = 2;
            this.imagen.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
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
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel imagen;
        private System.Windows.Forms.Button buttonMetAbiertos;
        private System.Windows.Forms.Button buttonMetCerrados;
    }
}