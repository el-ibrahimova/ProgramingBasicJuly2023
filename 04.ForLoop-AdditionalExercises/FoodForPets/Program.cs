using System;

namespace FoodForPets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double totalFood = double.Parse(Console.ReadLine());
            double totalBiscuit = 0;
            double totalFoodEaten = 0;
            double totalFoodDog = 0;
            double totalFoodCat = 0;

            for (int i = 1; i <= days; i++)
            {
                int dogFoodPerDay = int.Parse(Console.ReadLine());
                int catFoodPerDay = int.Parse(Console.ReadLine());
                double dogBiscuit = 0;
                double catBiscuit = 0;

                if (i % 10 == 3)
                { dogBiscuit = 0.1 * dogFoodPerDay; 
                  catBiscuit = 0.1 * catFoodPerDay; 
                }
                
                totalFoodDog += dogFoodPerDay;
                totalFoodCat += catFoodPerDay;
                totalBiscuit = catBiscuit + dogBiscuit;
                totalFoodEaten = totalFoodDog + totalFoodCat;
            }

            Console.WriteLine($"Total eaten biscuits: {Math.Round(totalBiscuit)}gr." );
            Console.WriteLine($"{100.0 * totalFoodEaten/ totalFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{100.0 * totalFoodDog/totalFoodEaten:f2}% eaten from the dog.");
            Console.WriteLine($"{100.0 * totalFoodCat / totalFoodEaten:f2}% eaten from the cat.");
        } 
    }
}
