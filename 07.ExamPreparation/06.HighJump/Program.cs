using System;

namespace _06.HighJump
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int finalJump = int.Parse(Console.ReadLine());

            int currentGoal = finalJump - 30;
            int countsTry = 0;
            bool isFail = false;
            bool isSuccess = false;
            int lastJump = 0;

            while (true)
            {
                int currentJump = 0;

                for (int tryToJump = 1; tryToJump <=3; tryToJump++)
                {
                    currentJump = int.Parse(Console.ReadLine());
                    countsTry++;
                    lastJump = currentJump;

                    if (currentJump > currentGoal)
                    {
                        currentGoal += 5;
                        break;
                    }
                    if (currentJump <=  currentGoal && tryToJump == 3)
                    {
                        isFail = true;
                        break;
                    }
                    
                }

                if (currentJump > finalJump)
                {
                    isSuccess = true;
                    break;
                }

                if (isFail) 
                { break; }
            }

            if (!isSuccess)
            {
                Console.WriteLine($"Tihomir failed at {lastJump}cm after {countsTry} jumps.");
            }
            else
            {
                Console.WriteLine($"\"Tihomir succeeded, he jumped over {finalJump}cm after {countsTry} jumps.");
            }
        }
    }
}
