using System;

namespace _05.GodzillaVs.Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            double budget = double.Parse(Console.ReadLine());   
            int statistsCount = int.Parse(Console.ReadLine());
            double clothingPricePerStatist = double.Parse(Console.ReadLine());

            // 2. Calculate costs
            // - decor costs 10% of total budget
            // - if > 150 statists, we can apply 10% discount for clothing
            double decorCosts = budget * 0.1;
            double clothingCosts = statistsCount * clothingPricePerStatist;
            if (statistsCount > 150)
            {
                clothingCosts = clothingCosts - 0.1 * clothingCosts; // 0.9 * clothingCosts
            }
            double totalCosts = decorCosts + clothingCosts;

            // 3. Print output
            if (budget >= totalCosts)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalCosts:f2} leva left.");
            }
            else if (budget < totalCosts)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalCosts - budget:f2} leva more.");
            }



        }
    }
}
