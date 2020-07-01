using System;

namespace Opdracht_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            String naam1, naam2;

            //Opvragen variabelen
            Console.WriteLine("alfabetische weergaven namen");
            Console.WriteLine();

            Console.Write("Naam 1 = ");
            naam1 = Console.ReadLine();

            Console.Write("Naam 2 = ");
            naam2 = Console.ReadLine();

            /*Weergave console
                Resultaat < 0: string1 komt voor string2
                Resultaat = 0: string1 = string2
                Resultaat > 0: string1 komt na string2*/
            Console.WriteLine();
            Console.WriteLine(String.Compare(naam1, naam2));
            Console.ReadLine();
        }
    }
}
