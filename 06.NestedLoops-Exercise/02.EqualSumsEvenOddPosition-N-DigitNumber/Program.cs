using System;

namespace _02.EqualSumsEvenOddPosition_N_DigitNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            // 2. iterate the interval
            // - check if the condition is satisfied for each number

            for (int i = start; i <= end; i++)
            {

                int number = i;
                int evenSum = 0, oddSum = 0;
                bool isEvenPosition = true;    // за n-цифрени числа

                while (number != 0)
                {
                    int lastDigit = number % 10;

                    if (isEvenPosition) { evenSum += lastDigit; }
                    else { oddSum += lastDigit; }

                    number /= 10;  // =>> number = number /10;
                    isEvenPosition = !isEvenPosition;  // = обратното на isEvenPosition

                }

                if (evenSum == oddSum)
                {
                    Console.Write($"{i} ");
                }
            }  
        }
    }
}
