using System;

namespace Opdracht_2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie van de variabelen
            double verkoopprijs, inkoopprijs;
            const double winstmarge = 190;

            //Het getal opvragen
            Console.Write("Wat is de inkoopprijs? ");
            inkoopprijs = Convert.ToDouble(Console.ReadLine());

            //De som berekenen
            verkoopprijs = inkoopprijs * (1 + winstmarge / 100);

            //Het resultaat weergeven in de console
            Console.WriteLine();
            Console.WriteLine("Verkoopprijs = " + verkoopprijs.ToString());
            Console.ReadLine();
        }
    }
}

