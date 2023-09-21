using System;

namespace _03.TirDriver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());

            double pricePerKm = 0;

            if (season == "Spring" || season == "Autumn")
            {
                if (kmPerMonth <= 5000) { pricePerKm = 0.75; }
                else if (kmPerMonth > 5000 && kmPerMonth <= 10000) { pricePerKm = 0.95; }
                else if (kmPerMonth > 1000 && kmPerMonth <= 20000) { pricePerKm = 1.45; }
            }

            if (season == "Summer")
            {
                if (kmPerMonth <= 5000) { pricePerKm = 0.9; }
                else if (kmPerMonth > 5000 && kmPerMonth <= 10000) { pricePerKm = 1.1; }
                else if (kmPerMonth > 1000 && kmPerMonth <= 20000) { pricePerKm = 1.45; }
            }

            if (season == "Winter")
            {
                if (kmPerMonth <= 5000) { pricePerKm = 1.05; }
                else if (kmPerMonth > 5000 && kmPerMonth <= 10000) { pricePerKm = 1.25; }
                else if (kmPerMonth > 1000 && kmPerMonth <= 20000) { pricePerKm = 1.45; }
            }

            double totalPricePerMonth = kmPerMonth * pricePerKm;
            double totalPricePerSeason = totalPricePerMonth * 4;
            double tax = totalPricePerSeason * 0.1;

            Console.WriteLine($"{totalPricePerSeason - tax:f2}"); 
        }
    }
}
