using System;

namespace Opdracht_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            int[] arrayGetallen = new int[9];
            int weergave;

            //Opvragen getallen
            for (int teller = 0; teller < 9; teller++)
            {
                Console.Write("Voer getal " + (teller + 1).ToString() + " in: ");
                arrayGetallen[teller] = int.Parse(Console.ReadLine());
            }

            //Opvragen welk getal gebruiker wilt zien
            Console.WriteLine();
            Console.Write("Het hoeveelste getal wil je zien?: ");
            weergave = int.Parse(Console.ReadLine());

            //Weergave getal dat gebruiker opgevraagd heeft
            Console.WriteLine();
            Console.WriteLine("Getal " + weergave.ToString() + " = " + arrayGetallen[weergave - 1].ToString());
        }
    }
}
