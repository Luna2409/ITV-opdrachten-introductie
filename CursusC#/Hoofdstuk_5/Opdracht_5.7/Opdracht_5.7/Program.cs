using System;

namespace Opdracht_5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            double liter, km;
            double totLiter = 0;
            double totKm = 0;
            double verbruik = 0;

            do
            {
                Console.Write("Hoeveel liter heeft u getankt?: ");
                liter = double.Parse(Console.ReadLine());

                if (liter != 0)
                {
                    Console.Write("Hoeveel km heeft u gereden sinds de vorige tankbeurt?: ");
                    km = double.Parse(Console.ReadLine());

                    totLiter = totLiter + liter;
                    totKm = totKm + km;
                    verbruik = (totLiter / totKm) * 100;
                }

            } while (liter != 0);

            Console.WriteLine("Je verbruik is " + Math.Round(verbruik, 1).ToString() + " liter per 100 km.");

            Console.ReadLine();
        }
    }
}
