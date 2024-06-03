using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RaicesDeFunciones.Ajuste_de_Curvas.Procedimiento;
using Analisis_Numerico;

namespace RaicesDeFunciones.Ajuste_de_Curvas
{
    public partial class AjusteCurvasForm : Form
    {
        Graficador graficador = new Graficador();
        public AjusteCurvasForm()
        {
            InitializeComponent();
            SetPanelGrafica();
        }

        private void SetPanelGrafica()
        {
            pnlGrafica.Controls.Clear();
            this.graficador = new Graficador();
            pnlGrafica.Controls.Add(graficador);
            graficador.Dock = DockStyle.Fill;
        }

        public List<double[]> PuntosCargados { get; set; }

        private void RefreshListBox()
        {
            lbxPoints.Items.Clear();
            foreach (double[] punto in PuntosCargados)
            {
                lbxPoints.Items.Add($"({punto[0]}, {punto[1]})");
            }
            gbPoints.Text = $"Puntos: {PuntosCargados.Count}";
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
            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar todos los puntos?", "Confirmar eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
                PuntosCargados.Clear();
            RefreshListBox();
        }

        // Borrar punto seleccionado
        private void btBorrarSelect_Click(object sender, EventArgs e)
        {
            PuntosCargados.RemoveAt(lbxPoints.SelectedIndex);
            RefreshListBox();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            Procedimiento.Entrada entrada = new Procedimiento.Entrada();
            entrada.PuntosCargados = PuntosCargados;
            entrada.Tolerancia = double.Parse(tbTolerancia.Text);
            entrada.Grado = cbMetodos.SelectedIndex == 1 ? Convert.ToInt32(nudGrado.Value) : 0;

            switch (cbMetodos.SelectedIndex)
            {
                case 0:
                    MostrarResultados(Resolucion(entrada, 0));
                    break;
                case 1:
                    MostrarResultados(Resolucion(entrada, 1));
                    break;
                default:
                    break;
            }
        }

        private void MostrarResultados(Salida salida)
        {
            // ver el mensaje de error
            tbFuncion.Text = salida.Funcion;
            tbEfectividad.Text = salida.CoefCorrelacion.ToString();
            tbEfecAjuste.Text = salida.EfectividadAjuste ? "Aceptable" : "No Aceptable";

            graficador.Graficar(PuntosCargados, salida.FuncionGraficador);
        }

        // Botón limpiar

        private void cbMetodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMetodos.SelectedIndex == 0)
            {
                nudGrado.Enabled = false;
            }
            if (cbMetodos.SelectedIndex == 1)
            {
                nudGrado.Enabled = true;
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Inicio irInicio = new Inicio();
            irInicio.Show();
            this.Hide();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            cbMetodos.SelectedIndex = -1;
            tbFuncion.Clear();
            tbEfectividad.Clear();
            tbEfecAjuste.Clear();
            PuntosCargados.Clear();
            RefreshListBox();
            SetPanelGrafica();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
