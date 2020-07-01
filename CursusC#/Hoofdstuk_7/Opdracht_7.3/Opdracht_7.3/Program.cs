using System;

namespace Opdracht_7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            int[] arrayGetallen = new int[10];
            int getal;
            getal = arrayGetallen[0];

            //getallen opvragen en aan arrays toewijzen
            for (int teller = 0; teller < 10; teller++)
            {
                Console.Write("Voer getal " + (teller + 1).ToString() + " in: ");
                arrayGetallen[teller] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("De even getallen die je hebt ingevoerd zijn: ");

            //Toon alleen de even getallen
            for (int teller = 0; teller < 10; teller++)
            {
                if (arrayGetallen[teller] % 2 == 0)
                {
                    Console.Write(arrayGetallen[teller].ToString() + " ");
                }
            }

            /*
            for (int teller = 0; teller < 10; teller++)
            {
                if (teller % 2 == 0)
                {
                    getal += arrayGetallen[teller];
                    Console.WriteLine("Getal " + (teller + 2).ToString() + " = " + arrayGetallen[teller + 1].ToString());
                }
                else
                {
                    getal -= arrayGetallen[teller];
                }
            }
            */

            Console.ReadLine();
        }
    }
}
