using System;

namespace _04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Prepare loop
            // - if "Going home" is entered, the loop should stop its execution
            // - if >= 10 000 steps are walked, the loop should stop its execution
            
            string input = Console.ReadLine();
            int totalSteps = 0;
            bool goalIsReached = false;

            while (input != "Going home")
            {
                int steps = int.Parse(input);
                totalSteps += steps;

                if (totalSteps >= 10000) 
                {
                    goalIsReached = true;
                    break; 
                }
                
                input = Console.ReadLine();
            }

            if (!goalIsReached) // if (totalSteps < 10000)
            {
                int stepsGoingHome = int.Parse(Console.ReadLine());
                totalSteps += stepsGoingHome;
            }


            // 2. Print output
            if (totalSteps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - 10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
            }
        }
    }
}
