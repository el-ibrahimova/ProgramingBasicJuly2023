using System;

namespace _03.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. четем n от конзолата
            int n = int.Parse(Console.ReadLine());

            int num;
            int countP1 = 0;
            int countP2 = 0;
            int countP3 = 0;
            int countP4 = 0;
            int countP5 = 0;

            // 2. създаваме цикъл, който да се изпънява за всяко число (до n-тото)
            for (int i = 1; i <= n; i++)
            {
                // => четем текущото число
                num = int.Parse(Console.ReadLine());

                // => проверваме в кой диапазон попада
                // num<200 => num<400 => num<600 => num<800 => num >=800
                if (num < 200)
                {
                    countP1++;
                }
                else if (num < 400)
                {
                    countP2++;
                }
                else if (num < 600)
                {
                    countP3++;
                }
                else if (num < 800)
                {
                    countP4++;
                }
                else 
                {
                    countP5++;
                }
               
            }

            // 3. намираме какъв процент от числата са попаднали във всеки от диапазоните
            // => брой числа в диапазон / общия брой числа * 100
            double p1 = (double)countP1 / n * 100; // определяме типа да бъде double, за да избегнем грешките понеже имаме целочислено делене
            double p2 = (double)countP2 / n * 100;
            double p3 = (double)countP3 / n * 100;
            double p4 = (double)countP4 / n * 100;
            double p5 = (double)countP5 / n * 100;

            // 4. отпечатваме изходите на конзолата
            // =>(процента:f2)%
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
