using System;

namespace _05.Moviestar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string actorName = Console.ReadLine()
;
            while (actorName != "ACTION")
            {
                double actorFee = 0; 
                if (actorName.Length <= 15)
                {
                    actorFee = double.Parse(Console.ReadLine());
                }
                
                else if (actorName.Length > 15)
                {
                    actorFee = 0.2 * budget;
                }
 
                budget -= actorFee;
                
                if (budget < 0)
                {
                    break;
                }

                actorName = Console.ReadLine();
                
            }

            if (budget >= 0)
            {
                Console.WriteLine($"We are left with {budget:f2} leva.");
            }
            else 
            {
                Console.WriteLine($"We need {Math.Abs(budget):f2} leva for our actors.");
            }
        }
    }
}
