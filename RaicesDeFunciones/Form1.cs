using Calculus;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        Calc analizaFuncion = new Calc();

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            // Controlar campos vacíos
            if (string.IsNullOrEmpty(textFuncion.Text) || string.IsNullOrEmpty(textXi.Text) || (string.IsNullOrEmpty(textXd.Text) && comboMetodos.SelectedItem.ToString() != "Tangente") || comboMetodos.SelectedIndex == -1)
            {
                MessageBox.Show("Asegúrese de completar todos los datos de entrada","Campos vacíos");
            }
            else
            {
                //Declaración y asignación de variables
                string metodo, funcion;
                metodo = comboMetodos.Text;
                funcion = textFuncion.Text;
                double fx,xi,xd,xr,tolerancia,xrAnt,error;
                xi = Convert.ToDouble(textXi.Text);
                xd = string.IsNullOrEmpty(textXd.Text) ? 0 : Convert.ToDouble(textXd.Text);
                tolerancia = Convert.ToDouble(textTolerancia.Text) * 0.01 / 100;
                xr = 0;
                xrAnt = 0;
                error = 0;
                int iteraciones, i;
                iteraciones = Convert.ToInt32(textIteracion.Text);
                i = 0;

            
                if (analizaFuncion.Sintaxis(funcion, 'x')) 
                {
                    textBoxMetodo.Text = metodo;
                    if (metodo == "Bisección" || metodo == "Regla falsa")
                    {
                        fx = analizaFuncion.EvaluaFx(xi) * analizaFuncion.EvaluaFx(xd);
                        // Evaluar fx
                        if (fx > 0)
                        {
                            MessageBox.Show(string.Format("El intervalo [{0},{1}] no contiene a la raíz. Volver a ingresar xi y xd", xi, xd));
                            //Limpia los textBox
                            textXi.Clear();
                            textXd.Clear();
                        }
                        else if (fx == 0) //xi o xd es raíz
                        {
                            if (analizaFuncion.EvaluaFx(xi) == 0)
                            {
                                textBoxRaiz.Text = xi.ToString();
                                textBoxConverge.Text = "Si";
                                textBoxCantIteracion.Text = "0";
                                textBoxError.Text = error.ToString();
                                MessageBox.Show("xi = " + xi + " es raíz", "Ejecución exitosa");
                            }
                            else
                            {
                                textBoxRaiz.Text = xd.ToString();
                                textBoxConverge.Text = "Si";
                                textBoxCantIteracion.Text = "0";
                                textBoxError.Text = error.ToString();
                                MessageBox.Show("xd = " + xd + " es raíz", "Ejecución exitosa");
                            }
                        }
                        else // fx < 0
                        {
                            for (i = 1; i <= iteraciones; i++)
                            {
                                //llamar a método calcularXr y a método calcularError
                                xr = analizaFuncion.CalcularXr(metodo, funcion, xi, xd);
                                error = analizaFuncion.CalcularError(xr, xrAnt);

                                if (Math.Abs(analizaFuncion.EvaluaFx(xr)) < tolerancia || error < tolerancia) //Debe cortar
                                {
                                    textBoxRaiz.Text = xr.ToString();
                                    textBoxConverge.Text = "Si";
                                    textBoxCantIteracion.Text = i.ToString();
                                    textBoxError.Text = error.ToString();
                                    MessageBox.Show("xr = " + xr + " es raíz", "Ejecución exitosa");
                                    break;
                                } 
                                else if (analizaFuncion.EvaluaFx(xi) * analizaFuncion.EvaluaFx(xr) > 0)
                                {
                                    xi = xr;
                                }
                                else
                                {
                                    xd = xr;
                                }
                                xrAnt = xr;
                            }
                            if (i > iteraciones)
                            {
                                textBoxRaiz.Text = xr.ToString();
                                textBoxConverge.Text = "Si";
                                textBoxCantIteracion.Text = (i-1).ToString();
                                textBoxError.Text = error.ToString();
                                MessageBox.Show(string.Format("Se toma como raíz xr = {0} porque se alcanzó el máximo de iteraciones ({1})", xr, iteraciones));
                            }
                        }
                    }
                    else // método == Tangente || método == Secante
                    {
                        if (Math.Abs(analizaFuncion.EvaluaFx(xi)) < tolerancia)
                        {
                            textBoxRaiz.Text = xi.ToString();
                            textBoxConverge.Text = "Si";
                            textBoxCantIteracion.Text = "0";
                            textBoxError.Text = error.ToString();
                            MessageBox.Show("xi = " + xi + " es raíz", "Ejecución exitosa");
                        }
                        else if (metodo == "Secante" && Math.Abs(analizaFuncion.EvaluaFx(xd)) < tolerancia)
                        {
                            textBoxRaiz.Text = xd.ToString();
                            textBoxConverge.Text = "Si";
                            textBoxCantIteracion.Text = "0";
                            textBoxError.Text = error.ToString();
                            MessageBox.Show("xd = " + xd + " es raíz", "Ejecución exitosa");
                        }
                        else
                        {
                            for(i = 1; i <= iteraciones; i++)
                            {
                                xr = analizaFuncion.CalcularXr(metodo, funcion, xi, xd);
                                if (double.IsNaN(xr))
                                {
                                    textBoxRaiz.Text = xr.ToString();
                                    textBoxConverge.Text = "No";
                                    textBoxCantIteracion.Text = i.ToString();
                                    textBoxError.Text = error.ToString();
                                    MessageBox.Show("El método es divergente. No encuentra raíz");
                                    break;
                                }
                                error = analizaFuncion.CalcularError(xr, xrAnt);
                                if (Math.Abs(analizaFuncion.EvaluaFx(xr)) < tolerancia || error < tolerancia)
                                {
                                    textBoxRaiz.Text = xr.ToString();
                                    textBoxConverge.Text = "Si";
                                    textBoxCantIteracion.Text = i.ToString();
                                    textBoxError.Text = error.ToString();
                                    MessageBox.Show("xr = " + xr + " es raíz", "Ejecución exitosa");
                                    break;
                                }
                                else if (metodo == "Tangente")
                                {
                                    xi = xr;
                                }
                                else
                                {
                                    xi = xd;
                                    xd = xr;
                                }
                                xrAnt = xr;
                            }
                            if (i > iteraciones)
                            {
                                textBoxRaiz.Text = xr.ToString();
                                textBoxConverge.Text = "Si";
                                textBoxCantIteracion.Text = (i - 1).ToString();
                                textBoxError.Text = error.ToString();
                                MessageBox.Show(string.Format("Se toma como raíz xr = {0} porque se alcanzó el máximo de iteraciones ({1})", xr, iteraciones));
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La sintaxis de la función ingresada es incorrecta. Vuelva a ingresarla","Error de sintaxis");
                    textFuncion.Clear();
                }
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar textBox
            textFuncion.Clear();
            textXi.Clear();
            textXd.Clear();
            comboMetodos.SelectedIndex = -1;
            textBoxMetodo.Clear();
            textBoxConverge.Clear();
            textBoxCantIteracion.Clear();
            textBoxRaiz.Clear();
            textBoxError.Clear();
            textXd.Enabled = true;
        }

        private void comboMetodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMetodos.SelectedItem != null) //&& textXd != null)
            {
                if (comboMetodos.SelectedItem.ToString() == "Tangente")
                {
                    textXd.Enabled = false;
                }
            }

        }
    }
}
