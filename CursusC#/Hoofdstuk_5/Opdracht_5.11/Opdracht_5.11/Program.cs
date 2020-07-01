using System;

namespace Opdracht_5._11
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaratie variabelen
            int getal, aantal = 0;

             //anker instellen
             Begin:

            //getal opvragen
            Console.Write("Voer het getal in (maximaal 100): ");
            getal = int.Parse(Console.ReadLine());

            //weergave console
            Console.WriteLine();

            //Check of het getal kleiner of gelijk aan 100 is
            if (getal <= 100)
            {
                //zet getallen onder elkaar
                for (int teller = 1; teller <= getal; teller++)
                {
                    Console.Write(teller.ToString() + ": ");
                    aantal = 0;

                    for (int deler = 1; deler <= teller; deler++)
                    {
                        if (teller % deler == 0)
                        {
                            //aantal delers in console weergeven
                            Console.Write(deler.ToString() + " ");

                            aantal++;
                        }
                    }
                      
                    //checken of het een priemgetal is en zo ja het woord priemgetal weergeven
                    if (aantal == 2)
                    {
                        Console.Write("Priemgetal");
                    }
                    
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Foutief getal!");
                Console.WriteLine();
                //verwijzing naar anker
                goto Begin;
            }

            Console.ReadLine();
        }
    }
}
