using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;



namespace _13_Schijventarief_Inkomstenbelasting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            double belastbaarInkomen, belastbareSom = 0, inkomstenbelasting = 0;
            int tariefgroep;

            //Opvragen variabelen
            Console.Write("Wat is uw belastbaar inkomen?: ");
            belastbaarInkomen = double.Parse(Console.ReadLine());
            Console.Write("Wat is uw tarifgroep?(1/2/3/4/5): ");
            tariefgroep = int.Parse(Console.ReadLine());

            //Anker instellen
            Tarief:

            //Belasbare som berekenen
            switch (tariefgroep)
            {
                case 1:
                    belastbareSom = belastbaarInkomen - 419;
                    break;
                case 2:
                    belastbareSom = belastbaarInkomen - 8799;
                    break;
                case 3:
                    belastbareSom = belastbaarInkomen - 17179;
                    break;
                case 4:
                    belastbareSom = belastbaarInkomen - 15503;
                    break;
                case 5:
                    belastbareSom = belastbaarInkomen - 15503;
                    break;
                default:
                    Console.Write("ERROR. Er is iets fout gegaan bij het invullen van uw tariefgoep. " +
                        "Vul 1, 2, 3, 4 of 5 in: ");
                    tariefgroep = int.Parse(Console.ReadLine());
                    goto Tarief;
            }

            //Inkomstenbelasting berekenen
            if (belastbareSom <= 8000)
            {
                inkomstenbelasting = belastbareSom / 100 * 35.75;
            }
            else if (belastbareSom <= 25000)
            {
                inkomstenbelasting = 8000 / 100 * 35.75;
                inkomstenbelasting += ((belastbareSom - 8000) / 100 * 37.05);
            }
            else if (belastbareSom <= 25000)
            {
                inkomstenbelasting = 8000 / 100 * 35.75;
                inkomstenbelasting += (17000 / 100 * 37.05);
                inkomstenbelasting += ((belastbareSom - 25000) / 100 * 50);
            }
            else
            {
                inkomstenbelasting = 8000 / 100 * 35.75;
                inkomstenbelasting += (17000 / 100 * 37.05);
                inkomstenbelasting += (29000 / 100 * 50);
                inkomstenbelasting += ((belastbareSom - 54000) / 100 * 60);
            }

            //Weergave in console
            Console.WriteLine();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("nl-NL");
            Console.WriteLine("Uw inkomstenbelasting = " + Math.Round(inkomstenbelasting, 2).ToString("C"));



            Console.ReadLine();
        }
    }
}
