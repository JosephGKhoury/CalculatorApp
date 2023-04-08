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

namespace P1CalculatorJoe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double memory = 0;
        string op = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if (OutputTextBox.Text == "0")
            {
                OutputTextBox.Text = "";
            }
            OutputTextBox.Text += b.Content.ToString();
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            op = b.Content.ToString();
            memory = double.Parse(OutputTextBox.Text);
            OutputTextBox.Text = "0";
            
        }

        private void Eq_Click(object sender, RoutedEventArgs e)
        {
            double value = double.Parse(OutputTextBox.Text);
            double resultat = 0;
         

            switch (op)
            {
                case "+":
                    resultat = memory + value;
                    break;
                    case "-": resultat = memory - value;    
                    break;
                    case "*": resultat = memory * value;
                    break;
                    case "/": resultat = memory / value;
                    break;
                    
                    
            }
            resultat = Math.Round(resultat, 2);
            OutputTextBox.Text = resultat.ToString();
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            memory = 0;
            OutputTextBox.Text = "0";
        }

        private void Root_Click(object sender, RoutedEventArgs e)
        {
            OutputTextBox.Text = Math.Sqrt(double.Parse(OutputTextBox.Text)).ToString();
        }

        private void e_Click(object sender, RoutedEventArgs e)
        {
            OutputTextBox.Text = Math.Round(Math.E,3).ToString();
        }
        private void pi_Click(object sender, RoutedEventArgs e)
        {
            OutputTextBox.Text = Math.Round(Math.PI, 2).ToString();
        }
    }
}