using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaicesDeFunciones
{
    public partial class Matriz : Form
    {
        public Matriz()
        {
            InitializeComponent();
        }

        private void labelMetodo_Click(object sender, EventArgs e)
        {

        }

        private void buttonGenerar_Click(object sender, EventArgs e)
        {   
            int dimension = Convert.ToInt32(textDimension.Text);

            if (dimension <= 0 || dimension > 8 ) 
            {
                MessageBox.Show("La dimensión ingresada para la matriz no es válida", "Dimensión inválida");
                textDimension.Clear();
            }
            else 
            { 
                int pointX = 30;
                int pointY = 40;
                int textBoxWidth = 40; //ancho
                int textBoxHeight = 20;// Alto
                panelMatriz.Controls.Clear();
            

                int i, j;

                for(i = 0; i < dimension; i++) 
                {
                    for (j = 0; j < dimension + 1; j++)
                    {
                        TextBox a = new TextBox();
                        a.Text = "";
                        a.Size = new Size(textBoxWidth, textBoxHeight);
                        a.Location = new Point(pointX + j * (textBoxWidth + 5), pointY + i * (textBoxHeight + 5)); //30 +
                        a.Name = Convert.ToString($"{i},{j}");
                        //textBoxMatrix[i, j] = a;
                        panelMatriz.Controls.Add(a);

                        ToolTip toolTip = new ToolTip();
                        toolTip.SetToolTip(a, $"{i},{j}");
                    }
                }
            }
        }
    }
}
