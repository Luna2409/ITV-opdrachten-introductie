using System;

namespace Opdracht_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabele
            DateTime datum;

            //Titel
            Console.WriteLine("Welk kwartaal hoort bij de ingevoerde datum");
            Console.WriteLine();

            //Opvragen datum
            Console.Write("Voer een datum in: ");
            datum = DateTime.Parse(Console.ReadLine());

            //Weergave Console
            Console.WriteLine();
            switch (datum.Month)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("De opgegeven datum " + datum.ToShortDateString() +
                        " valt in kwartaal 1.");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("De opgegeven datum " + datum.ToShortDateString() +
                        " valt in kwartaal 2.");
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("De opgegeven datum " + datum.ToShortDateString() +
                        " valt in kwartaal 3.");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("De opgegeven datum " + datum.ToShortDateString() +
                        " valt in kwartaal 4.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
