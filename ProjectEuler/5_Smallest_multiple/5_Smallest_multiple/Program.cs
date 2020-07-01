using System;

namespace _5_Smallest_multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            int teller = 0;

            do
            {
                teller++;

                if (teller % 1 == 0 && teller % 2 == 0 && teller % 3 == 0 && teller % 4 == 0 && teller % 5 == 0 &&
                   teller % 6 == 0 && teller % 7 == 0 && teller % 8 == 0 && teller % 9 == 0 && teller % 10 == 0 &&
                   teller % 11 == 0 && teller % 12 == 0 && teller % 13 == 0 && teller % 14 == 0 && teller % 15 == 0 &&
                   teller % 16 == 0 && teller % 17 == 0 && teller % 18 == 0 && teller % 19 == 0 && teller % 20 == 0)
                {
                    Console.WriteLine(teller.ToString());
                }
                

            } while (teller % 1 != 0 || teller % 2 != 0 || teller % 3 != 0 || teller % 4 != 0 || teller % 5 != 0 ||
                    teller % 6 != 0 || teller % 7 != 0 || teller % 8 != 0 || teller % 9 != 0 || teller % 10 != 0 ||
                    teller % 11 != 0 || teller % 12 != 0 || teller % 13 != 0 || teller % 14 != 0 || teller % 15 != 0 ||
                    teller % 16 != 0 || teller % 17 != 0 || teller % 18 != 0 || teller % 19 != 0 || teller % 20 != 0);
            


            Console.ReadLine();
        }
    }
}
