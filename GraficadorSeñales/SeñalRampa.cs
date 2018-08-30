using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadorSeñales
{
    class SeñalRampa
    {

        public List<Muestra> Muestras { get; set; }
        public double AmplitudMaxima { get; set; }

        public SeñalRampa()
        {
            Muestras = new List<Muestra>();
            AmplitudMaxima = 0.0;
        }
        public SeñalRampa(double amplitud, double fase, double frecuencia)
        {
            Muestras = new List<Muestra>();
            AmplitudMaxima = 0.0;
        }

        public double evaluar(double tiempo)
        {
            double resultado;
            resultado = tiempo ;

            return resultado;
        }
    }
}
