using Calculus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaicesDeFunciones
{
    internal class MetodoRaiz : Calculo
    {
        //Calculo calculo = new Calculo();
        public double CalcularError (double xr, double xrAnt)
        {
            double error;
            error = Math.Abs((xr-xrAnt)/xr);
            return error;
        }

        public double CalcularXr(string metodo, string fn, double xi, double xd) // Agregar double tolerancia
        {
            double xr;
            if (metodo == "Bisección")
            {
                xr = (xi + xd)/2;
            }
            else if (metodo == "Regla falsa"  || metodo == "Secante")
            {
                //xr = (calculo.EvaluaFx(xd)* xi - calculo.EvaluaFx(xi) * xd) / (calculo.EvaluaFx(xd) - calculo.EvaluaFx(xi));
                xr = (EvaluaFx(xd) * xi - EvaluaFx(xi) * xd) / (EvaluaFx(xd) - EvaluaFx(xi));
            }
            else  //metodo == "Tangente"
            {
                double derivada = 0;
                derivada = Dx(xi);
                if (derivada < 0.0001 || double.IsNaN(derivada)) // pasar tolerancia como parámetro
                {
                    //MessageBox.Show("El método diverge. No encuentra raíz");
                    xr = double.NaN; 
                }
                else
                {
                    xr = (xi - EvaluaFx(xi)) / derivada;
                }
                
            }

            return xr;
        }
    }
}
