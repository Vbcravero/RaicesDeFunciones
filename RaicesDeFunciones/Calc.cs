using Calculus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaicesDeFunciones
{
    public class Calc : Calculo
    {
        
        public double CalcularError (double xr, double xrAnt)
        {
            double error;
            error = Math.Abs((xr-xrAnt)/xr);
            return error;
        }

        public double CalcularXr(string metodo, string fn, double xi, double xd) 
        {
            double xr;
            if (metodo == "Bisección")
            {
                xr = (xi + xd)/2;
            }
            else if (metodo == "Regla falsa"  || metodo == "Secante")
            {
                xr = (EvaluaFx(xd) * xi - EvaluaFx(xi) * xd) / (EvaluaFx(xd) - EvaluaFx(xi));
            }
            else  //metodo == "Tangente"
            {
                var derivada = Math.Abs(Dx(xi));
                if (derivada < 0.0001 || double.IsNaN(derivada)) 
                {
                    //MessageBox.Show("El método diverge. No encuentra raíz");
                    xr = double.NaN; 
                }
                else
                {
                    xr = xi - (EvaluaFx(xi) / derivada);
                }
                
            }

            return xr;
        }
    }
}
