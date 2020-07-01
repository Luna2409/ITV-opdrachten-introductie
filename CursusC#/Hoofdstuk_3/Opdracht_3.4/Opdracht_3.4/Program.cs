using System;

namespace Opdracht_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            string familienaam, zoneNummer, postcode, wachtwoord;

            //Opvragen variabelen
            Console.WriteLine("Wachtwoord Generator");
            Console.WriteLine();

            Console.Write("Wat is je familienaam? (zonder tussenvoegsel) ");
            familienaam = Console.ReadLine();

            Console.Write("Wat is het zonenummer van je vaste telefoonnummer? ");
            zoneNummer = Console.ReadLine();

            Console.Write("Wat is je postcode? ");
            postcode = Console.ReadLine();

            //Wachtwoord maken
            wachtwoord = familienaam.Substring(1, 1).ToLower() +
                familienaam.Substring(0, 1).ToUpper() +
                zoneNummer.Replace("0", "") +
                Math.Pow(int.Parse(postcode.Substring(0, 1)), 2);

            //Weergave console
            Console.WriteLine();
            Console.WriteLine("Je wachtwoord = " + wachtwoord);
            Console.ReadLine();
        }
    }
}
