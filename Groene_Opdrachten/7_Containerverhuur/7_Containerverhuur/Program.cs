using System;

namespace _7_Containerverhuur
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            DateTime beginDatum, eindDatum;
            int aantalDagen;
            double meter3, totaalBedrag;
            string vasteKlant;

            //Opvragen variabelen
            Console.Write("Op welke datum wilt u een container huren?: ");
            beginDatum = DateTime.Parse(Console.ReadLine());
            Console.Write("Wanneer moet de container opgehaald worden?: ");
            eindDatum = DateTime.Parse(Console.ReadLine());
            Console.Write("Hoeveel volume heeft u container nodig? (in m3): ");
            meter3 = int.Parse(Console.ReadLine());
            Console.Write("Bent u vaste klant? (ja of nee): ");
            vasteKlant = Console.ReadLine();

            //Aantal dagen
            if (beginDatum.Month == eindDatum.Month && beginDatum.Year == eindDatum.Year)
            {
                aantalDagen = eindDatum.Day - beginDatum.Day;
            }
            else if (beginDatum.Month != eindDatum.Month && beginDatum.Year == eindDatum.Year)
            {
                aantalDagen = (30 * (eindDatum.Month - beginDatum.Month)) + eindDatum.Day - beginDatum.Day;
            }
            else if (beginDatum.Month == eindDatum.Month && beginDatum.Year != eindDatum.Year)
            {
                aantalDagen = (12 * 30 * (eindDatum.Year - beginDatum.Year)) + eindDatum.Day - beginDatum.Day;
            }
            else
            {
                aantalDagen = ((eindDatum.Month - (12 - beginDatum.Month)) * 30 * (eindDatum.Year - beginDatum.Year))
                    + eindDatum.Day - beginDatum.Day;
            }

            //Kubieke meter
            totaalBedrag = 40 * meter3 * aantalDagen;
            if (meter3 <= 2)
            {
                totaalBedrag += 60;
            }
            else
            {
                totaalBedrag += 125;
            }

            //Vaste klanten korting?
            switch (vasteKlant)
            {
                case "ja":
                    totaalBedrag *= 0.85;
                    break;
                case "nee":
                    break;
            }

            //Weergave console
            Console.WriteLine();
            Console.WriteLine("Het totaal bedrag bedraagt € " + Math.Round(totaalBedrag, 2).ToString());


            Console.ReadLine();
        }
    }
}
