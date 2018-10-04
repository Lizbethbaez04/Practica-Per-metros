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

namespace PracticaPerminetros
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbTipoFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            controlPerimetroCirculo.Visibility = Visibility.Collapsed;
            controlPerimetroCuadrado.Visibility = Visibility.Collapsed;
            switch(cbTipoFigura.SelectedIndex)
            {
                case 0://Circulo
                    controlPerimetroCirculo.Visibility = Visibility.Visible;
                    break;
                case 1://Cuadrado
                    controlPerimetroCuadrado.Visibility = Visibility.Visible;
                    break;
                case 2://Trapecio
                    controlPerimetroTrapecio.Visibility = Visibility.Visible;
                    break;
                case 3://Rectangulo
                    controlPerimetroRectangulo.Visibility = Visibility.Visible;
                    break;
                default:
                    break;
            }
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            float perimetro = 0.0f;
            switch(cbTipoFigura.SelectedIndex)
            {
                case 0://Circulo
                    //float.Parse() sirve para convertir texto a numeral
                    float radio = float.Parse(controlPerimetroCirculo.txtRadio.Text);
                    perimetro = 2 * radio * 3.14159f;
                    break;
                case 1://Cuadrado
                    float lado = float.Parse(controlPerimetroCuadrado.txtLado.Text);
                    perimetro = lado * 4;
                    break;
                case 2://Trapecio
                    float lado1 = float.Parse(controlPerimetroTrapecio.txtLado4.Text);
                    float lado2 = float.Parse(controlPerimetroTrapecio.txtLado5.Text);
                    float lado3 = float.Parse(controlPerimetroTrapecio.txtLado6.Text);
                    float lado4 = float.Parse(controlPerimetroTrapecio.txtLado7.Text);
                    perimetro = lado1 + lado2 + lado3 + lado4;
                    break;
                case 3://Rectangulo
                    float lado5 = float.Parse(controlPerimetroRectangulo.txtLado2.Text);
                    float lado6 = float.Parse(controlPerimetroRectangulo.txtLado3.Text);
                    perimetro = 2 * (lado5 + lado6);
                    break;
                default:
                    break;
            }
            //Tostring sirve para convertir
            lblResultado.Text = perimetro.ToString();
        }
    }
}
