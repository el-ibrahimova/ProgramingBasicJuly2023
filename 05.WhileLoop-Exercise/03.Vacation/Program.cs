using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            double requiredMoney = double.Parse(Console.ReadLine());
            double currentBalance = double.Parse(Console.ReadLine());

            // 2. Prepace while loop
            // if 5 consecutive days we spend,the loop should stop its execution
            // if we have enough money, the loop should stop its execution
            
            int consecutiveSpendOperations = 0;
            int totalDaysCount = 0;

            while (currentBalance < requiredMoney && consecutiveSpendOperations < 5)
            {
                string operationType = Console.ReadLine();
                double operationAmount = double.Parse(Console.ReadLine());

                if (operationType == "save")
                {
                    consecutiveSpendOperations = 0;
                    currentBalance += operationAmount;
                }
                else if (operationType == "spend")
                {
                    consecutiveSpendOperations++;
                    currentBalance -= operationAmount;
                  
                    if (currentBalance < 0)   { currentBalance = 0; }
                    // може да се използва и => currentBalance = Math.Max(0, currentBalance - operationAmount);
                    // Math.Max - извежда по-голямото от въведени числа => 0 или резултата от currentBalance - operationAmount
                }

                totalDaysCount++;

            }
            if (currentBalance >= requiredMoney)
            {
                Console.WriteLine($"You saved the money for {totalDaysCount} days.");
            }
            else
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(totalDaysCount);
            }

        }
    }
}
