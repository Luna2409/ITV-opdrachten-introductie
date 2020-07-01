using System;

namespace Opdracht_2._12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kleuren instellen
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            //Declaratie van de variabelen
            string naam;
            decimal aantalStrips, subtotaalExBtw, btwBedrag, totaalInBtw;
            const decimal prijsStripExBtw = 5;
            const decimal btwTarief = 6;
            
            //De variabele opvragen
            Console.Write("Wat is je naam?: ");
            naam = Console.ReadLine();

            Console.Write("Voer het aantal strips in: ");
            aantalStrips = Convert.ToDecimal(Console.ReadLine());

            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Sommen berekenen
            subtotaalExBtw = prijsStripExBtw * aantalStrips;
            btwBedrag = subtotaalExBtw * (btwTarief / 100);
            totaalInBtw = btwBedrag + subtotaalExBtw;

            //Eerste deel weergeven in console
            Console.WriteLine("#####################################");

            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine();
            Console.WriteLine("U wordt geholpen door " + naam);
            Console.WriteLine();
            Console.WriteLine("Eenheidsprijs exclusief BTW = " + Convert.ToString(prijsStripExBtw) + " EUR");
            Console.WriteLine("Aantal = " + Convert.ToString(aantalStrips));
            Console.WriteLine();
            Console.WriteLine("Subtotaal exclusief BTW = " + Convert.ToString(subtotaalExBtw) + " EUR");
            Console.WriteLine();
            Console.WriteLine("BTW-tarief = " + Convert.ToString(btwTarief) + " %");
            Console.WriteLine("BTW bedrag = " + Math.Round(btwBedrag, 2) + " EUR");
            Console.WriteLine();

            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Totaal inclusief BTW = " + Convert.ToString(totaalInBtw) + " EUR");
        }
    }
}
