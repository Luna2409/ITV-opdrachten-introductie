using System;

namespace _1_Taxikosten
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            TimeSpan starttijd, eindtijd, tijdRitDag, tijdRitNacht, tijdWeekend;
            TimeSpan zevenUur = TimeSpan.Parse("07:00");
            TimeSpan achtUur = TimeSpan.Parse("08:00");
            TimeSpan achttienUur = TimeSpan.Parse("18:00");
            double prijs = 0, km;
            Boolean weekendtariefBegin, weekendtariefEind = true;

            //Opvragen variabelen
            Console.Write("Wat is de starttijd van de rit?: ");
            starttijd = TimeSpan.Parse(Console.ReadLine());
            Console.Write("Wat is de eindtijd van de rit?: ");
            eindtijd = TimeSpan.Parse(Console.ReadLine());
            Console.Write("Hoeveel km is er gereden?: ");
            km = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Het weekendtarief geld vanaf vrijdag 22:00 tot maandag 07:00.");
            Console.Write("Is de rit begonnen in het weekend? (type True of False): ");
            weekendtariefBegin = bool.Parse(Console.ReadLine());
            if (weekendtariefBegin)
            {
                Console.Write("Is de rit geëindigt binnen het weekendtarief? (type True of False): ");
                weekendtariefEind = bool.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            //prijs berekenen
            if (starttijd < achtUur)
            {
                if (eindtijd < achtUur)
                {
                    tijdRitNacht = eindtijd.Subtract(starttijd);
                    prijs = km + (0.45 * tijdRitNacht.Minutes);
                }
                else if (eindtijd >= achtUur && eindtijd < achttienUur)
                {
                    tijdRitNacht = achtUur.Subtract(starttijd);
                    tijdRitDag = eindtijd.Subtract(achtUur);
                    prijs = km + (0.45 * tijdRitNacht.Minutes) + (0.25 * tijdRitDag.Minutes);
                }
                else
                {
                    tijdRitNacht = achtUur.Subtract(starttijd) + achttienUur.Subtract(eindtijd);
                    tijdRitDag = achttienUur.Subtract(achtUur);
                    prijs = km + (0.45 * tijdRitNacht.Minutes) + (0.25 * tijdRitDag.Minutes);
                }

                if (weekendtariefBegin && weekendtariefEind == false)
                {
                    tijdWeekend = zevenUur.Subtract(starttijd);
                    prijs = prijs - (0.45 * tijdWeekend.Minutes) + (0.45 * tijdWeekend.Minutes * 1.15);
                }
            }
            else if (starttijd >= achtUur && starttijd < achttienUur)
            {
                if (eindtijd >= achtUur && eindtijd < achttienUur)
                {
                    tijdRitDag = eindtijd.Subtract(starttijd);
                    prijs = km + (0.25 * tijdRitDag.Minutes);
                }
                else
                {
                    tijdRitDag = achttienUur.Subtract(starttijd);
                    tijdRitNacht = eindtijd.Subtract(achttienUur);
                    prijs = km + (0.25 * tijdRitDag.Minutes) + (0.45 * tijdRitNacht.Minutes);
                }
            }
            else
            {
                tijdRitNacht = eindtijd.Subtract(starttijd);
                prijs = km + (0.45 * tijdRitNacht.Minutes);
            }

            if (weekendtariefBegin && weekendtariefEind)
            {
                prijs = prijs * 1.15;
            }

            Console.WriteLine("De prijs van de rit = €" + Math.Round(prijs, 2));

            Console.ReadLine();
        }
    }
}
