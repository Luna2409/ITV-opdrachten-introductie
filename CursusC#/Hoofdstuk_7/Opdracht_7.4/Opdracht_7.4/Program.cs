using System;

namespace Opdracht_7._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            int[] arraycijf1 = new int[5];
            int[] arraycijf2 = new int[5];
            int[] arraysom = new int[5];

            //Opvragen getallen reeks 1
            for (int teller = 0; teller < 5; teller++)
            {
                Console.Write("Voer getal " + (teller + 1).ToString() + " in (tussen 0 en 10): ");
                arraycijf1[teller] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            //Opvragen getallen reeks 2
            for (int teller = 0; teller < 5; teller++)
            {
                Console.Write("Voer getal " + (teller + 1).ToString() + " in (tussen 0 en 10): ");
                arraycijf2[teller] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            //Weergave in console
            for (int teller = 0; teller < 5; teller++)
            {
                arraysom[teller] = arraycijf1[teller] + arraycijf2[teller];
                Console.WriteLine(arraycijf1[teller].ToString() + " + " + arraycijf2[teller].ToString() +
                    " = " + arraysom[teller].ToString());
            }

            Console.ReadLine();
        }
    }
}
