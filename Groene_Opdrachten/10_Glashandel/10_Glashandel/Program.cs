using System;

namespace _10_Glashandel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            string soortGlas, restantGlas;
            double hoeveelheidGlas, totaalBedrag = 0;

            //Opvragen variabelen
            Console.Write("Is er gewoon glas of speciaal glas besteld?(gewoon/speciaal): ");
            soortGlas = Console.ReadLine();
            Console.Write("Hoeveelheid glas besteld in m2: ");
            hoeveelheidGlas = double.Parse(Console.ReadLine());
            Console.Write("kan er glas uit restant glas gehaald worden?(ja/nee): ");
            restantGlas = Console.ReadLine();

            //Restant glas ja/nee?
            switch (restantGlas)
            {
                case "ja":
                    break;
                case "nee":
                    Console.Write("Rond de hoeveelheid glas naar boven af: ");
                    hoeveelheidGlas = double.Parse(Console.ReadLine());
                    break;
            }

            //Totaal bedrag berekenen
            switch (soortGlas)
            {
                case "gewoon":
                    totaalBedrag = 30 * hoeveelheidGlas;
                    break;
                case "speciaal":
                    totaalBedrag = 55 * hoeveelheidGlas;
                    break;
            }
            //Bedrag hoger dan 145/250?
            if (totaalBedrag >= 145 && totaalBedrag <= 250)
            {
                //Geen snijkosten
            }
            else if (totaalBedrag > 250)
            {
                totaalBedrag *= 0.95;
            }
            else
            {
                switch (soortGlas)
                {
                    case "gewoon":
                        totaalBedrag += 10;
                        break;
                    case "speciaal":
                        totaalBedrag += 25;
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Het totaal bedrag is €" + Math.Round(totaalBedrag, 2).ToString());

            Console.ReadLine();
        }
    }
}
