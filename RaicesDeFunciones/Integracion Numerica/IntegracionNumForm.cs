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

            // validar si la función está bien ingresada
            if (calc.Sintaxis(input.fx,'x'))
            {

            }
        }
    }
}
