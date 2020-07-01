using System;

namespace Opdracht_3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Decleratie variablen
            double straal, oppervlakte, omtrek;

            //Titel
            Console.WriteLine("oppervlakte en omtrek van een cirkel berekenen");
            Console.WriteLine();

            //Opvragen straal
            Console.Write("Wat is de straal van de cirkel? ");
            straal = Double.Parse(Console.ReadLine());

            //Berekening
            oppervlakte = Math.Pow(straal, 2) * Math.PI;
            omtrek = 2 * Math.PI * straal;

            //Weergeven in Console
            Console.WriteLine();
            Console.WriteLine("De oppervlakte van de cirkel = " + Math.Round(oppervlakte, 1).ToString());
            Console.WriteLine("De omtrek van de cirkel = " + Math.Round(omtrek, 1).ToString());
            Console.ReadLine();
        }
    }
}
