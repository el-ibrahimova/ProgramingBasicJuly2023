using System;

namespace _03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Read input
            string flowerType = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            // "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"

            // 2. Find price for a single flower
            double price = 0;
            if (flowerType == "Roses") { price = 5; }
            else if (flowerType == "Dahlias") { price = 3.80; }
            else if (flowerType == "Tulips") { price = 2.80; }
            else if (flowerType == "Narcissus") { price = 3; }
            else if (flowerType == "Gladiolus") { price = 2.50; }

            double totalCost = flowersCount * price;

            // 3. Calculate discount
            if (flowerType == "Roses" && flowersCount > 80)
            { totalCost = totalCost - 0.1 * totalCost; }    // 0.9 * totalCost
                                                            
            else if ((flowerType == "Dahlias" && flowersCount > 90)  // dublirane na koda za dalii i laleta = moje da se zapishe zaedno
                || (flowerType == "Tulips" && flowersCount > 80))
            { totalCost = totalCost - 0.15 * totalCost; }   // 0.85 * totalCost

         else if (flowerType == "Narcissus" && flowersCount < 120)
            { totalCost = totalCost + 0.15 * totalCost; } // 1.15 * totalCost

            else if (flowerType == "Gladiolus" && flowersCount < 80)
            { totalCost = totalCost + 0.20 * totalCost; }  // 1.2 * totalCost

            // 4. Print output
            if (budget >= totalCost)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowerType} " +
                $"and {budget - totalCost:f2} leva left.");
            }

            else if (budget < totalCost)
            {
                Console.WriteLine($"Not enough money, you need {totalCost - budget:f2} leva more.");
            }

        }
    }
}
