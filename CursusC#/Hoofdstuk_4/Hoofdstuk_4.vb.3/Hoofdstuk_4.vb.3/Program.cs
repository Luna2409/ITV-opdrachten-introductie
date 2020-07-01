using System;

namespace Hoofdstuk_4.vb._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            int leeftijd;
            bool gehuwd, geslacht;

            //Opvragen variabelen
            Console.Write("Hoe oud ben je?: ");
            leeftijd = int.Parse(Console.ReadLine());

            Console.Write("Ben je ongehuwd? True or false?: ");
            gehuwd = bool.Parse(Console.ReadLine());

            Console.Write("Ben je een vrouw? True or false?: ");
            geslacht = bool.Parse(Console.ReadLine());

            //leeftijd > 30 en ongehuwd: toegang tot de versus, anders: geen toegang.
            //Weergave console
            Console.WriteLine();
            if (leeftijd > 30 && gehuwd && geslacht)
            {
                Console.WriteLine("Je krijgt toegang tot de ladies night!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Helaas! Je krijgt geen toegang tot de Versus.");
                Console.ReadLine();
            }
        }
    }
}
