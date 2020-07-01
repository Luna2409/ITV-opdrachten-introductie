using System;

namespace Opdracht_2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie van de variabelen
            string voornaam, familienaam, straat, huisnummer, postcode, gemeente;
            
            //Het getal opvragen
            Console.Write("Voornaam: ");
            voornaam = Console.ReadLine();

            Console.Write("Familienaam: ");
            familienaam = Console.ReadLine();

            Console.Write("Straat: ");
            straat = Console.ReadLine();

            Console.Write("Huisnummer: ");
            huisnummer = Console.ReadLine();

            Console.Write("Postcode: ");
            postcode = Console.ReadLine();

            Console.Write("Gemeente: ");
            gemeente = Console.ReadLine();

            //Het resultaat weergeven in de console
            Console.WriteLine();
            Console.WriteLine(voornaam + " " + familienaam);
            Console.WriteLine(straat + " " + huisnummer);
            Console.WriteLine(postcode + " " + gemeente.ToUpper());
            Console.ReadLine();
        }
    }
}
