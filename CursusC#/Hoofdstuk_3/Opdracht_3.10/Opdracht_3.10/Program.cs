using System;

namespace Opdracht_3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            double straal, hoogte, inhoud;

            //Titel
            Console.WriteLine("Inhoud van een kegel berekenen");
            Console.WriteLine();

            //Opvragen variabelen
            Console.Write("Wat is de straal van de kegel (in cm)?: ");
            straal = Double.Parse(Console.ReadLine());

            Console.Write("Wat is de hoogte van de kegel (in cm)?: ");
            hoogte = Double.Parse(Console.ReadLine());

            //Berekening
            inhoud = (Math.PI * Math.Pow(straal, 2) * hoogte) / 3;

            //Weergave in console
            Console.WriteLine();
            Console.WriteLine("De inhoud van de kegel = " + Math.Round(inhoud, 1).ToString() + " cm^3");
            Console.ReadLine();
        }
    }
}
