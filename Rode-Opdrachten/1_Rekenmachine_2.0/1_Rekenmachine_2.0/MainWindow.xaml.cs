using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace _1_Rekenmachine_2._0
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

        Double value = 0;
        string operation = "";
        bool operationPressed = false;
        bool EqualButtonPressed = false;

        #region Clear and AllClear Button
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "0";
        }

        private void AllClearButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "0";
            value = 0;
            operationPressed = false;
        }

        #endregion

        #region Button_Click event
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((Display.Text == "0") || (operationPressed) || (EqualButtonPressed))
            {
                Display.Clear();
                operationPressed = false;
                EqualButtonPressed = false;
            }

            Button b = (Button)sender;

            if (b.Name == "CommaButton")
            {
                //If it does not contain a decimal point it will be added > !: negative/false/opposite
                if (!Display.Text.Contains(","))
                {
                    Display.Text += b.Content;
                }
            }
            else
            {
                Display.Text += b.Content;
            }
        }
        #endregion

        #region Operator_Click event
        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;

            if (value != 0)
            {
                EqualButton_Click(this, null);
                value = Double.Parse(Display.Text);
                operationPressed = true;
                operation = b.Content.ToString();
            }
            else
            {
                value = Double.Parse(Display.Text);
                operationPressed = true;
                operation = b.Content.ToString();
            }
        }
        #endregion

        #region Equal Button
        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    Display.Text = (value + Double.Parse(Display.Text)).ToString();
                    break;
                case "-":
                    Display.Text = (value - Double.Parse(Display.Text)).ToString();
                    break;
                case "X":
                    Display.Text = (value * Double.Parse(Display.Text)).ToString();
                    break;
                case "/":
                    Display.Text = (value / Double.Parse(Display.Text)).ToString();
                    break;
                default:
                    break;
            }

            EqualButtonPressed = true;
        }
        #endregion

        #region Euro_Click
        private void Euro_Click(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("nl-NL", false);
            Display.Text = Double.Parse(Display.Text).ToString("C");
        }
        #endregion

        #region Percentage_Click
        private void Percentage_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = (Double.Parse(Display.Text) * 0.01).ToString();
        }
        #endregion

        #region KeyDown
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            //Times button on keyboard
            if ((e.Key == Key.D8 && Keyboard.IsKeyDown(Key.RightShift)) || (e.Key == Key.X))
            {
                Operator_Click(TimesButton, null);
            }
            //8 button on keyboard
            else if (e.Key == Key.D8)
            {
                Button_Click(EightButton, null);
            }

            

            //link keyboard key's
            switch (e.Key)
            {
                case Key.D0:
                    Button_Click(ZeroButton, null);
                    break;
                case Key.D1:
                    Button_Click(OneButton, null);
                    break;
                case Key.D2:
                    Button_Click(TwoButton, null);
                    break;
                case Key.D3:
                    Button_Click(ThreeButton, null);
                    break;
                case Key.D4:
                    Button_Click(FourButton, null);
                    break;
                case Key.D5:
                    Button_Click(FiveButton, null);
                    break;
                case Key.D6:
                    Button_Click(SixButton, null);
                    break;
                case Key.D7:
                    Button_Click(SevenButton, null);
                    break;
                case Key.D9:
                    Button_Click(NineButton, null);
                    break;
                case Key.OemComma:
                    Button_Click(CommaButton, null);
                    break;
                case Key.Enter:
                    EqualButton_Click(EqualButton, null);
                    break;

                // The Oem buttons are not working correctly on my computer (MAC)
                // They are working right how I put them now but may not work on a windows computer

                case Key.Oem2:
                    Operator_Click(PlusButton, null);
                    break;
                case Key.Oem4:
                    Operator_Click(MinusButton, null);
                    break;
                case Key.OemMinus:
                    Operator_Click(DivideButton, null);
                    break;
                
                default:
                    break;
            }
        }

        #endregion

    }
}
