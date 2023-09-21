using System;
using System.Diagnostics;

namespace AddBags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceBagUnder20 = double.Parse(Console.ReadLine());
            double bagKg = double.Parse(Console.ReadLine());
            int dayTillTravel = int.Parse(Console.ReadLine());
            int bagCount = int.Parse(Console.ReadLine());

            double taxBag = 0;

            if (bagKg <= 10) { taxBag = 0.2 * priceBagUnder20; }

            else if (10 < bagKg & bagKg <= 20) { taxBag = 0.5 * priceBagUnder20; }

            else if (bagKg > 20)            { taxBag = priceBagUnder20; }

            double taxBag1 = 0;

            if (dayTillTravel > 30) { taxBag1 = 0.1 * taxBag; }
            else if (7 < dayTillTravel & dayTillTravel <= 30) { taxBag1 = 0.15 * taxBag; }
            else if (7 > dayTillTravel) { taxBag1 = 0.4 * taxBag; }
            double totalTax = taxBag + taxBag1;
           

            Console.WriteLine($"The total price of bags is:{totalTax * bagCount:f2}.");  
            





        }
    }
}
