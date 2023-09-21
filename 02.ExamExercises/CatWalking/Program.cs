using System;

namespace CatWalking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minWalkDay = int.Parse(Console.ReadLine());
            int countWalkDay = int.Parse(Console.ReadLine());
            int caloriesPerDay = int.Parse(Console.ReadLine());

            
            double totalMinPerDay = minWalkDay * countWalkDay;
            double totalCaloriesSpent = 5 * totalMinPerDay;
            double walkEnought = caloriesPerDay * 0.5;

            if(totalCaloriesSpent >= walkEnought)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough.Burned calories per day: { totalCaloriesSpent}.");  }
            else if (totalCaloriesSpent < walkEnought)
                {
                    Console.WriteLine($" No, the walk for your cat is not enough.Burned calories per day: { totalCaloriesSpent}.");  }

        }
            }
}
