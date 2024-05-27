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
            // Asignar el resto de atributos de entrada
            switch (cbMetodos.SelectedIndex)
            {
                case 0:
                    MostrarResultados(Resolucion(entrada,0));
                    break;
                case 1:
                    MostrarResultados(Resolucion(entrada,1));
                    break;
                default:
                    break;
            }
        }

        private void MostrarResultados(Salida salida)
        {
            tbFuncion.Text = salida.Funcion;
            //Agregar lógica restante
        }

        // Método para desahabilitar entradas según método elegido
        // Botón limpiar
        // Botón volver
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
