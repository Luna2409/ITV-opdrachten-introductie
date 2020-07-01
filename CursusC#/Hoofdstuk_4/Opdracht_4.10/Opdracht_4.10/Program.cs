using System;

namespace Opdracht_4._10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            double lengte, gewicht, polsomtrek, idealeGewicht;
            bool geslacht;

            //Titel
            Console.WriteLine("\"Ideale\" gewicht");
            Console.WriteLine();

            //Opvragen variabelen
            Console.Write("Ben je een man? True or false?: ");
            geslacht = bool.Parse(Console.ReadLine());

            Console.Write("Wat is je lengte (cm)?: ");
            lengte = double.Parse(Console.ReadLine());

            Console.Write("Wat is je gewicht (kg)?: ");
            gewicht = double.Parse(Console.ReadLine());

            Console.Write("Wat is je polsomtrek (cm)?: ");
            polsomtrek = double.Parse(Console.ReadLine());

            //Weergave console
            if (geslacht)
            {
                idealeGewicht = (lengte - 100) * 90 / 100;
            }
            else
            {
                idealeGewicht = (lengte + 4 * polsomtrek - 100) / 2;
            }
            Console.WriteLine("Uw ideale lichaamsgewicht = " + Math.Round(idealeGewicht, 0).ToString());

            Console.ReadLine();
        }
    }
}
