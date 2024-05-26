using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaicesDeFunciones.Ajuste_de_Curvas
{
    public partial class AjusteCurvasForm : Form
    {
        public AjusteCurvasForm()
        {
            InitializeComponent();
        }

        public List<double[]> PuntosCargados { get; set; }

        private void RefreshListBox()
        { 
            lbxPoints.Items.Clear();
            foreach (double[] punto in PuntosCargados)
            {
                lbxPoints.Items.Add($"({punto[0]}, {punto[1]})");
            }
            lbxPoints.Text = $"Puntos: {PuntosCargados.Count}";
        }

        // Agregar un punto
        private void btAgregarPunto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbx.Text) && !string.IsNullOrEmpty(tby.Text))
            {
                double[] punto = new double[2] { double.Parse(tbx.Text), double.Parse(tby.Text) };
                if (PuntosCargados == null)
                {
                    PuntosCargados = new List<double[]>();
                }
                PuntosCargados.Add(punto);
            }
            RefreshListBox();

            tbx.Text = "";
            tby.Text = "";
            tbx.Select();
        }

        // Borrar último punto
        private void btBorrarUlt_Click(object sender, EventArgs e)
        {
            PuntosCargados.RemoveAt(PuntosCargados.Count - 1);
            RefreshListBox();
        }

        // Borrar todos los puntos
        private void btBorrarTodos_Click(object sender, EventArgs e)
        {
            //Agregar mensaje de confirmación
            PuntosCargados.Clear();
            RefreshListBox();
        }

        // Borrar punto seleccionado
        private void btBorrarSelect_Click(object sender, EventArgs e)
        {
            PuntosCargados.RemoveAt(lbxPoints.SelectedIndex);
            RefreshListBox();
        }

        // botón calcular
        // Llamaría a Resolución con la entrada y el int del método

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
