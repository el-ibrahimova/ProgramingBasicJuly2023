using System;

namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermenCount = int.Parse(Console.ReadLine());

            // 2 Find rent price
            double costs = 0;
            if (season == "Spring") { costs = 3000; }
            else if (season == "Summer" || season == "Autumn") { costs = 4200; }
            else if (season == "Winter") { costs = 2600; }

            // 3. Apply discount 
            if (fishermenCount <= 6)
            {
                costs = costs - 0.1 * costs; // 0.9 * costs;
            }
            else if (fishermenCount > 7 && fishermenCount <= 11)
            {
                costs = costs - 0.15 * costs; // 0.85 * costs;
            }
            else if (fishermenCount > 12)
            {
                costs = costs - 0.25 * costs; // 0.75 * costs;
            }

            // 4. Apply addiotional discount
            if (fishermenCount % 2 == 0 && season != "Autumn")
            {
                costs = costs - 0.05 * costs; // 0.95 * costs;
            }

            // 5. Print output

            if (budget >= costs)
            {
                Console.WriteLine($"Yes! You have {budget - costs:f2} leva left.");
            }
            else if (budget < costs)
            {
                Console.WriteLine($"Not enough money! You need {costs - budget:f2} leva.");
            }

        }
    }
}
