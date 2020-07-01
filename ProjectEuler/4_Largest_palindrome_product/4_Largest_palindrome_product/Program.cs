using System;

namespace _4_Largest_palindrome_product
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            int getal = 100, teller = 100, som;
            int somR = 0, nummer, reverse = 0, nummer1 = 0, nummer2 = 0;


            //Console.Write("geef nummer: ");
            //som = int.Parse(Console.ReadLine());

             
            
            //vermenigvuldigen
            for (teller = 100; getal <= 999; teller++)
            {
                
                som = teller * getal;

                //Console.WriteLine(som.ToString());

                
                //Berekenen of het een palindroom is
                nummer = som;

                while (som > 0)
                {
                    reverse = som % 10;
                    somR = (somR * 10) + reverse;
                    som = som / 10;
                }
                if (nummer == somR)
                {
                    //Console.WriteLine(Math.Max(nummer, nummer1));
                    //nummer1 = nummer;

                    Console.WriteLine(somR.ToString() + " = " + teller.ToString() + " * " + getal.ToString());
                }

                som = 0;
                somR = 0;
                nummer = 0;
                reverse = 0;
                

                if (teller == 999)
                {
                    getal++;
                    teller = 100;
                }


            }           
        }
    }
}
