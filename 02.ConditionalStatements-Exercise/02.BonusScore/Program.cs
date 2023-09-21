using System;

namespace _02.BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            int points = int.Parse(Console.ReadLine());

            // 2. Calculate first bonus
            double bonus = 0;
            if (points <= 100)
            {
                bonus = 5;
            }
            else if (points <= 1000)
            {
                bonus = 0.2 * points;
            }
            else
            { 
            bonus = 0.1 * points;   
            }

            // 3. Calculate second bonus
            if (points % 2 == 0)
            {
                bonus = bonus + 1;
            }
            else if (points % 10 == 5) // dali chisloto zavarshva na 5 t.e. e s ostatak 5
            {
                bonus = bonus + 2;
            }
            // 4. Print output
            Console.WriteLine(bonus);
            Console.WriteLine(bonus + points);
        }
    }
}
