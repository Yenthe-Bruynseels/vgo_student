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

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertFahrenheit(object sender, RoutedEventArgs e)
        {
            // fetch input textBox
            var input = textBoxFahrenheit.Text;
            // parse fetched string to double
            var val = double.Parse(input);
            // formula for °F to °C
            var valC = (val - 32) * 0.5556;
            //formula for °F to °K
            var valK = valC + 273.15;
            // parse double to string
            var outputC = valC.ToString();
            var outputK = valK.ToString(); 
            // show value in textBox
            textBoxCelsius.Text = outputC;
            textBoxKelvin.Text = outputK;
        }

        private void ConvertCelsius(object sender, RoutedEventArgs e)
        {
            var input = textBoxCelsius.Text;
            var val = double.Parse(input);
            var valF = val * 1.8 + 32;
            var valK = val + 273.15;
            textBoxFahrenheit.Text = valF.ToString();
            textBoxKelvin.Text = valK.ToString();
        }

        private void ConvertKelvin(object sender, RoutedEventArgs e)
        {
            var input = textBoxKelvin.Text;
            var val = double.Parse(input);
            var valC = val - 273.15;
            var valF = valC * 1.8 + 32;
            textBoxFahrenheit.Text = valF.ToString();
            textBoxCelsius.Text = valC.ToString();
        }
    }
}
