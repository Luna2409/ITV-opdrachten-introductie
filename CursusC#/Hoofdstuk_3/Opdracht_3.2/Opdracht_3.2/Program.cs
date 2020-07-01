using System;

namespace Opdracht_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            double beginKap, looptijd, eindKap;
            const double rente = 0.0125;

            //Opvragen variabelen
            Console.Write("Beginkapitaal = ");
            beginKap = double.Parse(Console.ReadLine());

            Console.Write("Looptijd (in jaren) = ");
            looptijd = double.Parse(Console.ReadLine());

            //Som
            eindKap = beginKap * Math.Pow((1 + rente), looptijd);

            //Weergave console
            Console.WriteLine();
            Console.WriteLine("Het eindkapitaal = " + Math.Round(eindKap, 2).ToString() + " EUR");
            Console.ReadLine();
        }
    }
}
