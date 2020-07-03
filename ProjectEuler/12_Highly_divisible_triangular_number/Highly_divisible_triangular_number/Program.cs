using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highly_divisible_triangular_number
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
            for (int i = 1; count <= 200; i++)
            {
                count = 0;

                number += i;

                for (int j = 1; j <= number ; j++)
                {
                    if (number % j == 0)
                    {
                        count++;
                    }
                }

            }
            
            Console.WriteLine(number.ToString());
            Console.ReadLine();

            int numberOfDivisors;
            int nod;
            int sqrt = (int) Math.Sqrt(number);
            */

            int k = 1;
            int number = 0;
            
            

            while (NumberOfDivisors(number) < 500)
            {
                number += k;
                k++;
            }
        }

        private static int NumberOfDivisors(int number)
        {
            int numberOfDivisors = 0;
            int sqrt = (int) Math.Sqrt(number);

            for (int i = 1; i <= sqrt; i++)
            {
                if (number % i == 0)
                {
                    numberOfDivisors += 2;
                }
                //Correction for perfect square
                if (sqrt *sqrt == number)
                {
                    numberOfDivisors--;
                }
                return numberOfDivisors;
            }
        }
    }
}
