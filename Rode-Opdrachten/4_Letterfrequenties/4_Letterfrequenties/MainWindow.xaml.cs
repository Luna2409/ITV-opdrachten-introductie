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
using System.IO;
using Microsoft.Win32;

namespace _4_Letterfrequenties
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

        string text = "";
        char[] charArray;
        char letter;
        char hoofdletter;

        private void ButtonOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Text files (*.txt)|*.txt";

            //|Word File (*.doc;*.docx)|*.doc;*.docx|All files (*.*)|*.*

            if (openFile.ShowDialog() == true)
            {
                fileName.Text = Path.GetFileName(openFile.FileName);
                text = File.ReadAllText(openFile.FileName);


                Box.Text = File.ReadAllText(openFile.FileName);
            }
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            letter = char.Parse(letterBox.Text.ToLower());
            hoofdletter = char.Parse(letterBox.Text.ToUpper());
            charArray = text.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == letter || charArray[i] == hoofdletter)
                {
                    count++;
                }
            }
            Result.Text = "In this text the letter " + letter.ToString() + " appears " + count.ToString() + " times";

            //In this text the letter ... appears ... times

            /*
            count = text.Count(letter => text.Contains(letter));
            */
        }
    }
}
