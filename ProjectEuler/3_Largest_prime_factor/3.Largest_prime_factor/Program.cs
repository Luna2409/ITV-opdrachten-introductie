using System;

namespace _3.Largest_prime_factor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            long prime = 0;
            const long getal = 600851475143;

            //prime factors
            for (long teller = 1; teller < getal; teller++)
            {
                prime = 0;

                if (getal % teller == 0)
                {
                    for (long deler = 1; deler <= teller; deler++)
                    {
                        if (teller % deler == 0)
                        {
                            prime++;
                        }
                    }
                }
                if (prime == 2)
                {
                    Console.Write(teller.ToString() + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
