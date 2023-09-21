using System;
using System.Collections.Generic;

namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read input
            int maxBadGradesCount = int.Parse(Console.ReadLine());

            // 2. Cycle through all problems
            // if "Enought" is entered, the cycle should stop
            // if too much bad grades happen, the cycle should stop

            int badGradesCount = 0;
            int gradesSum = 0, problemsCount = 0;
            string lastProblemName = ""; // string.Empty;
            bool failed = false;

            string input = Console.ReadLine();
            while (input != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                
                gradesSum += grade;
                problemsCount++;
                lastProblemName = input;

                if (grade <= 4)  // if (grade <=4 && ++ badGradesCount == maxBadGradesCount)) / failed = true; / break;
                { 
                    badGradesCount++;
                    if (badGradesCount == maxBadGradesCount)
                    {
                        failed = true;
                        break; 
                    }
                }

                input = Console.ReadLine();
            }

            // 3. Print output
       
            if (!failed)
            {
                Console.WriteLine($"Average score: {1.0 * gradesSum / problemsCount:f2}");
                Console.WriteLine($"Number of problems: {problemsCount}");
                Console.WriteLine($"Last problem: {lastProblemName}");
            }
            else
            {
             Console.WriteLine($"You need a break, {badGradesCount} poor grades.");
            }

        }
    }
}
