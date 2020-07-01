using System;

namespace Opdracht_2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie van de variabelen
            double prijsExclBtw, prijsInclBtw;
            const double BTW = 21;

            //Het getal opvragen
            Console.Write("Wat is de prijs exclusief BTW? ");
            prijsInclBtw = Convert.ToDouble(Console.ReadLine());

            //De som berekenen
            prijsExclBtw = prijsInclBtw / (1 + BTW / 100);

            //Het resultaat weergeven in de console
            Console.WriteLine("Een bedrag van " + prijsInclBtw.ToString() + " EUR inclusief BTW komt overeen met "
                + prijsExclBtw.ToString() + " Eur exclusief BTW.");
            Console.ReadLine();
        }
    }
}
