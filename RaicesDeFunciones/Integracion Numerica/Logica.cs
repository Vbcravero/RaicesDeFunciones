using Calculus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaicesDeFunciones.Integracion_Numerica
{
    public class Logica : Calculo
    {
        public double TrapeciosSimple(Input input)
        {
            double resultado = ((EvaluaFx(input.a) + EvaluaFx(input.b)) * (input.b - input.a)) / 2;
            return resultado;
        }

        public double TrapeciosMultiples(Input input)
        {
            double h = (input.b - input.a) / input.cantSubintervalos;
            double sum = 0;
            
            for (int i = 1; i < input.cantSubintervalos; i++) 
            {
                sum += EvaluaFx(input.a + h*i);
            }
            double resultado = (h / 2) * (EvaluaFx(input.a) + 2 * sum + EvaluaFx(input.b));
            return resultado;
        }

        public double SimpsonSimple(Input input)
        {
            double h = (input.b - input.a) / 2;
            double resultado = (h / 3) * (EvaluaFx(input.a) + 4 * EvaluaFx(input.a + h) + EvaluaFx(input.b));
            return resultado;
        }

        public double SimpsonMultiple(Input input) 
        {
            double h = (input.b - input.a) / input.cantSubintervalos;
            double sumPar = 0; 
            double sumInpar = 0;
            double resultado = 0;
            bool simpson38Hecho = false;

            for (int i = 1; i < input.cantSubintervalos; i ++)
            {
                if(input.cantSubintervalos % 2 != 0 && !simpson38Hecho)
                {
                    input.nuevoA = input.a + h * (input.cantSubintervalos - 3); // b - 3 * h
                    resultado = Simpson38Simple(input);
                    input.cantSubintervalos = input.cantSubintervalos - 3;
                    simpson38Hecho = true;
                }
                if (i % 2 == 0)
                {
                    sumPar += EvaluaFx(input.a + h * i);
                }
                else
                {
                    sumInpar += EvaluaFx(input.a + h * i);
                }
            }
            resultado += (h / 3) * (EvaluaFx(input.a) + 4 * sumInpar + 2 * sumPar + EvaluaFx(input.b));
            return resultado;
        }

        public double Simpson38Simple(Input input)
        {
            if(input.nuevoA != double.NaN)
            {
                input.a = input.nuevoA;
            }
            double h = (input.b - input.a) / 3;
            double resultado = (3*h/8) * (EvaluaFx(input.a) + 3 * EvaluaFx(input.a + h) + 3 * EvaluaFx(input.a + 2*h) + EvaluaFx(input.b));
            return resultado;
        }
    }
}
