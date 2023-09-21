using System;

namespace _02.EqualSumsEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1st part
            // 1. read input
            int number = int.Parse(Console.ReadLine());

            // 2. Calculate even and odd sum
            // 100023 % 10 = 3 *
            // 100023 /10 = 10002
            // 10002 % 10 = 2 *
            // 10002 / 10 = 1000
            // 1000 % 10 = 0 *
            // 1000 / 10 = 100
            // 100 % 10 = 0 *
            // 100 / 10 = 10
            // 10 % 10 = 0 *
            // 10 / 10 = 1
            // 1 % 10 = 1 *
            // 1 / 10 = 0

            int evenSum = 0, oddSum = 0;
            int position = 6;    // По условие числата са 6-цифрени

            while (number != 0)
            {
                int lastDigit = number % 10;

                if (position % 2 == 0)    {evenSum += lastDigit; }
                else                      {oddSum += lastDigit;  }
                 
                number /= 10;  // =>> number = number /10;
                position--;

            }

            // 2nd part
            // 1. Read input

            // 2. iterate the interval
            // - check if the condition is satisfied for each number

        // ==>> решението продължава в следващата задача
        }
    }
}
