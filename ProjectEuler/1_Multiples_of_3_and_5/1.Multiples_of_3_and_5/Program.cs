using System;

namespace _1.Multiples_of_3_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            double som = 0;
            const double maxGetal = 1000;

            //multiples van 3 en 5 zoeken
            for (int teller = 1; teller < maxGetal; teller++)
            {
                if (teller % 3 == 0 || teller % 5 == 0)
                {
                    som += teller;
                }
            }
            Console.WriteLine("de som = " + som.ToString());

            Console.ReadLine();
        }
    }
}
