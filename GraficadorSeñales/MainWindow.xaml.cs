using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GraficadorSeñales
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
            /*
            plnGrafica.Points.Add(new Point(0, 10));
            plnGrafica.Points.Add(new Point(50, 20));
            plnGrafica.Points.Add(new Point(150, 10));
            plnGrafica.Points.Add(new Point(250, 50));
            plnGrafica.Points.Add(new Point(350, 0));
            plnGrafica.Points.Add(new Point(450, 100));
            plnGrafica.Points.Add(new Point(550, 30));
            plnGrafica.Points.Add(new Point(650, 30));
            plnGrafica.Points.Add(new Point(750, 30));
            */
        }

        private void btn_Graficar_Click(object sender, RoutedEventArgs e)
        {
            double amplitud = double.Parse(txt_amplitud.Text);
            double fase = double.Parse(txt_fase.Text);
            double frecuencia = double.Parse(txt_frecuencia.Text);
            double tiempoInicial = double.Parse(txt_tiempoinicial.Text);
            double tiempoFinal = double.Parse(txt_tiempofinal.Text);
            double frecuenciaMuestreo = double.Parse(txt_frecuenciamuestreo.Text);

            SeñalSenoidal señal = new SeñalSenoidal(amplitud, fase, frecuencia);

            plnGrafica.Points.Clear();

            double periodoMuestreo = 1 / frecuenciaMuestreo;
            for(double i = tiempoInicial; i <= tiempoFinal; i += periodoMuestreo)
            {
                plnGrafica.Points.Add(new Point(i * scr_Contenedor.Width, señal.evaluar(i)*((scr_Contenedor.Height/2)-30) - 1 + (scr_Contenedor.Height / 2)));
            }

        }
    }
}
