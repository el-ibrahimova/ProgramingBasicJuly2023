using System;

namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            // 2. Find destination
            string destination;
            string holidayType = "";
            double expenses = 0;

            if (budget <= 100)  // Bulgaria
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    expenses = 0.3 * budget;
                    holidayType = "Camp";
                }
                else if (season == "winter")
                {
                    expenses = 0.7 * budget;
                    holidayType = "Hotel";
                }

            }
            else if (budget <= 1000) // Balkans
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    expenses = 0.4 * budget;
                    holidayType = "Camp";
                }
                else if (season == "winter")
                {
                    expenses = 0.8 * budget;
                    holidayType = "Hotel";
                }

            }
            else  // Europe
            {
                destination = "Europe";
                holidayType = "Hotel";
                expenses = 0.9 * budget;
            }
            // 3. Find camp/ hotel
            // 4. Calculate expenses

            // 5. Print output
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{holidayType} - {expenses:f2}");
        }
    }
}
