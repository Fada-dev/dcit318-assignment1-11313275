using System;

namespace DCIT318Assignment
{
    public class GradeCalculator
    {
        public void Run()
        {
            Console.Write("Enter your numerical grade (0-100): ");
            string input = Console.ReadLine();
            int grade;

            // Check if input is valid
            if (int.TryParse(input, out grade) && grade >= 0 && grade <= 100)
            {
                char letterGrade;

                if (grade >= 90)
                    letterGrade = 'A';
                else if (grade >= 80)
                    letterGrade = 'B';
                else if (grade >= 70)
                    letterGrade = 'C';
                else if (grade >= 60)
                    letterGrade = 'D';
                else
                    letterGrade = 'F';

                Console.WriteLine($"Your letter grade is: {letterGrade}");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a number between 0 and 100.");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
