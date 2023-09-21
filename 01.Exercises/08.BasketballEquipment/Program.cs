using System;

namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            int tax = int.Parse(Console.ReadLine());

            // 2. Calculate shoes price
            double shoesPrice = tax - 0.4 * tax; // (1 - 0.4) * tax = 0.6 * tax

            // 3. Calculate kit price
            double kitPrice = shoesPrice - 0.2 * shoesPrice; // 0.8 * shoesPrice

            // 4. Calculate ball price
            double ballPrice = (1 / 4.0) * kitPrice; // 0.25 * kitPrice (1.0/4) * kitPrice
             
            // 5. Calculate accessories price
            double accessoriesPrice = (1 / 5.0) * ballPrice; // (1.0/5) * ballPrice // 0.2 * ballPrice

            // 6. Calculate total price
            double totalPrice = tax + shoesPrice + kitPrice + ballPrice + accessoriesPrice;

            // 7. Print output
            Console.WriteLine(totalPrice);
        }
    }
}
