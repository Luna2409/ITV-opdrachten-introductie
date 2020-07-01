using System;

namespace Opdracht_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Anker instellen
            Begin:

            //Declaratie variabelen
            int laatsteTweeNummers = 0, nummer = 0, nummer97 = 0, som = 0, rest = 0, controle = 0;

            //format ondernemingsnummer
            Console.WriteLine("Voer hieronder het ondernemingsnummer in volgens dit format: BE 0XXX.XXX.XXX");
            Console.WriteLine("Voer alleen de cijfers in die op de x'en moeten staan. (zonder punten ertussen)");
            Console.WriteLine();

            //Opvragen ondernemingsnummer
            Console.Write("Voer ondernemingsnummer in: ");
            nummer = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (nummer <= 999999999)
            {
                //Berekenen of het ondernemingsnummer gelding is
                laatsteTweeNummers = nummer % 100;
                nummer = nummer / 100;
                nummer97 = nummer / 97;
                som = nummer97 * 97;
                rest = nummer - som;
                controle = 97 - rest;

                if (controle == laatsteTweeNummers)
                {
                    Console.WriteLine("Geldig ondernemingsnummer");
                }
                else
                {
                    Console.WriteLine("Ongeldig ondernemingsnummer");
                }
            }
            else
            {
                Console.WriteLine("Geef het ondernemingsnummer in volgens de juiste format.");
                goto Begin;
            }
            Console.WriteLine();

            Console.Write("Voer BTW in om de console te stoppen: ");
                        
            Console.ReadLine();

           
        }
    }
}
