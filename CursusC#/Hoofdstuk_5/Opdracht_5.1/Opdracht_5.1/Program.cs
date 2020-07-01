using System;

namespace Opdracht_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            double aantalRatten = 2;
            int teller = 0;
            const double groei = 1.15;

            //Berekening
            for (teller = 0; aantalRatten <= 10; teller++)
            {
                aantalRatten = aantalRatten * groei;
            }

            //Weergave console
            Console.WriteLine("Het duurt " + teller.ToString() + " jaar totdat er 10 miljoen ratten in New York zijn.");

            Console.ReadLine();
        }
    }
}
