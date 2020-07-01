using System;

namespace Opdracht_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            double deeltal, deler, som;

            //Opvragen variabelen
            Console.Write("Voer het deeltal in: ");
            deeltal = double.Parse(Console.ReadLine());
            Console.Write("Voer de deler in: ");
            deler = double.Parse(Console.ReadLine());
            Console.WriteLine();

            //Checken of de deler niet gelijk is aan 0
            if (deler != 0)
            {
                //Som berekenen
                som = deeltal / deler;

                //Weergave console
                Console.WriteLine(deeltal.ToString() + " / " + deler.ToString() + " = " + som.ToString());
            }
            else
            {
                Console.WriteLine("Wie deelt door nul is een snul!");
            }

            Console.ReadLine();
        }
    }
}
