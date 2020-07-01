using System;

namespace Hoofdstuk_4.vb._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie van de variabelen
            int leeftijd;

            //Opvragen variabelen
            Console.Write("Hoe oud ben je?: ");
            leeftijd = int.Parse(Console.ReadLine());

            //leeftijd >= 16: toegang tot de versus, leeftijd >= 21: toegang tot de VIP-lounge, Leeftijd <16: geen toegang.
            //Weergave console
            Console.WriteLine();
            if (leeftijd >= 21)
            {
                Console.WriteLine("Je krijgt toegang tot onze exclusieve VIP-lounge!");
            }
            else if (leeftijd >= 16)
            {
                Console.WriteLine("Je bent " + leeftijd.ToString() +
                    " jaar oud. Veel plezier in de Versus.");
            }
            else
            {
                Console.WriteLine("Helaas! Je moet minimum 16 jaar zijn om toegang te krijgen tot de Versus");
            }
            Console.ReadLine();
        }
    }
}
