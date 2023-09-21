using System;

namespace _06.Bills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int monthCount = int.Parse(Console.ReadLine());
            double water = 20;
            double internet = 15;
            double electricity;
            double other = 0, average = 0;
            double totalElectricity = 0;
            double totalOther = 0;

            for (int i = 1; i <= monthCount; i++)
            {
                electricity = double.Parse(Console.ReadLine());
                other = (electricity + water + internet) * 1.2;
                // (electricity + water + internet) * 0.2 +(electricity + water + internet)
                totalOther += other;
                totalElectricity += electricity;
            }

            double totalWater = water * monthCount;
            double totalInternet = internet * monthCount;
            average = (totalElectricity + totalInternet + totalOther + totalWater) / monthCount;
           
            Console.WriteLine($"Electricity: {totalElectricity:f2} lv");
            Console.WriteLine($"Water: {totalWater:f2} lv");
            Console.WriteLine($"Internet: {totalInternet:f2} lv");
            Console.WriteLine($"Other: {totalOther:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
