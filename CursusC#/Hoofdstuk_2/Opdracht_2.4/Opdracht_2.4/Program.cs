using System;

namespace Opdracht_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie van de variabelen
            double prijsInclBtw, prijsExclBtw;

            //Het getal opvragen
            Console.Write("Wat is de prijs van de auto exclusief BTW? ");
            prijsExclBtw = Convert.ToDouble(Console.ReadLine());

            //De som berekenen
            prijsInclBtw = prijsExclBtw * Convert.ToDouble(1.21);

            //Het resultaat weergeven in de console
            Console.WriteLine("De prijs inclusief BTW bedraagt: " + Math.Round(prijsInclBtw, 2).ToString());
            Console.ReadLine();
        }
    }
}
