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

        private void ConvertToCelsius(object sender, RoutedEventArgs e)
        {
            // fetch input textBox
            string input = textBox.Text;
            // parse fetched string to double
            double val = double.Parse(input);
            // formula for °F to °C
            double valC = (val - 32) * 0.5556;
            // parse double to string
            string output = valC.ToString();
            // show value in textBox
            textBox.Text = output;
        }

        private void ConvertToFahrenheit(object sender, RoutedEventArgs e)
        {
            var input = textBox.Text;
            var val = double.Parse(input);
            var valF = val * 1.8 + 32;
            textBox.Text = valF.ToString();
        }
    }
}
