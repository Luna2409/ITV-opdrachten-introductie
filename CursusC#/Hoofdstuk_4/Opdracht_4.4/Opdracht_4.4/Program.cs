using System;

namespace Opdracht_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            int examen1, examen2, examen3, examen4, examen5, aantalOnv;
            double gem;
            aantalOnv = 0;

            //Titel
            Console.WriteLine("berekenen of de student geslaagd is voor zijn examens");
            Console.WriteLine();

            //Opvragen variabelen
            Console.Write("% voor examen 1 = ");
            examen1 = int.Parse(Console.ReadLine());
            if (examen1 < 50)
            {
                aantalOnv = aantalOnv + 1;
            }

            Console.Write("% voor examen 2 = ");
            examen2 = int.Parse(Console.ReadLine());
            if (examen2 < 50)
            {
                aantalOnv = aantalOnv + 1;
            }

            Console.Write("% voor examen 3 = ");
            examen3 = int.Parse(Console.ReadLine());
            if (examen3 < 50)
            {
                aantalOnv = aantalOnv + 1;
            }

            Console.Write("% voor examen 4 = ");
            examen4 = int.Parse(Console.ReadLine());
            if (examen4 < 50)
            {
                aantalOnv = aantalOnv + 1;
            }

            Console.Write("% voor examen 5 = ");
            examen5 = int.Parse(Console.ReadLine());
            if (examen5 < 50)
            {
                aantalOnv = aantalOnv + 1;
            }

            //Gemiddelde berekenen
            gem = (examen1 + examen2 + examen3 + examen4 + examen5) / 5;

            //Weergave console
            Console.WriteLine();
            if (aantalOnv <= 1 && gem >= 50)
            {
                Console.WriteLine("Gefeliciteerd! Je bent geslaagd! Je behaalde "
                    + gem.ToString() + "%.");
            }
            else
            {
                Console.WriteLine("Helaas, je bent niet geslaagd. Je behaalde " +
                    gem.ToString() + "%.");
            }
            Console.ReadLine();
        }
    }
}
