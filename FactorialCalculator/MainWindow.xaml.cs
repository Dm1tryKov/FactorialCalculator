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

namespace FactorialCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateFactorial(object sender, RoutedEventArgs e)
        {
            // Преобразование введенного значения в целое число
            int n = int.Parse(inputTextBox.Text);

            int factorial = 1;
            string expression = "1";

            // Вычисление факториала
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
                expression += $" * {i}";
            }

            outputTextBlock.Text = $"fact={expression}={factorial}";
        }
    }
}
