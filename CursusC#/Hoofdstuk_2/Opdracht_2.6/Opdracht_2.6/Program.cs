using System;

namespace Opdracht_2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Declaratie van de variabelen
            int bedragTotaal, bedragVolwassenen, bedragKinderen,
                aantalVolwassenen, aantalKinderen;

            bedragVolwassenen = 25;
            bedragKinderen = 10;

            //Het getal opvragen
            Console.Write("Aantal Volwassenen: ");
            aantalVolwassenen = Convert.ToInt16(Console.ReadLine());

            Console.Write("Aantal Kinderen tot 12 jaar: ");
            aantalKinderen = Convert.ToInt16(Console.ReadLine());

            //De som berekenen
            bedragTotaal = bedragVolwassenen * aantalVolwassenen + bedragKinderen * aantalKinderen;

            //Het resultaat weergeven in de console
            Console.WriteLine("Het totaal te betalen bedrag is " + bedragTotaal.ToString() + " EUR");
            Console.ReadLine();
            

            /*
            //Code uit de oplossing
            
            //Declaratie van de variabelen
            int aantalVolwassen, aantalKind, teBetalen;
            const int prijsVolwassen = 25;
            const int prijsKind = 10;

            //Het getal opvragen
            Console.Write("Aantal Volwassenen = ");
            aantalVolwassen = Convert.ToInt16(Console.ReadLine());

            Console.Write("Aantal Kinderen = ");
            aantalKind = Convert.ToInt16(Console.ReadLine());

            //De som berekenen
            teBetalen = aantalVolwassen * prijsVolwassen + aantalKind * prijsKind;

            //Het resultaat weergeven in de console
            Console.WriteLine("Totaal te betalen = " + teBetalen.ToString());
            Console.ReadLine();
            */
        }
    }
}
