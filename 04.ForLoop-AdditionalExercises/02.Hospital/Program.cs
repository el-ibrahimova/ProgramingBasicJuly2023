using System;

namespace _02.Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfDays = int.Parse(Console.ReadLine());

            int patients;
            int treatedPatients = 0;
            int untreatedPatients = 0;
            int countOfDoctors = 7;

            for (int i = 1; i <= countOfDays; i++)
            {
                patients = int.Parse(Console.ReadLine());
               
                if (patients <= 7)
                {
                    treatedPatients += patients;
                }

                else if (patients > 7)
                {
                    untreatedPatients += (patients - countOfDoctors);
                    treatedPatients += countOfDoctors;

                    if (i % 10 == 2 && (untreatedPatients > treatedPatients))
                    { 
                        countOfDoctors++;
                    }
                } 

            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }         
    }
}
