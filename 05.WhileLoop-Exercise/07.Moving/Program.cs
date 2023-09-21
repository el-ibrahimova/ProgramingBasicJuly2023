using System;

namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int freeVolume = width * length * height;
            int takenVolume = 0;

            string input = Console.ReadLine();

            while (input != "Done")
            {
                int takenBoxes = int.Parse(input);
                takenVolume += takenBoxes;

                if (takenVolume >= freeVolume) { break; }

                input = Console.ReadLine();
            }

            if (takenVolume <= freeVolume)
            {
                Console.WriteLine($"{freeVolume - takenVolume} Cubic meters left.");
            }
            else 
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(takenVolume- freeVolume)} Cubic meters more.");
            }

        }
    }
}
