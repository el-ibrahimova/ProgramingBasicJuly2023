using System;

namespace _02.BraceletStand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyPerDay = double.Parse(Console.ReadLine());
            double savedMoneyPerDay = double.Parse(Console.ReadLine());
            double costsForAllDays = double.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double moneyPer5Day = 5 * (moneyPerDay + savedMoneyPerDay);
            double totalMoney = moneyPer5Day - costsForAllDays;


            if (totalMoney >= giftPrice)
            { Console.WriteLine($"Profit: {totalMoney:f2} BGN, the gift has been purchased."); }
            else
            {
                Console.WriteLine($"Insufficient money: {giftPrice - totalMoney:f2} BGN.");
            }
            
        
        }
    }
}
