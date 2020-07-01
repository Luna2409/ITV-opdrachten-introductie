using System;

namespace _7_10001_st_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            int teller, deler, getal, prime = 0;

            //priemgetallen berekenen
            for (teller = 1; prime < 10001; teller++)
            {
                getal = 0;

                for (deler = 1; deler <= teller; deler++)
                {
                    if (teller % deler == 0)
                    {
                        getal++;
                    }
                }
                if (getal == 2)
                {
                    prime++;
                }
            }

            Console.WriteLine((teller - 1).ToString());

            Console.ReadLine();
        }
    }
}
