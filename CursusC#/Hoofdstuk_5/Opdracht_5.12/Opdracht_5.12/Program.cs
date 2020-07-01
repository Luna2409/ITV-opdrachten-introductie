using System;

namespace Opdracht_5._12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            Random random = new Random();
            int randomGtl, antwGeb, teller;

            //Titel
            Console.WriteLine("#################################");
            Console.WriteLine("# Raad een getal tusses 1 en 10 #");
            Console.WriteLine("#################################");
            Console.WriteLine();

            //random getal genereren
            randomGtl = random.Next(1, 10);

            //Weergave in console
            Console.Write("Welk getal zoeken we?: ");
            antwGeb = int.Parse(Console.ReadLine());

            for (teller = 1; randomGtl != antwGeb; teller++)
            {
                if (randomGtl > antwGeb && antwGeb <= 10)
                {
                    Console.WriteLine();
                    Console.Write("Raad hoger!: ");
                }
                else if (randomGtl < antwGeb && antwGeb <= 10)
                {
                    Console.WriteLine();
                    Console.Write("Raad lager!: ");
                }
                else
                {
                    Console.WriteLine();
                    Console.Write("Voer een getal in tussen 1 en 10!: ");
                }
                antwGeb = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Joepie. Je hebt gewonnen!");
            Console.WriteLine("Je had " + teller.ToString() + " pogingen nodig.");

            Console.ReadLine();
        }
    }
}
