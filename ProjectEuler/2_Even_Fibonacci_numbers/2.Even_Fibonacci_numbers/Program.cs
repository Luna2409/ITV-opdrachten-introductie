using System;

namespace _2.Even_Fibonacci_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie 
            int num1 = 0, num2 = 1, num3, som = 0;
            const int max = 4000000;

            //Fibonacci reeks
            for (int teller = 0; num2 < max; teller++)
            {
                num3 = num1 + num2;
                //checken of het nummer even is
                if (num3 % 2 == 0 && num3 < max)
                {
                    som += num3;
                }
                //Console.Write(num3 + " ");

                num1 = num2;
                num2 = num3;
            }
            Console.WriteLine("De som van alle even Fibonacci nummers onder de 4.000.000 = " + som.ToString());

            Console.ReadLine();
        }
    }
}
