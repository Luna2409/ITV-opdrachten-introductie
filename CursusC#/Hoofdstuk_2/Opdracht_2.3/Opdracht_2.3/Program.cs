using System;

namespace Opdracht_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
			//Declaratie van de variabelen
			decimal Dollar, Euro;

			//Het getal opvragen
			Console.Write("aantal euro: ");
			Euro = Convert.ToDecimal(Console.ReadLine());

			//De som berekenen
			Dollar = Euro * Convert.ToDecimal(1.2231);

			//Het resultaat weergeven in de console
			Console.WriteLine(Euro.ToString() + " EUR is gelijk aan " + Math.Round(Dollar, 2).ToString() + " USD");
			Console.ReadLine();
		}
    }
}
