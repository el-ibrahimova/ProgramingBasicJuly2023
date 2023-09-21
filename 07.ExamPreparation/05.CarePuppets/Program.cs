using System;

namespace _05.CarePuppets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            int foodInGrams = food * 1000;

            string input = Console.ReadLine();

            while (input != "Adopted")
            {
                int foodPerDay = int.Parse(input);
                foodInGrams-= foodPerDay;

                input = Console.ReadLine();

            }
           
            if (foodInGrams >= 0)
            {
                Console.WriteLine($"Food is enough! Leftovers {foodInGrams} grams.");
            }
            else 
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(foodInGrams)} grams more.");
            }


        }
    }
}
