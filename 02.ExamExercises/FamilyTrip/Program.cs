using System;

namespace FamilyTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countOvernight = int.Parse(Console.ReadLine());
            double priceOvernight = double.Parse(Console.ReadLine());
            int percentageAdditionalCosts = int.Parse(Console.ReadLine());

            if (countOvernight > 7)
                priceOvernight = priceOvernight - priceOvernight * 0.05;

            double totalOvernight = countOvernight * priceOvernight;
            double addCosts = budget * percentageAdditionalCosts * 0.01;
            double totalCosts = totalOvernight + addCosts;

            if (budget >= totalCosts)
            { Console.WriteLine($"Ivanovi will be left with {budget - totalCosts:f2} leva after vacation."); }

            else if (budget < totalCosts)
            { Console.WriteLine($"{totalCosts - budget:f2} leva needed."); }
        }
    }
}
