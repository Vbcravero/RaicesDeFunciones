using RaicesDeFunciones.Sistemas_de_Ecuaciones;
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

        Logica logica = new Logica();

        private void labelMetodo_Click(object sender, EventArgs e)
        {

        }

        private void buttonGenerar_Click(object sender, EventArgs e)
        {   
            int dimension = Convert.ToInt32(textDimension.Text);
            // Validar que el valor indicado sea un entero
            if (dimension <= 0 || dimension > 8 ) 
            {
                MessageBox.Show("La dimensión ingresada para la matriz no es válida", "Dimensión inválida");
                textDimension.Clear();
            }
            else 
            { 
                int pointX = 30;
                int pointY = 40;
                int textBoxWidth = 60; //ancho
                int textBoxHeight = 20;// Alto
                panelMatriz.Controls.Clear();
                int row, col;

                for(row = 0; row < dimension; row++) 
                {
                    for (col = 0; col < dimension + 1; col++)
                    {
                        string nombre = $"{row},{col}"; // Nombre para TextBox y ToolTip

                        TextBox a = new TextBox();
                        a.Name = nombre;
                        a.Text = "";
                        a.Size = new Size(textBoxWidth, textBoxHeight);
                        a.Location = new Point(pointX + col * (textBoxWidth + 5), pointY + row * (textBoxHeight + 5));
                        //a.Location = new Point(pointX, pointY);
                        
                        
                        ToolTip toolTip = new ToolTip();
                        toolTip.SetToolTip(a, nombre);
                        panelMatriz.Controls.Add(a);
                        panelMatriz.Show();

                        if (col == dimension)
                        {
                            a.BackColor = Color.LightSkyBlue;
                        }
                        
                        // Ver Location
                        // método guardar matriz dentro del form Matriz
                        // Clase nueva para los métodos
                        // Acomodar Form Inicio y Program
                    }
                }
            }
        }
        
        public double [,] GuardarMatriz(int dimension)
        {
            double[,] matriz = new double[dimension, dimension + 1];

            for(int row = 0;row < dimension; row++)
            {
                for(int col = 0;col < dimension + 1; col++)
                {
                    Control a = panelMatriz.Controls.Find($"{row},{col}",true).First();

                    if (!double.TryParse((a as TextBox).Text, out double numero)) // Valida si el valor del textbox es un double
                    {
                        return null;
                    }
                    matriz[row, col] = numero;

                }
            }
            return matriz;
        }

        private void buttonVolverClick(object sender, EventArgs e)
        {
            Inicio irInicio = new Inicio();
            irInicio.Show();
            this.Hide();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int dimension = Convert.ToInt32(textDimension.Text);
            double[,] matriz = GuardarMatriz(dimension);
            MessageBox.Show("Matriz guardada con éxito");
            double[] vectorResultado = new double[dimension];
            switch(cbMetodo.SelectedIndex) 
            {
                case 0:
                    vectorResultado = logica.GaussJordan(dimension, matriz);
                    break;
                case 1:
                    vectorResultado = logica.GaussSeidel(dimension, matriz);
                    break;
            }
            string Resultados = "";
            if (vectorResultado != null)
            {
                for(int i = 0; i < vectorResultado.Length; i++)
                {
                    Resultados += $"X{i + 1} = {vectorResultado[i]}\n";
                }
            }
            else
            {
                Resultados = "Se superó el número máximo de iteraciones";
            }

            if (vectorResultado != null)
            {
                MessageBox.Show(Resultados,"Ejecución Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);    
            }
            else
            {
                MessageBox.Show(Resultados, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


// Limpiar cuando obtiene solución
// Acomodar el mensaje de salida