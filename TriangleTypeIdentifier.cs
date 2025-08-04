using System;

namespace DCIT318Assignment
{
    public class TriangleTypeIdentifier
    {
        public void Run()
        {
            Console.WriteLine("Enter the lengths of the three sides of the triangle.");

            double side1 = ReadSide("Side 1: ");
            double side2 = ReadSide("Side 2: ");
            double side3 = ReadSide("Side 3: ");

            // Check if the sides can form a valid triangle
            if (IsValidTriangle(side1, side2, side3))
            {
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("The triangle is Equilateral.");
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    Console.WriteLine("The triangle is Isosceles.");
                }
                else
                {
                    Console.WriteLine("The triangle is Scalene.");
                }
            }
            else
            {
                Console.WriteLine("The given sides do not form a valid triangle.");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private double ReadSide(string prompt)
        {
            double side;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (double.TryParse(input, out side) && side > 0)
                    return side;
                else
                    Console.WriteLine("Invalid input! Please enter a positive number.");
            }
        }

        private bool IsValidTriangle(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
    }
}
