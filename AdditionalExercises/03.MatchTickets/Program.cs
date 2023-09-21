using System;
using System.ComponentModel;

namespace _03.MatchTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int countOfPeople = int.Parse(Console.ReadLine());

            if (countOfPeople >= 1 && countOfPeople <= 4)
            {
                budget = budget - 0.75 * budget;
            }
            else if (countOfPeople >= 5 && countOfPeople <= 9)
            {
                budget = budget - 0.6 * budget;
            }
            else if (countOfPeople >= 10 && countOfPeople <= 24)
            {
                budget = budget - 0.5 * budget;
            }
            else if (countOfPeople >= 25 && countOfPeople <= 49)
            {
                budget = budget - 0.4 * budget;
            }
            else if (countOfPeople >= 50)
            {
                budget = budget - 0.25 * budget;
            }

            double priceForTickets = 0;
            
            switch (category)
            {
                case "VIP": priceForTickets = countOfPeople * 499.99; break;
                case "Normal": priceForTickets = countOfPeople * 249.99; break;
            }

            if (budget >= priceForTickets)
            { Console.WriteLine($"Yes! You have {budget - priceForTickets:f2} leva left."); }
            else
            { Console.WriteLine($"Not enough money! You need {priceForTickets - budget:f2} leva."); }


        }
    }
}
