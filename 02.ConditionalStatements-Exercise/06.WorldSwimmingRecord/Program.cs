using System;

namespace _06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timePerMeterInSeconds = double.Parse(Console.ReadLine());

            // 2. Calculate the time
            // - add time for water resistance
            double totalTime = distanceInMeters * timePerMeterInSeconds + Math.Floor(distanceInMeters / 15) * 12.5;


            // 3. Print output
            if (totalTime < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - recordInSeconds:f2} seconds slower.");
            }

        }
    }
}
