using System;

namespace _2_Ouderbijdrage_school
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            DateTime nu = DateTime.Now;
            int aantalKinderen, basisbijdrage = 50, bijdrageOnder10 = 0;
            int aantalKinderenOnder10 = 0, aantalKinderenBoven10 = 0, bijdragenBoven10 = 0;
            double ouderbijdrage = 0;
            Boolean eenoudergezin;

            //Opvragen variabelen
            Console.Write("Hoeveel kinderen heeft u op onze school zitten?: ");
            aantalKinderen = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Array maken voor de geboorte datums en voor het jaar
            DateTime[] gebDatum = new DateTime[aantalKinderen];
            int[] jaar = new int[aantalKinderen];

            //Geboorte datum(s) opvragen en in array zetten
            for (int i = 0; i < aantalKinderen; i++)
            {
                Console.Write("Voer geboortedatum van kind " + (i+1).ToString() + " in: ");
                gebDatum[i] = DateTime.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            //Opvragen of het een eenoudergezin is
            Console.Write("Bent u een eenoudergezin? (Type true of false): ");
            eenoudergezin = bool.Parse(Console.ReadLine());

            //De leeftijden van de kinderen berekenen
            for (int j = 0; j < aantalKinderen; j++)
            {
                jaar[j] = nu.Year - gebDatum[j].Year;
                if (nu.Month < gebDatum[j].Month || (nu.Month == gebDatum[j].Month && nu.Day < gebDatum[j].Day))
                {
                    jaar[j]--;
                }
            }

            //ouderbijdrage berekenen
            ouderbijdrage += basisbijdrage;
            //bijdrage voor kinderen jonger dan 10
            for (int k = 0; k < aantalKinderen; k++)
            {
                if (jaar[k] < 10)
                {
                    aantalKinderenOnder10++;
                }
                if (aantalKinderenOnder10 >= 3)
                {
                    bijdrageOnder10 = 3 * 25;
                }
                else
                {
                    bijdrageOnder10 = aantalKinderenOnder10 * 25;
                }
                ouderbijdrage += bijdrageOnder10;
            }

            //Bijdrage voor kinderen van 10 en ouder
            for (int l = 0; l < aantalKinderen; l++)
            {
                if (jaar[l] >= 10)
                {
                    aantalKinderenBoven10++;
                }
                if (aantalKinderenBoven10 >= 2)
                {
                    bijdragenBoven10 = 2 * 37;
                }
                else
                {
                    bijdragenBoven10 = aantalKinderenBoven10 * 37;
                }
                ouderbijdrage += bijdragenBoven10;
            }

            //Maximale ouderbijdrage?
            if (ouderbijdrage > 150)
            {
                ouderbijdrage = 150;
            }
            //Reductie voor eenoudergezin
            if (eenoudergezin)
            {
                ouderbijdrage *= 0.75;
            }

            Console.WriteLine();
            Console.WriteLine("De ouderbijdrage = €" + Math.Round(ouderbijdrage, 2).ToString());


            Console.ReadLine();
        }
    }
}
