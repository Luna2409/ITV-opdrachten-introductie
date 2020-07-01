using System;

namespace Opdracht_5._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int teller, getal, som;
            som = 1;

            Console.Write("Voer een getal in: ");
            getal = int.Parse(Console.ReadLine());

            for (teller = 1; teller <= getal; teller++)
            {
                som = som * teller;
            }
            Console.WriteLine("De faculteit van " + getal.ToString() + " = " + som.ToString());

            Console.ReadLine();
        }
    }
}
