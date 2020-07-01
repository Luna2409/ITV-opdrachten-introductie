using System;

namespace Opdracht_7._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            int aantalLeerlingen;
            string groep;

            //Opvragen variabelen
            Console.Write("In welke groep zit je?: ");
            groep = Console.ReadLine();
            Console.Write("Hoeveel leerlingen zitten er in je klas?: ");
            aantalLeerlingen = int.Parse(Console.ReadLine());

            //Declaratie array
            string[] arrayNamen = new string[aantalLeerlingen];

            //Opvaragen namen
            for (int teller = 0; teller < aantalLeerlingen; teller++)
            {
                Console.Write("Voer naam " + (teller + 1).ToString() + " in: ");
                arrayNamen[teller] = Console.ReadLine();
            }

            //Weergave console
            Console.WriteLine();
            Console.WriteLine("In groep " + groep + " zitten de volgende leerlingen: ");

            //Namen sorteren op alfabetische volgorde
            Array.Sort(arrayNamen);

            //Weergave namen
            for (int teller = 0; teller < aantalLeerlingen; teller++)
            {
                Console.WriteLine(arrayNamen[teller]);
            }

            Console.ReadLine();
        }
    }
}
