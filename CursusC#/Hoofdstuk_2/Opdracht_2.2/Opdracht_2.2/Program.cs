using System;

namespace Opdracht_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie van de variabelen
            double dFahrenheit, dCelcius;

            //De 2 getallen opvragen
            Console.Write("graden Celsius: ");
            dCelcius = Convert.ToDouble(Console.ReadLine());

            //De som berekenen
            dFahrenheit = (Convert.ToDouble(9) / Convert.ToDouble(5)) * dCelcius + 32;

            //Het resultaat weergeven in de console
            Console.WriteLine("graden Fahrenheit: " + dFahrenheit.ToString());
            Console.ReadLine();
        }
    }
}
