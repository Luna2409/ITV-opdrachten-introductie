using System;

namespace Opdracht_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            int leeftijd;

            //Opvragen variabelen
            Console.Write("Hoe oud ben je?: ");
            leeftijd = int.Parse(Console.ReadLine());

            //Weergave console
            Console.WriteLine();
            if (leeftijd >= 18)
            {
                Console.WriteLine("Je bent " + leeftijd + " jaar oud. " +
                    "Je mag deelnemen aan de spelen van de Nationale Loterij.");
            }
            else
            {
                Console.WriteLine("Om deel te nemen aan de spelen van de Nationale Loterij " +
                    "moet je minimum 18 jaar oud zijn.");
            }
            Console.ReadLine();
        }
    }
}
