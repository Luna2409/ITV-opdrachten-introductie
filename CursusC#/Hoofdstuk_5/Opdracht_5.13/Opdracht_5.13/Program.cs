using System;

namespace Opdracht_5._13
{
    class Program
    {
        static void Main(string[] args)
        {
            //anker 1 instellen
            Herhaal:

            //Declaratie variabelen
            Random random = new Random();
            int inzet, worp1Dobbel1, worp1Dobbel2, worp2Dobbel1, worp2Dobbel2, worp3Dobbel1, worp3Dobbel2;
            int teller = 0, winst1 = 0, winst2 = 0, winst3 = 0, totaal = 0;
            bool herhalen;

            //Uitleg
            Console.WriteLine("Je mag 3x gooien met 2 dobbelstenen.");
            Console.WriteLine("Als je bij 1 van de 3 worpen 2x een 6 gooit win je 50x je inzet.");
            Console.WriteLine("Als je bij 1 van de 3 worpen 2x hetzelfde getal gooit win je 10x je inzet.");
            Console.WriteLine("Als er in je 3 worpen 2x een 6 is gegooit win je 2x je inzet.");

            //anker 2 instellen
            Begin:

            //opvragen inzet
            Console.WriteLine();
            Console.Write("Hoeveel euro wil je inzetten (min 5, max 100): ");
            inzet = int.Parse(Console.ReadLine());

            //3 worpen met 2 dobbelstenen
            if (inzet <= 100 && inzet >= 5)
            {
                //worp 1
                Console.WriteLine();
                Console.WriteLine("Worp 1:");
                Console.Write("Dobbelsteen 1 = ");
                Console.WriteLine(worp1Dobbel1 = random.Next(1, 7));
                Console.Write("Dobbelsteen 2 = ");
                Console.WriteLine(worp1Dobbel2 = random.Next(1, 7));
                if (worp1Dobbel1 == 6 || worp1Dobbel2 == 6)
                {
                    teller++;
                }
                //worp2
                Console.WriteLine();
                Console.WriteLine("Worp 2:");
                Console.Write("Dobbelsteen 1 = ");
                Console.WriteLine(worp2Dobbel1 = random.Next(1, 7));
                Console.Write("Dobbelsteen 2 = ");
                Console.WriteLine(worp2Dobbel2 = random.Next(1, 7));
                if (worp2Dobbel1 == 6 || worp2Dobbel2 == 6)
                {
                    teller++;
                }
                //worp3
                Console.WriteLine();
                Console.WriteLine("Worp 3:");
                Console.Write("Dobbelsteen 1 = ");
                Console.WriteLine(worp3Dobbel1 = random.Next(1, 7));
                Console.Write("Dobbelsteen 2 = ");
                Console.WriteLine(worp3Dobbel2 = random.Next(1, 7));
                if (worp3Dobbel1 == 6 || worp3Dobbel2 == 6)
                {
                    teller++;
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Foutief getal!");
                goto Begin;
            }

            //winst
            if (worp1Dobbel1 == 6 && worp1Dobbel2 == 6 || worp2Dobbel1 == 6 && worp2Dobbel2 == 6 || worp3Dobbel1 == 6 && worp3Dobbel2 == 6)
            {
                //winst1
                Console.WriteLine();
                winst1 = inzet * 50;
                Console.WriteLine("Je hebt gewonnen! Je hebt bij 1 van de 3 worpen 2x een 6 gegooit.");
                Console.WriteLine("Winst = je inzet x 50 = " + winst1.ToString() + " Euro.");
                //winst2
                if (worp1Dobbel1 == worp1Dobbel2 || worp2Dobbel1 == worp2Dobbel2 || worp3Dobbel1 == worp3Dobbel2)
                {
                    Console.WriteLine();
                    winst2 = inzet * 10;
                    Console.WriteLine("Je hebt gewonnen! Je hebt bij 1 van de 3 worpen 2x hetzelfde getal gegooit.");
                    Console.WriteLine("Winst = je inzet x 10 = " + winst2.ToString() + " Euro.");
                }
                //winst3
                if (teller == 2)
                {
                    Console.WriteLine();
                    winst3 = inzet * 2;
                    Console.WriteLine("Je hebt gewonnen! Je hebt bij een van de 3 worpen 2x een 6 geworpen.");
                    Console.WriteLine("Winst = je inzet x 2 = " + winst3.ToString() + " Euro.");
                }
                //Totale winst
                Console.WriteLine();
                totaal = winst1 + winst2 + winst3;
                Console.WriteLine("Je totale winst = " + totaal.ToString() + " Euro!");
            }
            else if (worp1Dobbel1 == worp1Dobbel2 || worp2Dobbel1 == worp2Dobbel2 || worp3Dobbel1 == worp3Dobbel2)
            {
                //winst2
                Console.WriteLine();
                winst2 = inzet * 10;
                Console.WriteLine("Je hebt gewonnen! Je hebt bij 1 van de 3 worpen 2x hetzelfde getal gegooit.");
                Console.WriteLine("Winst = je inzet x 10 = " + winst2.ToString() + " Euro.");
                //winst3
                if (teller == 2)
                {
                    Console.WriteLine();
                    winst3 = inzet * 2;
                    Console.WriteLine("Je hebt gewonnen! Je hebt bij een van de 3 worpen 2x een 6 geworpen.");
                    Console.WriteLine("Winst = je inzet x 2 = " + winst3.ToString() + " Euro.");
                }
                //Totale winst
                Console.WriteLine();
                totaal = winst1 + winst2 + winst3;
                Console.WriteLine("Je totale winst = " + totaal.ToString() + " Euro!");
            }
            else if (teller == 2)
            {
                //winst3
                Console.WriteLine();
                winst3 = inzet * 2;
                Console.WriteLine("Je hebt gewonnen! Je hebt in je 3 worpen 2x een 6 geworpen.");
                Console.WriteLine("Winst = je inzet x 2 = " + winst3.ToString() + " Euro.");
                //Totale winst
                Console.WriteLine();
                totaal = winst1 + winst2 + winst3;
                Console.WriteLine("Je totale winst = " + totaal.ToString() + " Euro!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Helaas je hebt niets gewonnen.");
            }

            //herhalen van het spel
            Console.WriteLine();
            Console.Write("Wil je het spel nog een keer spelen? (True of false): ");
            herhalen = bool.Parse(Console.ReadLine());

            Console.WriteLine();
            if (herhalen)
            {
                Console.Clear();
                goto Herhaal;
            }


            Console.ReadLine();
        }
    }
}
