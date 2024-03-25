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

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            //deshabilitar xd en tangente textbox.enable = false
            // Controlar campos vacíos
            // Ordenar variables y después asignaciones
            Calculo analizadorFuncion = new Calculo();
            MetodoRaiz metodoRaiz = new MetodoRaiz();
            string metodo,funcion;
            //metodo = listaMetodos.SelectedValue.ToString();
            metodo = comboMetodos.Text;
            funcion = textFuncion.Text;
            double xi,xd,fx,xr, tolerancia;
            int cantIteracion;
            xi = Convert.ToDouble(textXi.Text);
            xd = Convert.ToDouble(textXd.Text);
            cantIteracion = Convert.ToInt32(textIteracion.Text);
            tolerancia = Convert.ToDouble(textTolerancia.Text);

            if (analizadorFuncion.Sintaxis(funcion, 'x')) 
            {
                fx = analizadorFuncion.EvaluaFx(xi) * analizadorFuncion.EvaluaFx(xd);
                this.metodo.Text = fx+"";
                // Evaluar fx
                if (fx > 0)
                {
                    MessageBox.Show(string.Format("El intervalo [{0},{1}] no contiene a la raíz. Volver a ingresar xi y xd", xi, xd));
                    //Limpia los textBox
                    textXi.Clear();
                    textXd.Clear();
                }
                else if (fx == 0) // debe cortar
                {
                    if (analizadorFuncion.EvaluaFx(xi) == 0)
                    {
                        //Asignar a xr xi y mostrar el valor en la salida
                        MessageBox.Show("xi = " + xi + ", es raíz", "Ejecución exitosa");
                    }
                    else
                    {
                        MessageBox.Show("xd = " + xd + ", es raíz", "Ejecución exitosa");
                    }
                }
                else // fx < 0
                {
                    double xrAnt,error;
                    xr = 0;
                    xrAnt = 0;
                    for (int i = 0; i < cantIteracion; i++)
                    {
                        //llamar a método calcularXr y a método calcularError
                        xr = metodoRaiz.CalcularXr(metodo, funcion, xi, xd);
                        error = metodoRaiz.CalcularError(xr, xrAnt);

                        if (Math.Abs(analizadorFuncion.EvaluaFx(xr)) < tolerancia || error < tolerancia) //Debe cortar
                        {
                            MessageBox.Show("xr = " + xr + ", es raíz", "Ejecución exitosa");
                            break;
                        } 
                        else if (analizadorFuncion.EvaluaFx(xi) * analizadorFuncion.EvaluaFx(xr) > 0)
                        {
                            xi = xr;
                        }
                        else
                        {
                            xd = xr;
                        }
                        xrAnt = xr;
                    }
                    //devolver xr como raíz, iteraciones y error
                    MessageBox.Show("Xr = " + xr + ", es raíz porque se superó la cantidad de iteraciones","Ejecución finalizada");
                }
            }
            else
            {
                MessageBox.Show("La sintaxis de la función ingresada es incorrecta","Error de sintaxis");
                textFuncion.Clear();
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            Inicio irInicio = new Inicio();
            irInicio.Show();
            this.Hide();
        }
    }
}
