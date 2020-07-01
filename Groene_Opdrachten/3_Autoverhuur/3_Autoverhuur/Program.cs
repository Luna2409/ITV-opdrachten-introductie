using System;

namespace _3_Autoverhuur
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            bool auto, benzine;
            int kmTellerVoor, kmTellerNa, aantalKm, aantalDagen, kmVrij;
            double prijsKm, prijsDagen, prijsBenzine = 0, prijs;
            DateTime startDatum, eindDatum;

            //Opvragen variabelen
            Console.Write("Welke auto is er verhuurt? (personenauto > type true, personenbusje > type false): ");
            auto = bool.Parse(Console.ReadLine());
            Console.Write("Wat was de datum waarop de auto uitgegeven is?: ");
            startDatum = DateTime.Parse(Console.ReadLine());
            Console.Write("Wat is de datum waarop de auto teruggebracht is?: ");
            eindDatum = DateTime.Parse(Console.ReadLine());
            Console.Write("Wat was de stand van de km teller voor het verhuur?: ");
            kmTellerVoor = int.Parse(Console.ReadLine());
            Console.Write("Wat is de stand van de km teller na het verhuur?: ");
            kmTellerNa = int.Parse(Console.ReadLine());
            Console.Write("Is de auto afgetankt? (Ja > type true, nee > type false): ");
            benzine = bool.Parse(Console.ReadLine());
            if (benzine == false)
            {
                Console.Write("Wat zijn de kosten van de benzine?: € ");
                prijsBenzine = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            //Aantal dagen berekenen
            if (startDatum.Month == eindDatum.Month && startDatum.Year == eindDatum.Year)
            {
                aantalDagen = eindDatum.Day - startDatum.Day;
            }
            else
            {
                aantalDagen = (30 + eindDatum.Day) - startDatum.Day;
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
            if (auto)
            {
                prijsKm = 0.20 * aantalKm;
                prijsDagen = 50 * aantalDagen;
            }
            else
            {
                prijsKm = 0.30 * aantalKm;
                prijsDagen = 95 * aantalDagen;
            }
            prijs = prijsKm + prijsDagen + prijsBenzine;

            //Weergave console
            Console.WriteLine("Kosten voor gereden km (100km/dag vrij) = € " + prijsKm.ToString());
            Console.WriteLine("Kosten voor aantal gehuurde dagen = € " + prijsDagen.ToString());
            if (benzine == false)
            {
                Console.WriteLine("Kosten voor niet afgetankte auto = € " + prijsBenzine.ToString());
            }
            Console.WriteLine("De totale kosten zijn: € " + prijs.ToString());

            Console.ReadLine();
        }
    }
}
