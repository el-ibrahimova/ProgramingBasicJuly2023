using System;

namespace _06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int totalCakePieces = width * length;

            // if "STOP" is entered, the loop should stop its execution
            // if totalCakePieces is not enought, the loop should stop its execution

            string input = Console.ReadLine();

            while (input != "STOP")
            {
                int piecesToSubstract = int.Parse(input);
                totalCakePieces -= piecesToSubstract;
                if (totalCakePieces < 0)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            if (totalCakePieces >= 0)
            {
                Console.WriteLine($"{totalCakePieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(totalCakePieces)} pieces more.");
            }

        }
    }
}
