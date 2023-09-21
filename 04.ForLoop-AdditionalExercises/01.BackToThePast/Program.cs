using System;


namespace _01.BackToThePast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double heritage = double.Parse(Console.ReadLine());
            int yearLife = int.Parse(Console.ReadLine());

            double moneySpent = 0;
            double heritageLeft = 0;
            
            for (int i = 1800; i <= yearLife; i++)
            {
                

                if (i % 2 == 0) 
                { 
                    moneySpent += 12000;
                }
                 else
                { 
                    int age = 18 + (i - 1800);
                    moneySpent += 12000 + 50 * age;
                }
             heritageLeft = heritage - moneySpent;
            }
                       

            if (heritage >= moneySpent)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {heritageLeft:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {moneySpent-heritage:f2} dollars to survive.");
            }
        }
    }
}
