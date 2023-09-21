using System;

namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. четем от конзолата
            string actorName = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int juriesCount = int.Parse(Console.ReadLine());

            string assessorName;
            double assessorPoints;

            // 2. създаваме цикъл, който да се изпълнава за всеки от журито
            for (int i = 1; i <= juriesCount; i++)
            {
                // => четем от конзолата име на оценяващ и точки, които дава
                assessorName = Console.ReadLine();
                assessorPoints = double.Parse(Console.ReadLine());

                // => трябва да изчислим колко точки да добавим към досегашните точки на актьора
                // ==> дължината на името на оценяващия * точките които дава /2
                points += assessorName.Length * assessorPoints / 2;

                // => проверяваме дали точките са >= 1250.5
                // => ако са станали отпечатваме поздравленията  =>спраме цикъла
                
                if (points >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:f1}!");
                    break;
                }
                        
            }

            // 3. проверяваме дали точките са < 1250.5 => отпечатваме колко точки още са му нужни
            if (points < 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - points:f1} more!");
            }
        }
    }
}
