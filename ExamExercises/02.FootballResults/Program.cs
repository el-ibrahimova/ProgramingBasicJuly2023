using System;

namespace _02.FootballResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstResult = Console.ReadLine();
            string secondResult = Console.ReadLine();
            string thirdResult = Console.ReadLine();

            int wins = 0;
            int losts = 0;
            int draws = 0;

            // for first match
            int homeResults = int.Parse(firstResult[0].ToString());
            int guestResults = int.Parse(firstResult[2].ToString());

            if (homeResults > guestResults) { wins++; }
            else if (homeResults < guestResults) { losts++; }
            else if (homeResults == guestResults) { draws++; }

            // for second match
            homeResults = int.Parse(secondResult[0].ToString());
            guestResults = int.Parse(secondResult[2].ToString());

            if (homeResults > guestResults) { wins++; }
            else if (homeResults < guestResults) { losts++; }
            else if (homeResults == guestResults) { draws++; }

            // for third match
            homeResults = int.Parse(thirdResult[0].ToString());
            guestResults = int.Parse(thirdResult[2].ToString());

            if (homeResults > guestResults) { wins++; }
            else if (homeResults < guestResults) { losts++; }
            else if (homeResults == guestResults) { draws++; }

            Console.WriteLine($"Team won {wins}");
            Console.WriteLine($"Team lost {losts}");
            Console.WriteLine($"Drawn games: {draws}");

        }
    }      }
