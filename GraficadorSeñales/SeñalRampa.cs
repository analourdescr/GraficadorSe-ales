using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadorSeñales
{
    class SeñalRampa
    {
        public double Amplitud { get; set; }
        public double Fase { get; set; }
        public double Frecuencia { get; set; }

        public List<Muestra> Muestras { get; set; }
        public double AmplitudMaxima { get; set; }

        public SeñalRampa()
        {
            Amplitud = 1.0;
            Fase = 0.0;
            Frecuencia = 1.0;
            Muestras = new List<Muestra>();
            AmplitudMaxima = 0.0;
        }
        public SeñalRampa(double amplitud, double fase, double frecuencia)
        {
            Amplitud = amplitud;
            Fase = fase;
            Frecuencia = frecuencia;
            Muestras = new List<Muestra>();
            AmplitudMaxima = 0.0;
        }

        public double evaluar(double tiempo)
        {
            double resultado;
            resultado = Amplitud *(( (Frecuencia * tiempo)) + Fase);

            return resultado;
        }
    }
}
