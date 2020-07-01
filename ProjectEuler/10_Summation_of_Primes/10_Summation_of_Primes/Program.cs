using System;
using System.Collections;

namespace _10_Summation_of_Primes
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = 1999999;
            long som = 0;
            bool[] arrayNumbers = new bool[n + 1];

            for (int i = 0; i < n; i++)
            {
                arrayNumbers[i] = true;
            }

            for (int p = 2; p*p <= n; p++)
            {
                if (arrayNumbers[p] == true)
                {
                    for (int i = p*p; i <= n; i += p)
                    {
                        arrayNumbers[i] = false;
                    }
                }
            }

            for (int i = 2; i <= n; i++)
            {
                if (arrayNumbers[i] == true)
                {
                    som += i;
                }
            }

            Console.Write(som.ToString());


            /*
            int aantal, som = 0;

            1999999

            for (int getal = 1; getal < 2.000.000; getal++)
            {
                aantal = 0;

                for (int deler = 1; deler <= getal; deler++)
                {
                    if (getal % deler == 0)
                    {
                        aantal++;
                    }
                }

                if (aantal == 2)
                {
                    som += getal;
                }
            }

            Console.WriteLine(som.ToString());

            Console.ReadLine();
            */


        }
    }
}
