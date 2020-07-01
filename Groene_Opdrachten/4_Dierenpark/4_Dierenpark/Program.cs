using System;

namespace _4_Dierenpark
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            DateTime nu = DateTime.Now;
            DateTime gebDatum1, gebDatum2;
            int leeftijd1, leeftijd2, onderVijfenzestig = 0, bovenVijfenzestig = 0;
            int aantalKinderen = 0, prijs = 0;
            string partner;

            //Titel
            Console.WriteLine("Abonnementskiezer Dierenpark");
            Console.WriteLine();

            //Opvragen geboortedatum
            Console.Write("Voer u geboortedatum in: ");
            gebDatum1 = DateTime.Parse(Console.ReadLine());

            leeftijd1 = nu.Year - gebDatum1.Year;
            if (nu.Month < gebDatum1.Month || (nu.Month == gebDatum1.Month && nu.Day < gebDatum1.Day))
            {
                leeftijd1--;
            }

            if (leeftijd1 < 65)
            {
                onderVijfenzestig++;
            }
            else
            {
                bovenVijfenzestig++;
            }

            //partner? zo ja geboortedatum partner + leeftijd bepalen
            Console.Write("Heeft u een partner en wilt hij/zij ook een abonnement?(typ ja of nee): ");
            partner = Console.ReadLine();

            switch (partner)
            {
                case "ja":
                    Console.Write("Voer geboortedatum partner in: ");
                    gebDatum2 = DateTime.Parse(Console.ReadLine());

                    leeftijd2 = nu.Year - gebDatum2.Year;
                    if (nu.Month < gebDatum2.Month || (nu.Month == gebDatum2.Month && nu.Day < gebDatum2.Day))
                    {
                        leeftijd2--;
                    }

                    if (leeftijd2 < 65)
                    {
                        onderVijfenzestig++;
                    }
                    else
                    {
                        bovenVijfenzestig++;
                    }
                    break;

                case "nee":
                    break;
            }

            //Opvragen aantal kinderen
            Console.Write("Hoeveel kinderen onder de 18 jaar heeft u?(typ aantal of 0): ");
            aantalKinderen = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Totale prijs berekenen
            //echtpaar zonder kinderen
            if (onderVijfenzestig == 2 && bovenVijfenzestig == 0 && aantalKinderen == 0)
            {
                prijs = 61;
                Console.WriteLine("U krijgt een Echtpaar abonnement dit kost € " + prijs.ToString());
            }
            //echtpaar 65+ zonder kinderen
            if (onderVijfenzestig == 0 && bovenVijfenzestig == 2 && aantalKinderen == 0)
            {
                prijs = 65;
                Console.WriteLine("U krijgt een Echtpaar 65+ abonnement dit kost € " + prijs.ToString());
            }
            //1 persoon onder 65 en 1 persoon boven 65 zonder kinderen
            if (onderVijfenzestig == 1 && bovenVijfenzestig == 1 && aantalKinderen == 0)
            {
                prijs = 30 + 26;
                Console.WriteLine("U krijgt een Persoonlijk en een Persoonlijk 65+ abonnement dit kost € " + prijs.ToString());
            }
            //1 persoon onder 65 zonder kinderen
            if (onderVijfenzestig == 1 && bovenVijfenzestig == 0 && aantalKinderen == 0)
            {
                prijs = 30;
                Console.WriteLine("U krijgt een Persoonlijk abonnement dit kost € " + prijs.ToString());
            }
            //1 persoon boven 65 zonder kinderen
            if (onderVijfenzestig == 0 && bovenVijfenzestig == 1 && aantalKinderen == 0)
            {
                prijs = 26;
                Console.WriteLine("U krijgt een Persoonlijk 65+ abonnement dit kost € " + prijs.ToString());
            }
            //echtpaar onder 65 met 1 kind
            if (onderVijfenzestig == 2 && bovenVijfenzestig == 0 && aantalKinderen == 1)
            {
                prijs = 71;
                Console.WriteLine("U krijgt een Gezin met 1 kind abonnement dit kost € " + prijs.ToString());
            }
            //echtpaar onder 65 met meer dan 1 kind
            if (onderVijfenzestig == 2 && bovenVijfenzestig == 0 && aantalKinderen > 1)
            {
                prijs = 60 + (aantalKinderen * 11);
                Console.WriteLine("U krijgt een Gezin met " + aantalKinderen.ToString() +
                    " kinderen abonnement dit kost € " + prijs.ToString());
            }
            //echtpaar boven 65 met 1 of meer kinderen
            if (onderVijfenzestig == 0 && bovenVijfenzestig == 2 && aantalKinderen >= 1)
            {
                prijs = 65 + (aantalKinderen * 11);
                Console.WriteLine("U krijgt een Echtpaar 65+ abonnement met " + aantalKinderen.ToString() +
                    " kind(eren) dit kost € " + prijs.ToString());
            }
            //1 persoon onder 65, 1 persoon boven 65 met 1 of meer kinderen
            if (onderVijfenzestig == 1 && bovenVijfenzestig == 1 && aantalKinderen >= 1)
            {
                prijs = 30 + 26 + (aantalKinderen * 11);
                Console.WriteLine("U krijgt een persoonlijk, persoonlijk 65+ abonnenent met " + aantalKinderen.ToString() +
                    " kind(eren) dit kost € " + prijs.ToString());
            }
            //1 persoon onder 65 met 1 of meer kinderen
            if (onderVijfenzestig == 1 && bovenVijfenzestig == 0 && aantalKinderen >= 1)
            {
                prijs = 30 + (aantalKinderen * 11);
                Console.WriteLine("U krijgt een persoonlijk abonnement met " + aantalKinderen.ToString() +
                    " kind(eren) dit kost € " + prijs.ToString());
            }
            //1 persoon boven 65 met 1 of meer kinderen
            if (onderVijfenzestig == 0 && bovenVijfenzestig == 1 && aantalKinderen >= 1)
            {
                prijs = 26 + (aantalKinderen * 11);
                Console.WriteLine("U krijgt een persoonlijk abonnement met " + aantalKinderen.ToString() +
                    " kind(eren) dit kost € " + prijs.ToString());
            }



            Console.ReadLine();

            /*
            //Declaratie variabelen
            DateTime nu = DateTime.Now;
            string abonnement;
            int totaalPrijs, aantalExtraKinderen, aantalVolwassenen = 2;
            
            //Opties abonnementen dierenpark
            Console.WriteLine("A. Echtpaar");
            Console.WriteLine("B. Gezin met 1 kind (t/m 18 jaar)");
            Console.WriteLine("C. Gezin met 2 kinderen (of meer)(t/m 18 jaar)");
            Console.WriteLine("D. Persoonlijk");
            Console.WriteLine("E. Echtpaar 65+");
            Console.WriteLine("F. Persoonlijk 65+");

            //Opvragen variabelen
            Console.Write("Welk abonnement wilt u afsluiten? typ letter: ");
            abonnement = Console.ReadLine();
            Console.WriteLine();

            //aantal personen voor abonnement bepalen
            if (abonnement == "C")
            {
                Console.Write("Heeft u meer dan twee kinderen (zo ja typ hoeveel meer dan 2, zo nee typ 0)?: ");
                aantalExtraKinderen = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            if (abonnement == "D")
            {
                aantalVolwassenen--;
            }
            if (abonnement == "F")
            {
                aantalVolwassenen--;
            }

            //Arrays maken voor geboortedatums en namen en jaar
            string[] namen = new string[aantalVolwassenen];
            DateTime[] gebDatum = new DateTime[aantalVolwassenen];
            int[] leeftijd = new int[aantalVolwassenen];

            //namen en geboortedatums opvragen
            for (int i = 0; i < aantalVolwassenen; i++)
            {
                Console.Write("Voer de naam van persoon " + (i + 1).ToString() + " in: ");
                namen[i] = Console.ReadLine();
                Console.Write("Voer de geboortedatum van persoon " + (i + 1).ToString() + " in: ");
                gebDatum[i] = DateTime.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            //leeftijden berekenen
            for (int j = 0; j < aantalVolwassenen; j++)
            {
                leeftijd[j] = nu.Year - gebDatum[j].Year;
                if (nu.Month < gebDatum[j].Month || (nu.Month == gebDatum[j].Month && nu.Day < gebDatum[j].Day))
                {
                    leeftijd[j]--;
                }
            }

            //Prijs berekenen
            switch (abonnement)
            {
                case "A":
                    
                    break;
                case "B":

                    break;
                case "C":
                    

                    break;
                case "D":

                    break;
                case "E":

                    break;
                case "F":

                    break;
                default:
                    break;
            }
            */
        }
    }
}
