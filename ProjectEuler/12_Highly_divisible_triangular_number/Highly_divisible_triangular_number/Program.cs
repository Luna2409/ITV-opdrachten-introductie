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
            int count = 0;
            int number = 0;

            for (int i = 1; count <= 500; i++)
            {
                count = 0;
                int j = 1;

                number = number + i;

                for (j = 1; j <= number ; j++)
                {
                    if (number % j == 0)
                    {
                        count++;
                    }
                }

            }

            Console.WriteLine(number.ToString());
            Console.ReadLine();
        }
    }
}
