using System;

namespace Opdracht_7._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            int aantalLeerlingen;
            string klas;

            //Opvragen variabelen
            Console.Write("In welke klas zit je?: ");
            klas = Console.ReadLine();
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
            Console.WriteLine("In klas " + klas + " zitten de volgende leerlingen: ");

            //Weergave namen
            for (int teller = 0; teller < aantalLeerlingen; teller++)
            {
                Console.WriteLine(arrayNamen[teller]);
            }


            Console.ReadLine();
        }
    }
}
