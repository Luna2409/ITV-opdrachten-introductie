using System;

namespace Opdracht_3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            DateTime laatsteAfspraak;

            //Titel
            Console.WriteLine("Wanneer is mijn volgende tandarts afspraak?");
            Console.WriteLine();

            //Opvragen variabelen
            Console.Write("Wanneer was je laatste tandarts afspraak?: ");
            laatsteAfspraak = DateTime.Parse(Console.ReadLine());

            //Weergave in console
            Console.WriteLine();
            Console.WriteLine("Je volgende tandarts afspraak is op " + laatsteAfspraak.AddMonths(6).ToLongDateString());
            Console.WriteLine("Je volgende tandarts afspraak is in " +
                laatsteAfspraak.AddMonths(6).Subtract(DateTime.Now).Days.ToString() + " dagen.");
            Console.ReadLine();
        }
    }
}
