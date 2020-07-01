using System;

namespace Opdracht_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibon1, fibon2, fibon3;
            fibon1 = 0;
            fibon2 = 1;

            Console.Write(fibon1 + " " + fibon2 + " ");

            for (int teller = 0; teller < 8; teller++)
            {
                fibon3 = fibon1 + fibon2;
                fibon1 = fibon2;
                fibon2 = fibon3;
                Console.Write(fibon3.ToString() + " ");
            }

            Console.ReadLine();
        }
    }
}
