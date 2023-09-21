using System;

namespace _05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. четем от конзолата
            int tabsCount = int.Parse(Console.ReadLine());  
            int salary = int.Parse( Console.ReadLine());

            // 2. създаваме цикъл, който се изпълнява за всеки отворен таб
            for (int tab = 1; tab <=  tabsCount; tab++)
            {
                // = > четем име на сайт, отворен на съответния таб
                string site = Console.ReadLine();

                // проверяваме дали е:
                // => Facebook => глоба 150лв (заплата - 150)
                // => Instagram => глоба 100лв (заплата - 100)
                // => Reddit => глоба 50лв (заплата - 50)

                if (site == "Facebook")
                {
                    salary -= 150; // salary = salary - 150
                }
                else if (site == "Instagram")
                {
                    salary -= 100;
                }
                else if (site == "Reddit")
                {
                    salary -= 50;
                }

                // проверяваме дали заплатата <=0
                // => ако е отпечатваме на конзолата "You have lost your salary." 
                // => спираме изпълнението на цикъла
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
                
            }


            // 3. проверяваме дали е останала заплата
            // => ако е отпечатваме колко пари са останали
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
