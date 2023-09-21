using System;

namespace _07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            double budget = double.Parse(Console.ReadLine());
            int gpuCount = int.Parse(Console.ReadLine());
            int cpuCount = int.Parse(Console.ReadLine());
            int ramCount = int.Parse(Console.ReadLine());

            // 2. Calculate total costs
            // -  first we need to calculate the gpu costs
            // - if gpu count > cpu count - 15% discount
            double gpuCosts = gpuCount * 250;

            double cpuPrice = 0.35 * gpuCosts;
            double cpuCosts = cpuPrice * cpuCount;

            double ramPrice = 0.1 * gpuCosts;
            double ramCosts = ramPrice * ramCount;

            double totalCosts = gpuCosts + cpuCosts + ramCosts;

            if (gpuCount > cpuCount)
            {
                totalCosts = totalCosts - 0.15 * totalCosts;  // 0.85 * totalCosts
            }

            // 3. Print output

            if (budget >= totalCosts)
            {
                Console.WriteLine($"You have {budget - totalCosts:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalCosts - budget:f2} leva more!");
            }
        }
    }
}
