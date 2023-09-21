using System;

namespace _06.BasketballTournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfTournament = Console.ReadLine();

            int counterWin = 0;
            int counterLost = 0;
           
            int n = 0;

            while (nameOfTournament != "End of tournaments")
            {
                n = int.Parse(Console.ReadLine());

                for (int gameNumber  = 1; gameNumber <= n; gameNumber++)
                {
                    int pointsDesiTeam = int.Parse(Console.ReadLine());
                    int otherTeamPoints = int.Parse(Console.ReadLine());

                    int difference = 0;
                    
                    if (pointsDesiTeam > otherTeamPoints)
                    {
                        counterWin++;
                        difference = pointsDesiTeam - otherTeamPoints;
                        Console.WriteLine($"Game {gameNumber} of tournament {nameOfTournament}: win with {difference} points.");
  
                    }
                    else if (pointsDesiTeam < otherTeamPoints)
                    {
                        counterLost++;
                        difference = otherTeamPoints - pointsDesiTeam;
                        Console.WriteLine($"Game {gameNumber} of tournament {nameOfTournament}: lost with {difference} points.");
                    }

                }

                nameOfTournament = Console.ReadLine();

            }

            double percentageWin = 100.0* counterWin / (counterWin+counterLost);
            double percentageLost = 100.0 * counterLost / (counterWin+counterLost);


            if (nameOfTournament == "End of tournaments")
            {
                Console.WriteLine($"{percentageWin:f2}% matches win");
                Console.WriteLine($"{percentageLost:f2}% matches lost");
            }

        }
    }
}
