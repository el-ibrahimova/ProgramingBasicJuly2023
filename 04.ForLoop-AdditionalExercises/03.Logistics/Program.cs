using System;

namespace _03.Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfCargos = int.Parse(Console.ReadLine());
            int tons;

            int tonsByBus = 0;
            int tonsByTruck = 0;
            int tonsByTrain = 0;

            for (int i = 1; i <= countOfCargos; i++)
            {
                tons = int.Parse(Console.ReadLine());

                if (tons <= 3) 
                { 
                  tonsByBus += tons; 
                }
                else if (tons <= 11) 
                {tonsByTruck += tons; ;
                }
                else 
                { tonsByTrain += tons; }
            }
                int totalLoads = tonsByBus + tonsByTruck + tonsByTrain;
                double averagePrice = 1.0*(tonsByBus * 200 + tonsByTruck * 175 + tonsByTrain * 120) / totalLoads;

            double percentageBus = 100.0 * tonsByBus / totalLoads;
            double percentageTruck = 100.0 * tonsByTruck / totalLoads;
            double percentageTrain = 100.0 * tonsByTrain / totalLoads;

            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{percentageBus:f2}%");
            Console.WriteLine($"{percentageTruck:f2}%");
            Console.WriteLine($"{percentageTrain:f2}%");
        }
    }
}
