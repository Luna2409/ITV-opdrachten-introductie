using System;

namespace _9_Waterverbruik
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            int tarief, verbruik;
            const int vastrecht1 = 100, vastrecht2 = 75;
            const double verbruikkosten1 = 0.25, verbruikkosten2 = 0.38;
            double totaal = 0, totaal1 = 0, totaal2 = 0;

            //Opvragen variabelen
            Console.Write("Welk tarief heeft u?(0, 1, 2): ");
            tarief = int.Parse(Console.ReadLine());
            Console.Write("Wat is uw waterverbruik in m3 van afgelopen jaar?: ");
            verbruik = int.Parse(Console.ReadLine());

        //Anker instellen
        Tarief:

            //Berekenen kosten
            switch (tarief)
            {
                case 1:
                    totaal = vastrecht1 + verbruik * verbruikkosten1;
                    Console.WriteLine();
                    //weergave console
                    Console.WriteLine("Uw totaal verbruik van het afgelopen jaar met tarief 1 is:");
                    Console.WriteLine(vastrecht1.ToString() + " + " + verbruik.ToString() + " * " +
                        verbruikkosten1.ToString() + " = " + Math.Round(totaal, 2).ToString());
                    break;
                case 2:
                    totaal = vastrecht2 + verbruik * verbruikkosten2;
                    Console.WriteLine();
                    //weergave console
                    Console.WriteLine("Uw totaal verbruik van het afgelopen jaar met tarief 2 is:");
                    Console.WriteLine(vastrecht2.ToString() + " + " + verbruik.ToString() + " * " +
                        verbruikkosten2.ToString() + " = " + Math.Round(totaal, 2).ToString());
                    break;
                case 0:
                    totaal1 = vastrecht1 + verbruik * verbruikkosten1;
                    totaal2 = vastrecht2 + verbruik * verbruikkosten2;
                    Console.WriteLine();
                    //weergave console
                    if (totaal1 < totaal2)
                    {
                        Console.WriteLine("Uw totaal verbruik van het afgelopen jaar met het voordeligste tarief (tarief 1) is:");
                        Console.WriteLine(vastrecht1.ToString() + " + " + verbruik.ToString() + " * " +
                            verbruikkosten1.ToString() + " = " + Math.Round(totaal1, 2).ToString());
                    }
                    else
                    {
                        Console.WriteLine("Uw totaal verbruik van het afgelopen jaar met het voordeligste tarief (tarief 2) is:");
                        Console.WriteLine(vastrecht2.ToString() + " + " + verbruik.ToString() + " * " +
                            verbruikkosten2.ToString() + " = " + Math.Round(totaal2, 2).ToString());
                    }
                    break;
                default:
                    Console.Write("Er is iets fout gegaan bij het invullen van uw tarief. Typ 0, 1 of 2: ");
                    tarief = int.Parse(Console.ReadLine());
                    goto Tarief;
            }
            


            Console.ReadLine();
        }
    }
}
