using System;

namespace Opdracht_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            DateTime verjaardag;

            //Opvragen variabel
            Console.Write("Wanneer is je volgende verjaardag? ");
            verjaardag = DateTime.Parse(Console.ReadLine());

            //Weergave console
            Console.WriteLine();
            Console.WriteLine("Je verjaardag is op " + verjaardag.ToShortDateString() + ", dus nog " +
                verjaardag.Subtract(DateTime.Now).Days.ToString() + " dagen tot je volgende verjaardag");
            Console.ReadLine();
        }
    }
}
