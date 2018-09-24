using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadorSeñales
{
    class SeñalExponencial : Señal
    {
        public double Alpha { get; set; }

        public SeñalExponencial()
        {
            Muestras = new List<Muestra>();
            AmplitudMaxima = 0.0;
            Alpha = 1;
        }

        public SeñalExponencial(double alpha) // Los constructores se llaman como la clase
        {                       // Éstas de arriba son variables internas
            
            Muestras = new List<Muestra>();
            Alpha = alpha;
            AmplitudMaxima = 0.0;

        }

        override public double evaluar(double tiempo)
        {
            double resultado;

            resultado = Math.Exp(Alpha*tiempo);

            return resultado;
        }
    }
}
