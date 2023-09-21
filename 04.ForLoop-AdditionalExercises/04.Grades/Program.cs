using System;

namespace _04.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfStudent = int.Parse(Console.ReadLine());
            double grade;
            int g2 = 0, g3 = 0, g4 = 0, g5 = 0;
            double sum = 0; 

            for (int i = 1; i <= countOfStudent; i++)
            {
                grade = double.Parse(Console.ReadLine());

                if (grade >= 2.00 && grade <=2.99) { g2++; }
                else if (grade <= 3.99) { g3++; }
                else if (grade <= 4.99) { g4++; }
                else { g5++;  }

                sum += grade;
                
            }

            double percentageG2 = 100.0 * g2 / countOfStudent;
            double percentageG3 = 100.0 * g3 / countOfStudent;
            double percentageG4 = 100.0 * g4 / countOfStudent;
            double percentageG5 = 100.0 * g5 / countOfStudent;
            double average = 1.0* sum/ countOfStudent;

            Console.WriteLine($"Top students: {percentageG5:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percentageG4:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percentageG3:f2}%");
            Console.WriteLine($"Fail: {percentageG2:f2}%");
            Console.WriteLine($"Average: {average:f2}");

        }
    }
}
