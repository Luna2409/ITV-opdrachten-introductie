using System;

namespace Opdracht_3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            DateTime geboortedatum;

            //Titel
            Console.WriteLine("Berekenen hoeveel dagen je al leeft");
            Console.WriteLine();

            //Opvragen variabelen
            Console.Write("Wat is je geboortedatum?: ");
            geboortedatum = DateTime.Parse(Console.ReadLine());

            //Weergave in console
            Console.WriteLine();
            Console.WriteLine("Je bent geboren op " + geboortedatum.ToShortDateString() + ".");
            Console.WriteLine("Je leeft al " + DateTime.Now.Subtract(geboortedatum).Days.ToString() + " dagen.");
            Console.ReadLine();
        }
    }
}
