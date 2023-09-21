using System;

namespace _04.FitnessCenter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfVisitors = int.Parse(Console.ReadLine());

            int back = 0, chest = 0, legs = 0, abs = 0;
            int proteinShake = 0, proteinBar = 0;
            int countsOfTraining = 0, countsOfShopping = 0;


            for (int i = 1; i <= countOfVisitors; i++)
            {
                string activity = Console.ReadLine();

                switch (activity)
                {

                    case "Back": back++; countsOfTraining++; break;
                    case "Chest": chest++; countsOfTraining++; break;
                    case "Legs": legs++; countsOfTraining++; break;
                    case "Abs": abs++; countsOfTraining++; break;
                    case "Protein shake": proteinShake++; countsOfShopping++; break;
                    case "Protein bar": proteinBar++; countsOfShopping++; break;
                }
            }

            Console.WriteLine($"{back} - back");
            Console.WriteLine($"{chest} - chest");
            Console.WriteLine($"{legs} - legs");
            Console.WriteLine($"{abs} - abs");
            Console.WriteLine($"{proteinShake} - protein shake");
            Console.WriteLine($"{proteinBar} - protein bar");
            Console.WriteLine($"{100.0 *countsOfTraining/countOfVisitors:f2}% - work out");
            Console.WriteLine($"{100.0 * countsOfShopping/countOfVisitors:f2}% - protein");

        }
    }
}
