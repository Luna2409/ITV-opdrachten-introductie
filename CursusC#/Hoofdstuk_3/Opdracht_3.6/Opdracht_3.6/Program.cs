using System;

namespace Opdracht_3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            int getal1, getal2;

            //Titel
            Console.WriteLine("Geeft weer het grootste getal van de 2 ingegeven getallen");
            Console.WriteLine();

            //Opvragen variabelen
            Console.Write("Getal 1 = ");
            getal1 = int.Parse(Console.ReadLine());

            Console.Write("Getal 2 = ");
            getal2 = int.Parse(Console.ReadLine());

            //Weergave console
            Console.WriteLine();
            Console.WriteLine("Het grootste getal is " + Math.Max(getal1, getal2));
            Console.ReadLine();
        }
    }
}
