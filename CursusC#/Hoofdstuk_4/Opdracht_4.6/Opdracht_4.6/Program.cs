using System;

namespace Opdracht_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            string taal;

            //Opvragen taal
            Console.WriteLine("Kies de gewenste taal.");
            Console.Write("Nederlands (NL), Engels (EN), Frans (FR) of Duits (DU): ");
            taal = Console.ReadLine();
            Console.WriteLine();

            //Weergave console
            switch (taal)
            {
                case "NL":
                    Console.WriteLine("Tot ziens.");
                    break;

                case "EN":
                    Console.WriteLine("Goodbye.");
                    break;

                case "FR":
                    Console.WriteLine("Au revoir.");
                    break;

                case "DU":
                    Console.WriteLine("Auf Wiedersehen.");
                    break;

                default:
                    Console.WriteLine("Foute keuze.");
                    break;
            }
        }
    }
}
