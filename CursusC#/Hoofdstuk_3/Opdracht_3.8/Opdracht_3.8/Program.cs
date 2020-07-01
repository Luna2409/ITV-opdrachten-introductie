using System;

namespace Opdracht_3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declatie variabelen
            double bmi, gewicht, lengte;

            //Titel
            Console.WriteLine("BMI berekenen");
            Console.WriteLine();

            //Opvragen lengte en gewicht
            Console.Write("Gewicht in kg = ");
            gewicht = Double.Parse(Console.ReadLine());

            Console.Write("Lengte in meter = ");
            lengte = Double.Parse(Console.ReadLine());

            //Berekening
            bmi = gewicht / Math.Pow(lengte, 2);

            //Weergave in console
            Console.WriteLine();
            Console.WriteLine("De BMI = " + Math.Round(bmi, 0).ToString());
            Console.ReadLine();
        }
    }
}
