using System;

namespace _09.LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstSum = 0;
            int secondSum = 0;

            for (int i = 0; i < n; i++)
            {
                firstSum += int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                secondSum += currentNumber;
            }

            if (firstSum == secondSum)
            {
                Console.WriteLine($"Yes, sum = {firstSum}");
            }
            else 
            {
                int diff = Math.Abs(firstSum - secondSum);
                Console.WriteLine($"No, diff = {diff}");
            }

        }
    }
}
