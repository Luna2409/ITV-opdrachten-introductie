using System;

namespace Opdracht_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1, getal2, getal3, getal4, getal5, teller;
            int getalMax = 0;

            Console.Write("Voer getal 1 in: ");
            getal1 = int.Parse(Console.ReadLine());

            Console.Write("Voer getal 2 in: ");
            getal2 = int.Parse(Console.ReadLine());

            Console.Write("Voer getal 3 in: ");
            getal3 = int.Parse(Console.ReadLine());

            Console.Write("Voer getal 4 in: ");
            getal4 = int.Parse(Console.ReadLine());

            Console.Write("Voer getal 5 in: ");
            getal5 = int.Parse(Console.ReadLine());


            for (teller = 1; teller <= 5; teller++)
            {
                getalMax = Math.Max(getalMax, getal1);
                getal1 = getal2;
                getal2 = getal3;
                getal3 = getal4;
                getal4 = getal5;
            }
            Console.WriteLine("Het grootste getal = " + getalMax.ToString());
            Console.ReadLine();
        }
    }
}
