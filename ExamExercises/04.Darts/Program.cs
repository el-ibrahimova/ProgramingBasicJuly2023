using System;
using System.Threading.Tasks;

namespace _04.Darts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
             int totalPoints = 0;
            int countOfShots = 0;
            int unsuccesfullShots = 0;

            int startPoints = 301;


            while (playerName != "Retire") 
            {
                              
                int points = int.Parse(playerName); 
                string pole = Console.ReadLine();

                    if (pole == "Single") { totalPoints = points; }
                    else if (pole == "Double") { totalPoints = 2 * points; }
                    else if (pole == "Triple") { totalPoints = 3 * points; }


                    if (totalPoints <= startPoints)
                    {
                        startPoints -= totalPoints;
                        countOfShots++;
                    }
                    else
                    {
                        unsuccesfullShots++;
                    }
                }
                playerName = Console.ReadLine();

            
            if (startPoints == 0)
                Console.WriteLine($"{playerName} won the leg with {countOfShots} shots.");
            else
            { Console.WriteLine($"{playerName} retired after {unsuccesfullShots} unsuccessful shots."); }

        }
    }
}
