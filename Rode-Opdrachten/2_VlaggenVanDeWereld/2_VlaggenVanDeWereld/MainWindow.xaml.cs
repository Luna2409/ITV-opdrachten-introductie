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

namespace _2_VlaggenVanDeWereld
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

        private void Click(object sender, MouseButtonEventArgs e)
        {
            switch (((CountryFlag.CountryFlag)sender).Name)
            {
                #region Row 1

                case "United_Arab_Emirates":
                    naamFlag.Text = "United Arab Emirates";
                    break;
                case "Antigua_and_Barbuda":
                    naamFlag.Text = "Antigua and Barbuda";
                    break;

                #endregion

                #region Row 2

                case "American_Samoa":
                    naamFlag.Text = "American Samoa";
                    break;
                case "Åland_Islands":
                    naamFlag.Text = "Åland Islands";
                    break;
                case "Bosnia_and_Herzegovina":
                    naamFlag.Text = "Bosnia and Herzegovina";
                    break;

                #endregion

                #region Row 3

                case "Burkina_Faso":
                    naamFlag.Text = "Burkina Faso";
                    break;

                #endregion

                #region Row 4

                case "St_Barths":
                    naamFlag.Text = "St Barths";
                    break;
                case "Caribbean_Netherlands":
                    naamFlag.Text = "Caribbean Netherlands";
                    break;

                #endregion

                #region Row 5

                case "Bouvet_Island":
                    naamFlag.Text = "Bouvet Island";
                    break;
                case "Cocos_Keeling_Islands":
                    naamFlag.Text = "Cocos (Keeling) Islands";
                    break;
                case "DR_Congo":
                    naamFlag.Text = "Democratic Republic of the Congo";
                    break;
                case "Central_African_Republic":
                    naamFlag.Text = "Central African Republic";
                    break;

                #endregion

                #region Row 6

                case "Ivory_Coast":
                    naamFlag.Text = "Ivory Coast";
                    break;
                case "Cook_Islands":
                    naamFlag.Text = "Cook Islands";
                    break;

                #endregion

                #region Row 7

                case "Costa_Rica":
                    naamFlag.Text = "Costa Rica";
                    break;
                case "Cape_Verde":
                    naamFlag.Text = "Cape Verde";
                    break;
                case "Christmas_Island":
                    naamFlag.Text = "Christmas Island";
                    break;
                case "Czech_Republic":
                    naamFlag.Text = "Czech Republic";
                    break;

                #endregion

                #region Row 8
                   
                case "Dominican_Republic":
                    naamFlag.Text = "Dominican Republic";
                    break;

                #endregion

                #region Row 9

                case "Western_Sahara":
                    naamFlag.Text = "Western Sahara";
                    break;
                case "Falkland_Islands":
                    naamFlag.Text = "Falkland Islands";
                    break;
                case "FD_Micronesia":
                    naamFlag.Text = "Federated States of Micronesia";
                    break;

                #endregion

                #region Row 10

                case "Faroe_Islands":
                    naamFlag.Text = "Faroe Islands";
                    break;
                case "United_Kingdom":
                    naamFlag.Text = "United Kingdom";
                    break;
                case "French_Guiana":
                    naamFlag.Text = "French Guiana";
                    break;

                #endregion

                #region Row 11

                case "Equatorial_Guinea":
                    naamFlag.Text = "Equatorial Guinea";
                    break;

                #endregion

                #region Row 12

                case "SGSSI":
                    naamFlag.Text = "South Georgia and the South Sandwich Islands";
                    break;
                case "Guinea_Bissau":
                    naamFlag.Text = "Guinea-Bissau";
                    break;
                case "Hong_Kong":
                    naamFlag.Text = "Hong Kong";
                    break;
                case "HIMI":
                    naamFlag.Text = "Heard Island and McDonald Islands";
                    break;

                #endregion

                #region Row 13

                case "Isle_of_Man":
                    naamFlag.Text = "Isle of Man";
                    break;

                #endregion

                #region Row 14

                case "BIOT":
                    naamFlag.Text = "British Indian Ocean Territory";
                    break;
                case "Bailiwick_of_Jersey":
                    naamFlag.Text = "Bailiwick of Jersey";
                    break;

                #endregion

                #region Row 15

                case "Saint_Kitts_and_Nevis":
                    naamFlag.Text = "Saint Kitts and Nevis";
                    break;
                case "North_Korea":
                    naamFlag.Text = "North Korea";
                    break;

                #endregion

                #region Row 16

                case "South_Korea":
                    naamFlag.Text = "South Korea";
                    break;
                case "Cayman_Islands":
                    naamFlag.Text = "Cayman Islands";
                    break;
                case "Saint_Lucia":
                    naamFlag.Text = "Saint Lucia";
                    break;

                #endregion

                #region Row 17

                case "Sri_Lanka":
                    naamFlag.Text = "Sri Lanka";
                    break;

                #endregion

                #region Row 18

                case "Saint_Martin":
                    naamFlag.Text = "Saint Martin";
                    break;
                case "Marshall_Islands":
                    naamFlag.Text = "Marshall Islands";
                    break;
                case "North_Macedonia":
                    naamFlag.Text = "North Macedonia";
                    break;

                #endregion

                #region Row 19

                case "Northern_Mariana_Islands":
                    naamFlag.Text = "Northern Mariana Islands";
                    break;

                #endregion

                #region Row 20

                case "New_Caledonia":
                    naamFlag.Text = "New Caledonia";
                    break;

                #endregion

                #region Row 21

                case "Norfolk_Island":
                    naamFlag.Text = "Norfolk Island";
                    break;

                #endregion

                #region Row 22

                case "New_Zealand":
                    naamFlag.Text = "New Zealand";
                    break;
                case "French_Polynesia":
                    naamFlag.Text = "French Polynesia";
                    break;
                case "Papua_New_Guinea":
                    naamFlag.Text = "Papua New Guinea";
                    break;

                #endregion

                #region Row 23

                case "Saint_Pierre_and_Miquelon":
                    naamFlag.Text = "Saint Pierre and Miquelon";
                    break;
                case "Pitcairn_Islands":
                    naamFlag.Text = "Pitcairn Islands";
                    break;
                case "Puerto_Rico":
                    naamFlag.Text = "Puerto Rico";
                    break;

                #endregion

                #region Row 24

                case "Saudi_Arabia":
                    naamFlag.Text = "Saudi Arabia";
                    break;

                #endregion

                #region Row 25

                case "Solomon_Islands":
                    naamFlag.Text = "Solomon Islands";
                    break;
                case "AHATC":
                    naamFlag.Text = "Saint Helena, Ascension and Tristan da Cunha";
                    break;
                case "SJM":
                    naamFlag.Text = "Svalbard and Jan Mayen";
                    break;

                #endregion

                #region Row 26

                case "Sierra_Leone":
                    naamFlag.Text = "Sierra Leone";
                    break;
                case "San_Marino":
                    naamFlag.Text = "San Marino";
                    break;
                case "South_Sudan":
                    naamFlag.Text = "South Sudan";
                    break;
                case "Saint_Thomas_and_Prince":
                    naamFlag.Text = "Saint Thomas and Prince";
                    break;

                #endregion

                #region Row 27

                case "El_Salvador":
                    naamFlag.Text = "El Salvador";
                    break;
                case "Sint_Maarten":
                    naamFlag.Text = "Sint Maarten";
                    break;
                case "Turks_and_Caicos_Islands":
                    naamFlag.Text = "Turks and Caicos Islands";
                    break;
                case "TAAF":
                    naamFlag.Text = "French Southern and Antarctic Lands";
                    break;

                #endregion

                #region Row 28

                case "East_Timor":
                    naamFlag.Text = "East Timor";
                    break;

                #endregion

                #region Row 29

                case "Trinidad_and_Tobago":
                    naamFlag.Text = "Trinidad and Tobago";
                    break;
                case "UM":
                    naamFlag.Text = "United States Minor Outlying Islands";
                    break;
                case "USA":
                    naamFlag.Text = "United States of America";
                    break;

                #endregion

                #region Row 30

                case "Vatican_City":
                    naamFlag.Text = "Vatican City";
                    break;
                case "VC":
                    naamFlag.Text = "Saint Vincent and the Grenadines";
                    break;
                case "British_Virgin_Islands":
                    naamFlag.Text = "British Virgin Islands";
                    break;
                case "United_States_Virgin_Islands":
                    naamFlag.Text = "United States Virgin Islands";
                    break;

                #endregion

                #region Row 31

                case "WF":
                    naamFlag.Text = "Wallis and Futuna Islands";
                    break;
                case "South_Africa":
                    naamFlag.Text = "South Africa";
                    break;

                #endregion

                default:
                    naamFlag.Text = ((CountryFlag.CountryFlag)sender).Name.ToString();
                    break;

            }
        }
    }
}
