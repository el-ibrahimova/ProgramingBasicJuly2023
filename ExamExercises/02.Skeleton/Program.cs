using System;

namespace _02.Skeleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            double lengthUlei = double.Parse(Console.ReadLine());
            int secondsPerMeter = int.Parse(Console.ReadLine());

            int timeRecordInSeconds = minutes * 60 + seconds;
            double path = lengthUlei / 120;
            double timeMinus = path * 2.5;
            double timeMarin = (lengthUlei / 100) * secondsPerMeter - timeMinus;

            if (timeMarin <= timeRecordInSeconds)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {timeMarin:f3}.");
            }
            else 
            {
                Console.WriteLine($"No, Marin failed! He was {timeMarin-timeRecordInSeconds:f3} second slower.");
            }


        }
    }
}
