using System;

namespace Opdracht_5._9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            Random random = new Random();
            int teller = 1;
            int nr1, nr2;
            int antwGebr, juist, score = 0;

            do
            {
                //maken van de sommen
                Console.WriteLine("Oefening " + teller.ToString() + ":");
                Console.Write(nr1 = random.Next(0, 11));
                Console.Write(" + ");
                Console.Write(nr2 = random.Next(0, 11));
                Console.Write(" = ");
                antwGebr = int.Parse(Console.ReadLine());
                juist = nr1 + nr2;

                //Antwoord checken
                if (antwGebr == juist)
                {
                    Console.WriteLine("Correct!");

                    teller++;
                    score++;
                }
                else
                {
                    Console.WriteLine("Fout! Het juiste antwoord was " + juist.ToString());
                    Console.Beep();

                    teller++;
                }
                Console.WriteLine();
            } while (teller != 6);

            Console.WriteLine("Je hebt de 5 oefeningen gemaakt!");
            Console.WriteLine("Jouw score = " + score.ToString());

            Console.ReadLine();
        }
    }
}
