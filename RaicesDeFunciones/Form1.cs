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
            // Ordenar variables aluaFx()y después asignaciones
            Calculo analizadorFuncion = new Calculo();
            MetodoRaiz metodoRaiz = new MetodoRaiz();
            string metodo,funcion;
            //metodo = listaMetodos.SelectedValue.ToString();
            metodo = comboMetodos.Text;
            funcion = textFuncion.Text;
            double xi,xd,fx,xr,tolerancia,xrAnt,error;
            xr = 0;
            xrAnt = 0;
            error = 0;
            int iteraciones;
            xi = Convert.ToDouble(textXi.Text);
            xd = Convert.ToDouble(textXd.Text);
            iteraciones = Convert.ToInt32(textIteracion.Text);
            tolerancia = Convert.ToDouble(textTolerancia.Text);
            int i;
            i = 0;
            textBoxMetodo.Text = metodo;
            
            // Comprobar campos vacíos
            if (analizadorFuncion.Sintaxis(funcion, 'x')) 
            {
                if (metodo == "Bisección" || metodo == "Regla falsa")
                {
                    fx = analizadorFuncion.EvaluaFx(xi) * analizadorFuncion.EvaluaFx(xd);
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
                            //Asignar xi y xd al textbox de raíz
                            textBoxRaiz.Text = xi.ToString();
                            textBoxConverge.Text = "Si";
                            textBoxCantIteracion.Text = "0";
                            textBoxError.Text = error.ToString();
                            MessageBox.Show("xi = " + xi + ", es raíz", "Ejecución exitosa");
                        }
                        else
                        {
                            textBoxRaiz.Text = xd.ToString();
                            textBoxConverge.Text = "Si";
                            textBoxCantIteracion.Text = "0";
                            textBoxError.Text = error.ToString();
                            MessageBox.Show("xd = " + xd + ", es raíz", "Ejecución exitosa");
                        }
                    }
                    else // fx < 0
                    {
                        for (i = 1; i <= iteraciones; i++)
                        {
                            //llamar a método calcularXr y a método calcularError
                            xr = metodoRaiz.CalcularXr(metodo, funcion, xi, xd);
                            error = metodoRaiz.CalcularError(xr, xrAnt);

                            if (Math.Abs(analizadorFuncion.EvaluaFx(xr)) < tolerancia || error < tolerancia) //Debe cortar
                            {
                                textBoxRaiz.Text = xr.ToString();
                                textBoxConverge.Text = "Si";
                                textBoxCantIteracion.Text = i.ToString();
                                textBoxError.Text = error.ToString();
                                MessageBox.Show("xr = " + xr + " es raíz", "Ejecución exitosa");
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
                        //if i = cant iteraciones mostrar
                        //textBoxRaiz.Text = xr.ToString();
                        //textBoxConverge.Text = "Si";
                        //MessageBox.Show("Xr = " + xr + ", es raíz porque se superó la cantidad de iteraciones","Ejecución finalizada");   
                    }
                    //textBoxRaiz.Text = xr.ToString();
                    //textBoxConverge.Text = "Si";
                    //MessageBox.Show("Xr = " + xr + ", es raíz porque se superó la cantidad de iteraciones", "Ejecución finalizada");
                }
                else // método == Tangente || método == Secante
                {
                    if (Math.Abs(analizadorFuncion.EvaluaFx(xi)) < tolerancia)
                    {
                        textBoxRaiz.Text = xi.ToString();
                        MessageBox.Show("xi = " + xi + ", es raíz", "Ejecución exitosa");
                    }
                    else if (metodo == "Secante" && Math.Abs(analizadorFuncion.EvaluaFx(xd)) < tolerancia)
                    {
                        textBoxRaiz.Text = xd.ToString();
                        MessageBox.Show("xd = " + xd + ", es raíz", "Ejecución exitosa");
                    }
                    else
                    {
                        for(i = 0; i < iteraciones; i++)
                        {
                            xr = metodoRaiz.CalcularXr(metodo, funcion, xi, xd);
                            if (double.IsNaN(xr))
                            {
                                MessageBox.Show("El método es divergente. No encuentra raíz");
                                textBoxConverge.Text = "No";
                                break;
                            }
                            error = metodoRaiz.CalcularError(xr, xrAnt);
                            if (Math.Abs(analizadorFuncion.EvaluaFx(xr)) < tolerancia || error < tolerancia)
                            {
                                MessageBox.Show("xr = " + xr + ", es raíz", "Ejecución exitosa");
                                textBoxRaiz.Text = xr.ToString();
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
                        MessageBox.Show("Xr = " + xr + ", es raíz porque se superó la cantidad de iteraciones", "Ejecución finalizada");
                        textBoxRaiz.Text = xr.ToString();
                    }
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

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            // Agregar clear
            // Iniciar todas las variables en 0
        }
    }
}
