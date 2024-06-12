using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaicesDeFunciones.Integracion_Numerica
{
    public partial class IntegracionNumForm : Form
    {
        public IntegracionNumForm()
        {
            InitializeComponent();
        }

        Logica calc = new Logica();

        private void btCalcular_Click(object sender, EventArgs e)
        {
            Input input = new Input();
            input.fx = txtFx.Text;
            input.a = double.Parse(txtA.Text);
            input.b = double.Parse(txtB.Text);
            input.cantSubintervalos = Convert.ToInt32(nudCantSI.Value); // ver en los casos que no se usa setear 0
            input.nuevoA = double.NaN;

            // validar si la función está bien ingresada
            if (calc.Sintaxis(input.fx,'x'))
            {
                double result = 0;
                switch(cbMetodos.SelectedIndex)
                {
                    case 0:
                        result = calc.TrapeciosSimple(input);
                        break;
                    case 1:
                        result = calc.TrapeciosMultiples(input);
                        break;
                    case 2:
                        result = calc.SimpsonSimple(input);
                        break;
                    case 3:
                        result = calc.SimpsonMultiple(input);
                        break;
                    case 4:
                        result = calc.Simpson38Simple(input);   
                        break;
                }

                txtArea.Text = Math.Round(result,4).ToString();
            }
            else
            {
                MessageBox.Show("La sintaxis de la función ingresada es incorrecta. Vuelva a ingresarla", "Error de sintaxis");
                txtFx.Clear();
            }
        }

        private void cbMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbMetodos.SelectedIndex == 0 || cbMetodos.SelectedIndex == 2 || cbMetodos.SelectedIndex == 4)
            {
                nudCantSI.Enabled = false;
            }
            else
            {
                nudCantSI.Enabled = true;
            }
            if (cbMetodos.SelectedIndex == 3)
            {
                nudCantSI.Value = 2;
                nudCantSI.Increment = 2;
            }
            if (cbMetodos.SelectedIndex == 1)
            {
                nudCantSI.Increment = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio irInicio = new Inicio();
            irInicio.Show();
            this.Hide();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txtFx.Clear();
            txtA.Clear();
            txtB.Clear();
            cbMetodos.SelectedIndex = -1;
            nudCantSI.Enabled = true;
            nudCantSI.Value = 0;
            txtArea.Clear();
        }
    }
}


