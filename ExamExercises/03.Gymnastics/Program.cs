using System;
using System.Xml.Schema;

namespace _03.Gymnastics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string typeOfSport = Console.ReadLine();

            double difficult = 0;
            double execitionPoints = 0;
            double totalPoints = 0;
            
            if (country == "Russia")
            {
                switch (typeOfSport)
                { case "ribbon": difficult = 9.100; 
                        execitionPoints = 9.400;
                        totalPoints = difficult + execitionPoints; break;
                    case "hoop":
                        difficult = 9.300; 
                        execitionPoints = 9.800;
                        totalPoints = difficult + execitionPoints; break;
                    case "rope":
                        difficult = 9.600; 
                        execitionPoints = 9.000;
                        totalPoints = difficult + execitionPoints; break;
                }    
            }
            else if (country == "Bulgaria")
            {
                switch (typeOfSport)
                {
                    case "ribbon":
                        difficult = 9.600; 
                        execitionPoints = 9.400;
                        totalPoints = difficult + execitionPoints; break;
                    case "hoop":
                        difficult = 9.550; 
                        execitionPoints = 9.750;
                        totalPoints = difficult + execitionPoints; break;
                    case "rope":
                        difficult = 9.500; 
                        execitionPoints = 9.400;
                        totalPoints = difficult + execitionPoints; break;
                }
            }
            else if (country == "Italy")
            {
                switch (typeOfSport)
                {
                    case "ribbon":
                        difficult = 9.200; 
                        execitionPoints = 9.500;
                        totalPoints = difficult + execitionPoints; break;
                    case "hoop":
                        difficult = 9.450; 
                        execitionPoints = 9.350;
                        totalPoints = difficult + execitionPoints; break;
                    case "rope":
                        difficult = 9.700; 
                        execitionPoints = 9.150;
                        totalPoints = difficult + execitionPoints; break;
                }
            }

            if (totalPoints < 20)
            {
                double notEnoughPoints = 20 - totalPoints;
                double percentage = 100.0 * notEnoughPoints/20;
                Console.WriteLine($"The team of {country} get {totalPoints:f3} on {typeOfSport}.");
                Console.WriteLine($"{percentage:f2}%");
            }
        }
    }
}
