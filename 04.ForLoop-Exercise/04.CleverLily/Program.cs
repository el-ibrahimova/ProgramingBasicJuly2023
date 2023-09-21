using System;

namespace _04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. четем вход от конзолата
           
            int age = int.Parse(Console.ReadLine());
            double washingMaschine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int money = 0;

            // 2. създаваме цикъл, който да се изпълнява за всеки рожден ден

            for (int birthday = 1; birthday <= age; birthday++)
            {
                // => проверяваме дали текущия РД е четен или нечетен
                // ==> ако е четен => към спестяванята до момента += (възрастта * 5) - 1
                if (birthday % 2 == 0)
                {
                    money += birthday * 5 - 1;
                }

                // ==> ако е нечетен => към спестяванята до момента += цена на играчка 
                else
                {
                    money += toyPrice;
                }

            }

            // 3. проверяваме дали парите са достатъчни, за да си купи пералня
            if (money >= washingMaschine)
            // => ако са печатаме
            {
                Console.WriteLine($"Yes! {money - washingMaschine:f2}");
            }
            // => ако не са печатаме 
            else
            {
                Console.WriteLine($"No! {washingMaschine- money:f2}");
            }
        }
    }
}
