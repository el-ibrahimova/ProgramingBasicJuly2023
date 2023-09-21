using System;

namespace _03.Time_15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());

            // 2. Calculate time
            int hourInMinutes = hour * 60;
            int minutePlus = minute + 15;

            int timeInMinutes = hourInMinutes + minutePlus;

            int finalHours = timeInMinutes / 60;
            int finalMin = timeInMinutes % 60;

            if (finalHours > 23)
            {
                finalHours = 0;
            }
            if (finalMin >= 10)
            {
                Console.WriteLine($"{finalHours}:{finalMin}");
            }
            else if (finalMin < 10)
            {
                Console.WriteLine($"{finalHours}:0{finalMin}");
            }
            
        }
    }
   
}