using System;

namespace _9_Special_Pythagorean_triplet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie variabelen
            int a, b, c, y;


            for (a = 1; a < 335; a++)
            {
                for (b = a + 1; b < 500; b++)
                {
                    for (c = b + 1; c < 997; c++)
                    {
                        if ((a + b + c) == 1000)
                        {
                            if ((Math.Pow(a, 2) + Math.Pow(b, 2)) == Math.Pow(c, 2))
                            {
                                y = a * b * c;
                                Console.WriteLine(a + " * " + b + " * " + c + " = " + y);
                            }
                        }
                    }
                }
            }




            Console.ReadLine();
        }
    }
}
