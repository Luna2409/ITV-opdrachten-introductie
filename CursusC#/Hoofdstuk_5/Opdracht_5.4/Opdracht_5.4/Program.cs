using System;

namespace Opdracht_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int teller, getal, som;
            som = 0;

            Console.Write("Voer getal in: ");
            getal = int.Parse(Console.ReadLine());

            for (teller = 1; teller <= getal; teller++)
            {
                som = som + teller;
            }

            Console.WriteLine("De som van " + getal.ToString() + " met al zijn voorgaande getallen is "
                + som.ToString());
            Console.ReadLine();
        }
    }
}
