using System;

namespace Hoofdstuk_4.vb._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            int aantal;

            //Opvragen variabelen
            Console.Write("Met hoeveel zijn jullie?: ");
            aantal = int.Parse(Console.ReadLine());

            //Weergave console
            Console.WriteLine();
            switch (aantal)
            {
                case 1:
                case 2:
                    Console.WriteLine("Helaas je krijgt geen korting.");
                    break;

                case 3:
                    Console.WriteLine("Jullie krijgen 10% korting.");
                    break;

                case 4:
                    Console.WriteLine("Jullie krijgen 20% korting.");
                    break;

                case 5:
                    Console.WriteLine("Jullie krijgen 50% korting.");
                    break;

                default:
                    Console.WriteLine("Jullie mogen gratis naar binnen!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
