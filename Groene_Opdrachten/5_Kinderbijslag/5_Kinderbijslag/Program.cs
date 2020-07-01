using System;

namespace _5_Kinderbijslag
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            DateTime nu = DateTime.Now;
            int aantalKinderen, groepOnderTwaalf = 0, groepTotAchttien = 0, groepBovenAchttien = 0;
            double prijsOnderTwaalf = 0, prijsTotAchttien = 0, totaalPrijs;

            //Opvragen aantal kinderen
            Console.Write("Hoeveel kinderen heeft u?: ");
            aantalKinderen = int.Parse(Console.ReadLine());

            //Arrays maken voor geboortedatums en leeftijd
            DateTime[] gebDatum = new DateTime[aantalKinderen];
            int[] leeftijd = new int[aantalKinderen];

            //Opvragen geboortedatums
            for (int i = 0; i < aantalKinderen; i++)
            {
                Console.Write("Voer de geboortedatum van kind " + (i + 1).ToString() + " in: ");
                gebDatum[i] = DateTime.Parse(Console.ReadLine());
            }

            //leeftijd berekenen kinderen
            for (int j = 0; j < aantalKinderen; j++)
            {
                leeftijd[j] = nu.Year - gebDatum[j].Year;
                if (nu.Month < gebDatum[j].Month || (nu.Month == gebDatum[j].Month && nu.Day < gebDatum[j].Day))
                {
                    leeftijd[j]--;
                }

                //Leeftijd opdelen in 3 groepen
                if (leeftijd[j] < 12)
                {
                    groepOnderTwaalf++;
                }
                else if (leeftijd[j] >= 12 && leeftijd[j] < 18)
                {
                    groepTotAchttien++;
                }
                else
                {
                    groepBovenAchttien++;
                }
            }

            //Bedrag berekenen
            prijsOnderTwaalf = groepOnderTwaalf * 150;
            prijsTotAchttien = groepTotAchttien * 235;
            totaalPrijs = prijsOnderTwaalf + prijsTotAchttien;

            aantalKinderen -= groepBovenAchttien;

            if (aantalKinderen == 3 || aantalKinderen == 4)
            {
                totaalPrijs = totaalPrijs * 1.02;
            }
            else if (aantalKinderen == 5)
            {
                totaalPrijs = totaalPrijs * 1.03;
            }
            else if (aantalKinderen >= 6)
            {
                totaalPrijs = totaalPrijs * 1.035;
            }

            //Weergave console
            Console.WriteLine();
            Console.WriteLine("Uw totale kinderbijslag per kwartaal bedraagt € " + Math.Round(totaalPrijs, 2));

            Console.ReadLine();
        }
    }
}
