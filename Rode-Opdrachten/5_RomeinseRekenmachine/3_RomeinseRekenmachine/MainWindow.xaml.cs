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
using RomanNumerals.Numerals;

namespace _3_RomeinseRekenmachine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region MainWindow
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion

        string romanNumeral1 = "";
        string romanNumeral2 = "";
        string operation = "";
        uint number1 = 0;
        uint number2 = 0;
        uint answer = 0;
        bool operatorPressed = false;
        bool equalButtonPressed = false;

        #region Button_Click
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;

            if ((Display.Text != "" && operatorPressed) || equalButtonPressed)
            {
                Display.Clear();

                operatorPressed = false;
                equalButtonPressed = false;
            }

            Display.Text += b.Content; 

        }
        #endregion

        #region Operator_Click
        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Content.ToString();

            operatorPressed = true;
            romanNumeral1 = Display.Text;
            NumeralParser.TryParse(romanNumeral1, out number1);
        }
        #endregion

        #region All Clear and Clear Button
        private void AllClearButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Clear();
            romanNumeral1 = "";
            number1 = 0;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Clear();
        }
        #endregion

        #region Equal button
        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            equalButtonPressed = true;

            romanNumeral2 = Display.Text;
            NumeralParser.TryParse(romanNumeral2, out number2);

            switch (operation)
            {
                case "+":
                    answer = number1 + number2;
                    break;
                case "-":
                    answer = number1 - number2;
                    break;
                case "x":
                    answer = number1 * number2;
                    break;
                case "/":
                    answer = number1 / number2;
                    break;
                default:
                    break;
            }

            Display.Text = NumeralBuilder.Build(answer);

            number1 = 0;
            number2 = 0;
            romanNumeral1 = "";
            romanNumeral2 = "";
        }
        #endregion
    }
}
