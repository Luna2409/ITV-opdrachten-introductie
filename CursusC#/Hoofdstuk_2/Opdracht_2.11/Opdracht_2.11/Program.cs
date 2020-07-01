using System;

namespace Opdracht_2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie van de variabelen
            double totaalMaandloon, omzetcijfer;
            const double vastMaandloon = 958.36;
            const double variabelMaandloon = 8.25;

            //Het getal opvragen
            Console.Write("Wat is het omzetcijfer van de verkoper? ");
            omzetcijfer = Convert.ToDouble(Console.ReadLine());

            //De som berekenen
            totaalMaandloon = vastMaandloon  +  omzetcijfer * (variabelMaandloon / 100);

            //Het resultaat weergeven in de console
            Console.WriteLine();
            Console.WriteLine("Het totale maandloon van de verkoper = " + Math.Round(totaalMaandloon, 2));
            Console.ReadLine();
        }
    }
}
