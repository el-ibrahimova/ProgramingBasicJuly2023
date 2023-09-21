using System;

namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegetarianMenus = int.Parse(Console.ReadLine());

            // 2. Calculate total price
            double orderPrice = chickenMenus * 10.35 + fishMenus * 12.40 + vegetarianMenus * 8.15;

            // 3. Calculate dessert price
            double dessertPrice = orderPrice * 0.2;
           
            // 4. Print output
            double totalPrice = orderPrice + dessertPrice + 2.5;
            Console.WriteLine(totalPrice);


        }
    }
}
