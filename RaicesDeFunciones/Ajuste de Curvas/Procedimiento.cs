using RaicesDeFunciones.Sistemas_de_Ecuaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaicesDeFunciones.Ajuste_de_Curvas
{
    public static class Procedimiento
    {
        public class Entrada
        {
            public List<double[]> PuntosCargados { get; set; }
            public double Tolerancia { get; set; }
            public int Grado { get; set; }
        }

        public class Datos
        {
            public int CantPuntos { get; set; }
            public double SumX { get; set; }
            public double SumY { get; set; }
            public double SumXY { get; set; }
            public double SumX2 { get; set; }
        }

        public static Salida Resolucion(Entrada entrada, int metodo)
        {
            double sumX = 0;
            double sumY = 0;
            double sumXY = 0;
            double sumX2 = 0;

            foreach(double[] punto in entrada.PuntosCargados)
            {
                sumX += punto[0];
                sumY += punto[1];
                sumXY += punto[0] * punto[1];
                sumX2 += punto[0] * punto[0];
            }

            Datos datos = new Datos() 
            {
                CantPuntos = entrada.PuntosCargados.Count,
                SumX = sumX,
                SumY = sumY,
                SumXY = sumXY,
                SumX2 = sumX2
            };

            if (metodo == 0)
                 return RegresionLineal(datos, entrada);
            return RegresionPolinomial(datos, entrada);  
        }
    
        public static Salida RegresionLineal(Datos datos, Entrada entrada)
        {
            double a1 = (datos.CantPuntos * datos.SumXY - datos.SumX * datos.SumY) / (datos.CantPuntos * datos.SumX2 - Math.Pow(datos.SumX,2));
            double a0 = (datos.SumY / datos.CantPuntos) - a1 * (datos.SumX / datos.CantPuntos);

            // Calcular coeficiente de correlación (r)
            double st = 0;
            double sr = 0;

            foreach(double[] punto in entrada.PuntosCargados)
            {
                st += Math.Pow(datos.SumY / datos.CantPuntos - punto[1], 2);
                sr += Math.Pow(a1 * punto[0] + a0 - punto[1], 2);
            }

            double r = Math.Sqrt((st - sr) / st) * 100;

            return new Salida()
            {
                Funcion = $"y = {Math.Round(a1, 3)}.x {(a0 > 0 ? "+" : "")}{Math.Round(a0, 3)}",
                CoefCorrelacion = Math.Round(r,4),
                EfectividadAjuste = r >= entrada.Tolerancia,
                FuncionGraficador = $"{a1}*x{(a0 > 0 ? "+" : "")}{a0}"
            };
        }

        public static Salida RegresionPolinomial(Datos datos, Entrada entrada)
        {
            Logica logica = new Logica();
            double[,] matrizPolinomial = GenerarMatrizPolinomial(entrada.PuntosCargados, entrada.Grado);
            
            // Si devuelve null: mensaje error?
            double[] resultado = logica.GaussJordan(entrada.Grado + 1, matrizPolinomial);
            
            string funcion = ArmarFuncionPolinomial(resultado);

            // Calcular coeficiente de correlación (r)
            double st = 0;
            double sr = 0;
            double x = 0;
            double y = 0;
         
            foreach(double[] punto in entrada.PuntosCargados)
            {
                x = punto[0];
                y = punto[1];
                double suma = 0;
                for(int i = 0; i < resultado.Count(); i++)
                {
                    suma += resultado[i] * Math.Pow(x, i);
                }
                sr += Math.Pow(suma - y, 2);
                st += Math.Pow(datos.SumY/datos.CantPuntos - y, 2);
            }

            double r = Math.Sqrt((st - sr) / st) * 100;

            return new Salida()
            {
                Funcion = funcion,
                CoefCorrelacion = Math.Round(r, 4),
                EfectividadAjuste = r >= entrada.Tolerancia,
                FuncionGraficador = funcion
            };
        }
        public static double[,] GenerarMatrizPolinomial (List<double[]> puntosCargados, int grado)
        {
            int dimension = grado + 1;
            double[,] matriz = new double[dimension, dimension+1];
            double x = 0;
            double y = 0;

            foreach(double[] punto in puntosCargados)
            {
                x = punto[0];
                y = punto[1];
                
                for (int row = 0; row < dimension; row++)
                {
                    for (int col = 0; col < dimension; col++)
                    {
                        matriz[row, col] += Math.Pow(x, row + col);
                    }
                    matriz[row, dimension] += y * Math.Pow(x, row);
                }
            }
            return matriz;
        }

        public static string ArmarFuncionPolinomial(double[] vectorResultado)
        {
            string funcion = string.Empty;
            string signo = string.Empty;

            for(int i = 0; i < vectorResultado.Count(); i++)
            {
                double ai = Math.Round(vectorResultado[i],4);
                if (i == 0 && ai != 0)
                {
                    funcion = $"{ai}";
                }
                else if (i == 1 && ai != 0)
                {
                    funcion = $"{ai}x {signo}" + funcion;
                }
                else
                {
                    if(ai != 0)
                    {
                        funcion = $"{ai}x^{i} {signo}" + funcion;
                    }
                }
                signo = ai > 0 ? "+" : string.Empty;
            }
            return  funcion;
        }
    }
}

