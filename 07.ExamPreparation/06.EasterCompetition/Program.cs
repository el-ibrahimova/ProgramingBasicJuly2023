using System;

namespace _06.EasterCompetition
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int countOfCakes = int.Parse(Console.ReadLine());

            string topBakerName = "";
            int maxPoints = 0;
           
           
            for (int i = 1; i <= countOfCakes; i++)
            {

                string currentBakerName = Console.ReadLine();
                int currentBakerPoints = 0;
                string input;
                
                while ((input = Console.ReadLine()) != "Stop")

                {
                    int currentPoints = int.Parse(input);
                    currentBakerPoints += currentPoints;

                }
                Console.WriteLine($"{currentBakerName} has {currentBakerPoints} points.");

                if (currentBakerPoints > maxPoints)
                {
                    topBakerName = currentBakerName;
                    maxPoints = currentBakerPoints;
                    Console.WriteLine($"{currentBakerName} is the new number 1!");
                }
                
            }
            Console.WriteLine($"{topBakerName} won competition with {maxPoints} points!");
            
      
        
        }
    }
}
