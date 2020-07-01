using System;

namespace Opdracht_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            int aantal, korting, totaalbedrag;
            const int prijs = 125;

            //Titel
            Console.WriteLine("Kosten van de aankoop berekenen");
            Console.WriteLine();

            //Opvragen variabelen
            Console.Write("Aantal schoenen = ");
            aantal = int.Parse(Console.ReadLine());

            if (aantal == 1)
            {
                korting = 20;
            }
            else if (aantal == 2)
            {
                korting = 40;
            }
            else
            {
                korting = 60;
            }

            //Berekening
            totaalbedrag = aantal * prijs * (100 - korting) / 100;

            //Weergave console
            Console.WriteLine();
            Console.WriteLine("U krijgt " + korting.ToString() + "% korting.");
            Console.WriteLine("U moet " + totaalbedrag.ToString() + " EUR betalen.");
            Console.ReadLine();
        }
    }
}
