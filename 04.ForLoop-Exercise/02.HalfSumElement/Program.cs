using System;

namespace _02.HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. четем n от конзолата (колко числа ще бъдат въведени)
            int n = int.Parse(Console.ReadLine());

            int num;
            int maxNum = int.MinValue;
            int sum = 0;

            // 2.пускаме цикъл, който да се изпълнява n пъти
            for (int i = 1; i <= n; i++)
            {
                // => четем число от конзолата
                num = int.Parse(Console.ReadLine());

                //=> проверяваме дали числото е най-голямото въведено до момента
                if (num > maxNum)
                {
                    // ==> то става най-голямото число
                    maxNum = num;
                }

                // => добавяме го към сумата на всички останали
                sum += num;
            }

            // 3. от сумата на всички числа вадим най-голямото (това става след като сме въвели всички числа)
            sum -= maxNum; // sum = sum - maxNum;

            // 4. проверяваме дали най-голямото число == на сумата на всички останали
            if (sum == maxNum)
            {
                //=> ако е равна отпечатваме 
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {  // => ако не е равна отпечатваме "No" и на нов ред "Diff = " + разликата между най-големия 
               // елемент и сумата на останалите (по абсолютна стойност)

                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum - maxNum)}");
            }
        
        }
    }
}
