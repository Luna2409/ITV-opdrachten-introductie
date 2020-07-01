using System;

namespace Opdracht_3._12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            DateTime geboortedatum;

            //Titel
            Console.WriteLine("Op welke dag van de week ben je geboren?");
            Console.WriteLine();

            //Opvragen variabelen
            Console.Write("Wat is je geboortedatum?: ");
            geboortedatum = DateTime.Parse(Console.ReadLine());

            //Weergave in console
            Console.WriteLine();
            Console.WriteLine("Je bent geboren op een " + geboortedatum.DayOfWeek.ToString());
            Console.ReadLine();
        }
    }
}
