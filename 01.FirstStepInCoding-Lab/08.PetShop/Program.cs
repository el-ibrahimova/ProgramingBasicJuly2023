using System;

namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int packDog = int.Parse(Console.ReadLine());
            int packCat = int.Parse(Console.ReadLine());
            double amount = (packCat * 4) + (packDog * 2.50);
            Console.WriteLine($"{amount} lv.");
        }
    }
}
