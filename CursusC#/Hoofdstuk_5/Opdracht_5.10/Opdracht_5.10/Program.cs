using System;

namespace Opdracht_5._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal, teller, som = 0;

            //Anker instellen
            Begin:

            Console.Write("Voer een getal in (maximaal 10): ");
            getal = int.Parse(Console.ReadLine());

            Console.WriteLine();


            if (getal <= 10)
            {
                Console.WriteLine("De tafel van " + getal.ToString() + " is:");

                for (teller = 1; teller < 11; teller++)
                {

                    som = getal * teller;
                    Console.WriteLine(teller.ToString() + " * " + getal.ToString() +
                        " = " + som.ToString());
                }
            }
            else
            {
                Console.WriteLine("Fout getal ingevuld!");
                Console.WriteLine();
                //Ga terug naar anker
                goto Begin;
            }

            Console.ReadLine();

        }
    }
}
