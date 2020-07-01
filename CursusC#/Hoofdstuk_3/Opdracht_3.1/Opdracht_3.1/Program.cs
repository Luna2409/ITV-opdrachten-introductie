using System;

namespace Opdracht_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie van de variabelen
            double gradHoekA, gradHoekC, lengteAB, radHoekA, radHoekC;
            const double lengteAC = 10;

            //De variabelen opvragen
            Console.Write("Graden hoek A = ");
            gradHoekA = double.Parse(Console.ReadLine());

            Console.Write("Graden hoek C = ");
            gradHoekC = double.Parse(Console.ReadLine());

            //De som berekenen
            radHoekA = gradHoekA * Math.PI / 180;
            radHoekC = gradHoekC * Math.PI / 180;
            lengteAB = lengteAC * Math.Sin(radHoekC) / Math.Sin(radHoekC + radHoekA);

            //Het resultaat weergeven in de console
            Console.WriteLine();
            Console.WriteLine("De afstand tussen punt A en punt B = " + Math.Round(lengteAB, 1).ToString() + " m");
            Console.ReadLine();
        }
    }
}
