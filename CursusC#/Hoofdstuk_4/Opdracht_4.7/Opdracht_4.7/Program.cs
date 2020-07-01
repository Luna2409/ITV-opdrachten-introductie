using System;

namespace Opdracht_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabele
            double exBTW, naFactuurdatum, korting, bedragMetKorting, nieuwExBTW, bedragBTW, inclBTW;

            //Titel
            Console.WriteLine("BTW");
            Console.WriteLine();

            //Opvragen variable
            Console.Write("Bedrag exclusief BTW: ");
            exBTW = double.Parse(Console.ReadLine());

            Console.Write("Aantal dagen na factuurdatum: ");
            naFactuurdatum = double.Parse(Console.ReadLine());
            
            //Weergave console
            Console.WriteLine();

            //Bedrag exclusief BTW
            Console.WriteLine("Het bedrag exclusief BTW = €" + Math.Round(exBTW,2).ToString());

            //Eventuele financiële korting
            if (naFactuurdatum <= 10)
            {
                korting = 2;
            }
            else
            {
                korting = 0;
            }
            bedragMetKorting = exBTW * korting / 100;
            Console.WriteLine("De financiële korting = €" + Math.Round(bedragMetKorting,2).ToString());

            //bedrag excl. BTW verminderd met financiële korting
            nieuwExBTW = exBTW - bedragMetKorting;
            Console.WriteLine("Het bedrag exclusief BTW verminderd met de financiële korting = €" +
                Math.Round(nieuwExBTW,2).ToString());

            //Het BTW bedrag
            bedragBTW = nieuwExBTW * 21 / 100;
            Console.WriteLine("Het BTW bedrag = €" + Math.Round(bedragBTW,2).ToString());

            //Het bedrag inclusief BTW
            inclBTW = nieuwExBTW + bedragBTW;
            Console.WriteLine("Het bedrag inclusief BTW = €" + Math.Round(inclBTW,2).ToString());

            Console.ReadLine();
        }
    }
}
