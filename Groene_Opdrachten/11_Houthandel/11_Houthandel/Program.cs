using System;

namespace _11_Houthandel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            DateTime nu = DateTime.Now;
            DateTime leverdatum;
            int klasse, aantalDagen;
            double hoeveelheidHout, hoeveelheidSchaven, houtkosten = 0, totaalBedrag = 0;

            //Opvragen variabelen
            Console.Write("Wat is de leverdatum?: ");
            leverdatum = DateTime.Parse(Console.ReadLine());
            Console.Write("Voor welke klasse hout is er gekozen?(1/2/3): ");
            klasse = int.Parse(Console.ReadLine());
            Console.Write("Hoeveel m3 hout is er besteld?: ");
            hoeveelheidHout = double.Parse(Console.ReadLine());
            Console.Write("Hoeveel m2 moet er geschaaft worden?: ");
            hoeveelheidSchaven = double.Parse(Console.ReadLine());

            //Aantal dagen berekenen
            if (nu.Month == leverdatum.Month)
            {
                aantalDagen = leverdatum.Day - nu.Day;
            }
            else
            {
                aantalDagen = 30 + leverdatum.Day - nu.Day;
            }

            //Houtkosten berekenen
            switch (klasse)
            {
                case 1:
                    houtkosten = 300 * hoeveelheidHout;
                    break;
                case 2:
                    houtkosten = 500 * hoeveelheidHout;
                    break;
                case 3:
                    houtkosten = 450 * hoeveelheidHout;
                    break;
            }
            //Schaafkosten?
            if (houtkosten < 200)
            {
                houtkosten += (0.60 * hoeveelheidSchaven);
            }

            //korting?
            if (aantalDagen < 14)
            {
                totaalBedrag = houtkosten * 1;
            }
            else if (aantalDagen >= 14 && aantalDagen < 21)
            {
                totaalBedrag = houtkosten * 0.99;
            }
            else if (aantalDagen >= 21 && aantalDagen < 28)
            {
                totaalBedrag = houtkosten * 0.98;
            }
            else
            {
                totaalBedrag = houtkosten * 0.975;
            }

            Console.WriteLine();
            Console.WriteLine("Het totaal bedrag is €" + Math.Round(totaalBedrag, 2).ToString());




            Console.ReadLine();
        }
    }
}
