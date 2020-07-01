using System;

namespace _3_Autoverhuur._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            string auto, benzine;
            int kmTellerVoor, kmTellerNa, aantalKm, aantalDagen, kmVrij;
            double prijsKm = 0, prijsDagen = 0, prijsBenzine = 0, prijs;
            DateTime startDatum, eindDatum;

            //Anker instellen
            Auto:

            //Opvragen variabelen
            Console.Write("Welke auto is er verhuurt? (typ personenauto of personenbusje): ");
            auto = Console.ReadLine();
            switch (auto)
            {
                case "personenauto":
                    break;
                case "personenbusje":
                    break;
                default:
                    Console.WriteLine("U heeft een iets verkeerd ingetyped, probeer het opnieuw:");
                    goto Auto;
            }
            Console.Write("Wat was de datum waarop de auto uitgegeven is?: ");
            startDatum = DateTime.Parse(Console.ReadLine());
            Console.Write("Wat is de datum waarop de auto teruggebracht is?: ");
            eindDatum = DateTime.Parse(Console.ReadLine());
            Console.Write("Wat was de stand van de km teller voor het verhuur?: ");
            kmTellerVoor = int.Parse(Console.ReadLine());
            Console.Write("Wat is de stand van de km teller na het verhuur?: ");
            kmTellerNa = int.Parse(Console.ReadLine());
            //Anker instellen
            Benzine:
            Console.Write("Is de auto afgetankt? (typ ja of nee): ");
            benzine = Console.ReadLine();
            switch (benzine)
            {
                case "ja":
                    break;
                case "nee":
                    Console.Write("Wat zijn de kosten van de benzine?: € ");
                    prijsBenzine = double.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("U heeft een iets verkeerd ingetyped, probeer het opnieuw:");
                    goto Benzine;
            }
            Console.WriteLine();

            //Aantal dagen berekenen
            if (startDatum.Month == eindDatum.Month && startDatum.Year == eindDatum.Year)
            {
                aantalDagen = eindDatum.Day - startDatum.Day;
            }
            else if (startDatum.Month != eindDatum.Month && startDatum.Year == eindDatum.Year)
            {
                aantalDagen = (30 * (eindDatum.Month - startDatum.Month)) + eindDatum.Day - startDatum.Day;
            }
            else if (startDatum.Month == eindDatum.Month && startDatum.Year != eindDatum.Year)
            {
                aantalDagen = (12 * 30 * (eindDatum.Year - startDatum.Year)) + eindDatum.Day - startDatum.Day;
            }
            else
            {
                aantalDagen = ((eindDatum.Month - (12 - startDatum.Month)) * 30 * (eindDatum.Year - startDatum.Year))
                    + eindDatum.Day - startDatum.Day;
            }
            Console.WriteLine("Aantal huurdagen = " + aantalDagen.ToString());

            //Aantal km berekenen
            aantalKm = kmTellerNa - kmTellerVoor;
            Console.WriteLine("Aantal km gereden = " + aantalKm.ToString());
            kmVrij = aantalDagen * 100;
            aantalKm -= kmVrij;
            if (aantalKm < 0)
            {
                aantalKm = 0;
            }

            //Prijs berekenen
            switch (auto)
            {
                case "personenauto":
                    prijsKm = 0.20 * aantalKm;
                    prijsDagen = 50 * aantalDagen;
                    break;
                case "personenbusje":
                    prijsKm = 0.30 * aantalKm;
                    prijsDagen = 95 * aantalDagen;
                    break;
            }
            prijs = prijsKm + prijsDagen + prijsBenzine;

            //Weergave console
            Console.WriteLine("Kosten voor gereden km (100km/dag vrij) = € " + prijsKm.ToString());
            Console.WriteLine("Kosten voor aantal gehuurde dagen = € " + prijsDagen.ToString());
            switch (benzine)
            {
                case "ja":
                    break;
                case "nee":
                    Console.WriteLine("Kosten voor niet afgetankte auto = € " + prijsBenzine.ToString());
                    break;
            }
            Console.WriteLine("De totale kosten zijn: € " + prijs.ToString());

            Console.ReadLine();
        }
    }
}
