using System;

namespace _8_Transportbedrijf
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie varabelen
            string lading;
            double meter3, kg, kmBinnenNL, kmBuitenNL, waarde = 0, transportKosten = 0;
            double kostenKmBinnenNL, kostenKmBuitenNL, douanekosten, totaalBedrag;

            //Opvragen variabelen
            Console.Write("is de lading vloeibaar of niet vloeibaar?: ");
            lading = Console.ReadLine();
            Console.Write("Wat is de volume van de lading?: ");
            meter3 = double.Parse(Console.ReadLine());
            Console.Write("Wat is het gewicht van de lading?: ");
            kg = double.Parse(Console.ReadLine());
            Console.Write("Hoeveel km moet er binnen Nederland gereden worden?: ");
            kmBinnenNL = double.Parse(Console.ReadLine());
            Console.Write("Hoeveel km moet er buiten Nederland gereden worden?: ");
            kmBuitenNL = double.Parse(Console.ReadLine());

            //Kosten
            switch (lading)
            {
                case "vloeibaar":
                    transportKosten = (meter3 * 0.80) + (kg * 0.55); 
                    break;
                case "niet vloeibaar":
                    transportKosten = (meter3 * 1.25) + (kg * 0.45);
                    break;
            }

            //Kosten km binnnen NL
            kostenKmBinnenNL = transportKosten * kmBinnenNL;

            //Kosten km buiten NL
            if (kmBuitenNL > 0)
            {
                Console.Write("Wat is de waarde van de lading?: ");
                waarde = double.Parse(Console.ReadLine());
            }

            kostenKmBuitenNL = (transportKosten * kmBuitenNL) * 1.45;

            //Douanekosten
            douanekosten = waarde * 0.035;
            if (douanekosten < 45)
            {
                douanekosten = 45;
            }

            //totaal bedrag berekenen
            totaalBedrag = kostenKmBinnenNL + kostenKmBuitenNL + douanekosten;

            //totaal bedrag weergeven in console
            Console.WriteLine();
            Console.WriteLine("Het totaal verschuldigde bedrag bedraagt € " + Math.Round(totaalBedrag, 2));



            Console.ReadLine();
        }
    }
}
