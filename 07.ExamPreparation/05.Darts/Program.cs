using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace _05.Darts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string gamerName = Console.ReadLine();

            int startPoints = 301;
            int countOfShoots = 0;
            int foolShoots = 0;

            string area = Console.ReadLine();
                                            
            while (area != "Retire")
            {
                int points = int.Parse(Console.ReadLine());

                switch (area)
                {
                    case "Single": points *= 1; break;
                    case "Double": points *= 2; break;
                    case "Triple": points *= 3; break;
                }

                if (points < startPoints)
                {
                    startPoints -= points;
                    countOfShoots++;
                    
                }

                else if (points== startPoints)
                {
                    startPoints -= points;
                    countOfShoots++;
                    break;
                }
                else
                {
                    foolShoots++;
                }
             
            }

            if (area == "Retire")
            {
                Console.WriteLine($"{gamerName} retired after {foolShoots} unsuccessful shots.");
            }
           else            
            {
                Console.WriteLine($"{gamerName} won the leg with {countOfShoots} shots.");
            }
            

        }
    }
}
