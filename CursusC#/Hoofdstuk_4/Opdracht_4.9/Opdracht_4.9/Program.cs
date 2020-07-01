using System;

namespace Opdracht_4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            int leeftijd;
            double prijs = 13.70;

            //Titel
            Console.WriteLine("Prijs voor de bioscoop");
            Console.WriteLine();

            //Opvragen variable
            Console.Write("Hoe oud ben je?: ");
            leeftijd = int.Parse(Console.ReadLine());

            //prijs vaststellen
            Console.WriteLine();
            if (leeftijd < 5)
            {
                prijs = 0;
            }
            else if (leeftijd >= 5 && leeftijd <= 12)
            {
                prijs = 0.5 * prijs;
            }
            else if (leeftijd >= 13 && leeftijd <= 54)
            {
                prijs = 13.70;
            }
            else
            {
                prijs = 0;
            }

            //Weergave console
            Console.WriteLine("De prijs voor je bioscoopkaartje = €" + Math.Round(prijs, 2).ToString());

            Console.ReadLine();
        }
    }
}
