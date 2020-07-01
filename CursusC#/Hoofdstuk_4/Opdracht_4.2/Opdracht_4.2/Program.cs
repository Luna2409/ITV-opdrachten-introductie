using System;

namespace Opdracht_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            int aantal, korting, totaalPrijs;
            const int prijs = 100;

            //Opvragen variabelen
            Console.Write("Aantal schoenen: ");
            aantal = int.Parse(Console.ReadLine());

            Console.WriteLine();
            if (aantal < 2)
            {
                korting = 0;
                Console.WriteLine("U krijgt geen korting.");
            }
            else
            {
                korting = 25;
                Console.WriteLine("U krijgt 25% korting.");
            }

            //Berekening
            totaalPrijs = (aantal * prijs) * (100 - korting) / 100;

            //Weergave console
            Console.WriteLine("Het totaal te betalen bedrag = " + totaalPrijs.ToString());
            Console.ReadLine(); 
        }
    }
}
