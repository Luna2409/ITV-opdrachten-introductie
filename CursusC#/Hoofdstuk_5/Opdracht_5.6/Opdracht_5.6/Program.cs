using System;

namespace Opdracht_5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int teller;

            for (teller = 1; teller <= 10; teller++)
            {
                Console.Write(Math.Pow(2, teller).ToString() + " ");
            }

            Console.ReadLine();
        }
    }
}
