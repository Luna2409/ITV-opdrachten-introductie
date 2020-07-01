using System;

namespace Opdracht_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie van de variabelen
            double bedragTotaal, bedragMosselenFrietjes, bedragKoninginnehapje, bedragIjsjes, bedragDranken,
                aantalMosselenFrietjes, aantalKoninginnehapje, aantalIjsjes, aantalDranken;

            bedragMosselenFrietjes = 20;
            bedragKoninginnehapje = 10;
            bedragIjsjes = 3;
            bedragDranken = 2;

            //Het getal opvragen
            Console.Write("Aantal Mosselen met frietjes: ");
            aantalMosselenFrietjes = Convert.ToDouble(Console.ReadLine());

            Console.Write("Aantal Koninginnehapjes: ");
            aantalKoninginnehapje = Convert.ToDouble(Console.ReadLine());

            Console.Write("Aantal ijsjes: ");
            aantalIjsjes = Convert.ToDouble(Console.ReadLine());

            Console.Write("Aantal dranken: ");
            aantalDranken = Convert.ToDouble(Console.ReadLine());

            //De som berekenen
            bedragTotaal = bedragMosselenFrietjes * aantalMosselenFrietjes + bedragKoninginnehapje * aantalKoninginnehapje +
                bedragIjsjes * aantalIjsjes + bedragDranken * aantalDranken;

            //Het resultaat weergeven in de console
            Console.WriteLine("Het totaal te betalen bedrag is " + bedragTotaal.ToString() + " EUR");
            Console.ReadLine();
        }
    }
}
