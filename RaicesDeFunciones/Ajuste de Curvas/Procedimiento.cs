using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            //if (metodo == 0)
            return RegresionLineal(datos, entrada);
            //Agregar otro método
             
        }
    
        public static Salida RegresionLineal(Datos datos, Entrada entrada)
        {
            double a1 = (datos.CantPuntos * datos.SumXY - datos.SumX * datos.SumY) / (datos.CantPuntos * datos.SumX2 - Math.Pow(datos.SumX,2));
            double a0 = (datos.SumY / datos.CantPuntos) - a1 * (datos.SumX / datos.CantPuntos);

            // Agregar restante
            return new Salida()
            {
                Funcion = $"y = {Math.Round(a1, 3)}.x {(a0 > 0 ? "+" : "")}{Math.Round(a0, 3)}"
                // Agregar
            };
        }
    }
}

