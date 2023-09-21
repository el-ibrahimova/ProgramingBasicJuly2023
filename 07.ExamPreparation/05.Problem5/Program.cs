using System;

namespace _05.Problem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            int counter =0;
            bool isLoaded = true;

            string input = Console.ReadLine();

            while (input != "End")
            {
                counter++; 
                double suitcaseCapacity = double.Parse(input);


                if (counter % 3 == 0)
                {
                    suitcaseCapacity *= 1.1;
                }
                
                if (capacity - suitcaseCapacity < 0) 
                {
                    counter--;
                    isLoaded = false;
                    Console.WriteLine("No more space");
                    break;
                }
                capacity -= suitcaseCapacity;


                 input = Console.ReadLine();
            }

            if (isLoaded)
            {
                Console.WriteLine($"Congratulations! All suitcases are loaded!");
            }
          
            Console.WriteLine($"Statistic: {counter} suitcases loaded.");
        }
    }
}
