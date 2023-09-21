using System;

namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();   

            double sumGrades = 0;
            int grade = 1;
            int badGrades = 0;

            while (grade <= 12)
            {
                double currentGrade = double.Parse(Console.ReadLine());
                if (currentGrade < 4)
                {
                    badGrades++;
                    if (badGrades > 1)
                    {
                        break;
                    }
                    continue;
                }
                grade++;
                sumGrades += currentGrade;
            }

            if (badGrades > 1)
            {
                Console.WriteLine($"{name} has been excluded at {grade} grade");
            }
            else
            {
                double averageGrade = sumGrades / 12;
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}
