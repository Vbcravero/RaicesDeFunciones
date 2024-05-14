using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaicesDeFunciones.Sistemas_de_Ecuaciones
{
    public class Logica
    {
        
        public double[] GaussSeidel(int dimension, double[,] matriz)
        {
            int contador,contadorMismoResult;
            contador = 0; contadorMismoResult = 0;
            bool esSolucion = false;
            double[] vectorResultado = new double[dimension];
            vectorResultado.Initialize();
            double[] vectorAnterior = new double[dimension];
            double resultado, coeficienteIncognita, errorRelativo;
            errorRelativo = 0;
            int iteraciones = 100;


            while (contador <= iteraciones && !esSolucion)
            {
                contador++;
                if(contador > 1) 
                {
                    vectorResultado.CopyTo(vectorAnterior, 0);
                }
                for(int row = 0; row < dimension; row++)
                {
                    resultado = matriz[row,dimension];
                    coeficienteIncognita = matriz[row,row];
                    for(int col = 0; col < dimension; col++)
                    {
                        if(row != col)
                        {
                            resultado = resultado - (matriz[row, col] * vectorResultado[col]);
                        }
                    }
                    coeficienteIncognita = resultado / coeficienteIncognita;
                    vectorResultado[row] = Math.Round(coeficienteIncognita,4); 
                }
                contadorMismoResult = 0;
                for (int i = 0; i < dimension; i++)
                {
                    errorRelativo = Math.Abs(((vectorResultado[i] - vectorAnterior[i]) / vectorResultado[i]));
                    if (errorRelativo < 0.0001)
                    {
                        contadorMismoResult++;
                    }
                }
                esSolucion = contadorMismoResult == dimension;
            }
            if (contador <= iteraciones)
            {
                return vectorResultado;
            }
            else
            {
                //throw new ArgumentException("No tiene solución");
                return null;
            }
            //return vectorResultado;
        }

        public double[] GaussJordan(int dimension, double[,] matriz)
        {
            double coeficienteIncognita, coeficienteCero;
            double[] vectorResultado = new double[dimension];
            //bool esSolucion = true;

            for (int row = 0; row < dimension; row++)
            {
                coeficienteIncognita = matriz[row, row];

                for(int col = 0; col < dimension + 1; col++) 
                {
                   matriz[row,col] = matriz[row, col] / coeficienteIncognita;
                }

                for (int otherRow = 0; otherRow < dimension; otherRow++)
                {
                    if(otherRow != row)
                    {
                        coeficienteCero = matriz[otherRow, row];
                        for(int col = row; col < dimension + 1; col++)
                        {
                            matriz[otherRow, col] = matriz[otherRow, col] - (coeficienteCero * matriz[row, col]);
                        }
                    }
                }
            }

            //for (int row = 0; row < dimension; row++)
            //{
            //    if(matriz[row, row] == 0 && matriz[row, dimension] != 0)
            //    {
            //        esSolucion = false;
            //    }
            //}

            for (int row = 0;row < dimension; row++)
            {
                vectorResultado[row] = Math.Round(matriz[row, dimension],4);
            }
            //if (esSolucion)
            //{
            //    return (vectorResultado, esSolucion);
            //}
            //else
            //{
            //    return (null, esSolucion);
            //}

            return vectorResultado;
        }
    }
}
