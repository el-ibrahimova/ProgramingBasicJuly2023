using System;

namespace _03.FinalCompetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countDancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();

            double prize = 0;

            

            if (place == "Bulgaria")
            { prize = points * countDancers;
                switch (season)
                {
                    case "summer": prize = prize - 0.05 * prize; break;
                    case "winter": prize = prize - 0.08 * prize; break;
                }
            }
            else if (place == "Abroad")
            {
                prize = (points * countDancers) + (points * countDancers) / 2;
                switch (season)
                {
                    case "summer": prize = prize - 0.10 * prize; break;
                    case "winter": prize = prize - 0.15 * prize; break;
                }
            }


            double charity = 0.75 * prize;

            double moneyPerPersons = 0.25 * prize / countDancers;

            Console.WriteLine($"Charity - {charity:f2}");
            Console.WriteLine($"Money per dancer - {moneyPerPersons:f2}");

        }
    }
}
