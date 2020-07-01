using System;

namespace _12_Opleidingsinstituut
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            DateTime nu = DateTime.Now;
            DateTime geboortedatum;
            int schriftelijk, mondeling, practisch, aantalVakken,  leeftijd;
            double lesgeld, materiaal, totaal;
            string arbeitsbureau;

            //Opvragen variabelen
            Console.Write("Wat is uw geboortedatum?: ");
            geboortedatum = DateTime.Parse(Console.ReadLine());
            Console.Write("Hoeveel schriftelijke vakken wilt u volgen?: ");
            schriftelijk = int.Parse(Console.ReadLine());
            Console.Write("Hoeveel mondelinge vakken wilt u volgen?: ");
            mondeling = int.Parse(Console.ReadLine());
            Console.Write("Hoeveel practische vakken wilt u volgen?: ");
            practisch = int.Parse(Console.ReadLine());
            Console.Write("Bent u hier door bemiddeling van het arbeidsbureau?(ja/nee): ");
            arbeitsbureau = Console.ReadLine();

            //aantal vakken
            aantalVakken = schriftelijk + mondeling + practisch;
            //lesgeld
            lesgeld = schriftelijk * 50 + mondeling * 150 + practisch * 150;
            //studiemateriaal
            materiaal = schriftelijk * 50 + mondeling * 50 + practisch * 125;
            //leeftijd berekenen
            leeftijd = nu.Year - geboortedatum.Year;
            if (nu.Month < geboortedatum.Month || (nu.Month == geboortedatum.Month && nu.Day < geboortedatum.Day))
            {
                leeftijd--;
            }
            //meer dan 5 vakken > 5% korting lesgeld
            if (aantalVakken >= 5)
            {
                lesgeld *= 0.95;
            }
            //Via arbeidsbureau?
            switch (arbeitsbureau)
            {
                case "ja":
                    materiaal = 0;
                    break;
                case "nee":
                    break;
            }
            //Jonger dan 19 > 2% korting
            totaal = lesgeld + materiaal;
            if (leeftijd < 19)
            {
                totaal *= 0.98;
            }

            //Het totale bedrag in console weergeven
            Console.WriteLine();
            Console.WriteLine("Het totaal verschuldigde berag bedraagt €" + Math.Round(totaal, 2).ToString());




            Console.ReadLine();
        }
    }
}
