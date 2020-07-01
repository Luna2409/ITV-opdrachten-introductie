using System;

namespace _6_Camping
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            DateTime begindatum, einddatum;
            int aantalMeters, aantalPersonen, aantalHonden;
            int totaalAantalDagen = 0, dagenBuitenSeizoen = 0, dagenBinnenSeizoen = 0;
            int prijsPerMeter = 0, prijsextraMeters = 0, prijsPerPersoon = 0;
            int prijsPerHond = 0, prijsAuto = 0, totaalprijs = 0;
            string auto;

            //Titel
            Console.WriteLine("Boek je vakantie op onze camping:");
            Console.WriteLine();

            //Opvragen variabelen
            Console.Write("Startdatum: ");
            begindatum = DateTime.Parse(Console.ReadLine());
            Console.Write("Einddatum: ");
            einddatum = DateTime.Parse(Console.ReadLine());
            Console.Write("Benodigde breedte plaats (basis breedte is 10m), aantal meter: ");
            aantalMeters = int.Parse(Console.ReadLine());
            Console.Write("Met hoeveel personen wilt u camperen?: ");
            aantalPersonen = int.Parse(Console.ReadLine());
            Console.Write("Hoeveel honden wilt u meenemen?: ");
            aantalHonden = int.Parse(Console.ReadLine());
            Console.Write("Wilt u de auto bij de tent hebben staan?(typ ja of nee): ");
            auto = Console.ReadLine();


            //Aantal dagen uitrekenen
            if (begindatum.Month == einddatum.Month)
            {
                totaalAantalDagen = einddatum.Day - begindatum.Day;
            }
            else
            {
                totaalAantalDagen = (31 + einddatum.Day) - begindatum.Day;
            }
            //Aantal dagen buiten hoofdseizoen
            if (begindatum.Day < 11 && begindatum.Month == 7)
            {
                dagenBuitenSeizoen = 11 - begindatum.Day;

                if (einddatum.Day > 15 && einddatum.Month == 8)
                {
                    dagenBuitenSeizoen += (einddatum.Day - 15);
                }
            }
            else if (einddatum.Day > 15 && einddatum.Month == 8)
            {
                dagenBuitenSeizoen = einddatum.Day - 15;
            }
            //Aantal dagen binnnen hoofdseizoen
            dagenBinnenSeizoen = totaalAantalDagen - dagenBuitenSeizoen;

            //Prijs per voor aantal meters berekenen
            if (aantalMeters == 10)
            {
                prijsPerMeter = (dagenBuitenSeizoen * 25) + (dagenBinnenSeizoen * 30);
            }
            else if (aantalMeters < 10)
            {
                prijsextraMeters = (10 - aantalMeters) * 2;
                prijsPerMeter = (dagenBuitenSeizoen * (25 - prijsextraMeters)) + (dagenBinnenSeizoen * (30 - prijsextraMeters));
            }
            else
            {
                prijsextraMeters = (aantalMeters - 10) * 3;
                prijsPerMeter = (dagenBuitenSeizoen * (25 + prijsextraMeters)) + (dagenBinnenSeizoen * (30 + prijsextraMeters));
            }

            //Prijs per persoon
            prijsPerPersoon = (dagenBuitenSeizoen * (aantalPersonen * 5)) + (dagenBinnenSeizoen * (aantalPersonen * 5));

            //Prijs per hond
            prijsPerHond = (dagenBuitenSeizoen * (aantalHonden * 4)) + (dagenBinnenSeizoen * (aantalHonden * 4));

            //Prijs voor auto bij de tent
            switch (auto)
            {
                case "ja":
                    prijsAuto = (dagenBuitenSeizoen * 6) + (dagenBinnenSeizoen * 6);
                    break;
                case "nee":
                    break;
            }

            //Totaal prijs berekenen
            totaalprijs = prijsPerMeter + prijsPerPersoon + prijsPerHond + prijsAuto;

            //Weergave console
            Console.WriteLine();
            Console.WriteLine("Het totale bedrag bedraagt €" + totaalprijs.ToString());

            Console.ReadLine();
        }
    }
}
