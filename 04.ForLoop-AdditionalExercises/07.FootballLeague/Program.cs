using System;

namespace _07.FootballLeague
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int countOfFans = int.Parse(Console.ReadLine());
            
            string sector;
            int firstTeamA = 0, firstTeamB = 0;
            int secondTeamV = 0, secondTeamG = 0;

            for (int i = 1; i <= countOfFans; i++)
            {
                sector = Console.ReadLine();

                switch (sector)
                {
                    case "A": firstTeamA++; break;
                    case "B": firstTeamB++; break;
                    case "V": secondTeamV++; break;
                    case "G": secondTeamG++; break;
                }
                if (countOfFans > stadiumCapacity)
                { break; }
            } 

                double firsTeamAPercentage = 100.0 * firstTeamA / countOfFans;
                double firsTeamBPercentage = 100.0 * firstTeamB/ countOfFans;
                double secondTeamVPercentage = 100.0 * secondTeamV/ countOfFans;
                double secondTeamGPercentage = 100.0 * secondTeamG / countOfFans;
                double teamFansPercentage = 100.0 * (firstTeamA + firstTeamB + secondTeamV + secondTeamG) / stadiumCapacity;

            Console.WriteLine($"{firsTeamAPercentage:f2}%");
            Console.WriteLine($"{firsTeamBPercentage:f2}%");
            Console.WriteLine($"{secondTeamVPercentage:f2}%");
            Console.WriteLine($"{secondTeamGPercentage:f2}%");
            Console.WriteLine($"{teamFansPercentage:f2}%");
        }
    }
}
