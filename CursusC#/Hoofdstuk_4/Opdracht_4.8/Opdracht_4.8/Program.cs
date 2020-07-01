using System;

namespace Opdracht_4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            int leeftijd, prijs;

            //Titel
            Console.WriteLine("Lidmaatschap bibliotheek");
            Console.WriteLine();

            //Opvragen variabelen
            Console.Write("Hoe oud ben je?: ");
            leeftijd = int.Parse(Console.ReadLine());

            //Weergave console
            Console.WriteLine();
            if (leeftijd < 26)
            {
                prijs = 5;
            }
            else
            {
                prijs = 10;
            }

            Console.WriteLine("Uw lidgeld bedraagt €" + prijs.ToString());

            Console.ReadLine();
        }
    }
}
