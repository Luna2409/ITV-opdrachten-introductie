using System;

namespace _6_Sum_square_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration variabeles
            double sumOfSquares = 0, squareOfSum = 0, difference;

            //sum of the squares
            for (double i = 1; i <= 100; i++)
            {
                sumOfSquares += Math.Pow(i, 2);
            }

            //square of the sum
            for (int j = 1; j <= 100; j++)
            {
                squareOfSum += j;
            }
            squareOfSum = Math.Pow(squareOfSum, 2);

            //difference between sum of the squares and square of the sum
            difference = squareOfSum - sumOfSquares;

            //Display in console
            Console.WriteLine(difference.ToString());

            Console.ReadLine();
        }
    }
}
