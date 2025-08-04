using System;
using DCIT318Assignment;

namespace DCIT318Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== DCIT 318: Assignment Menu ===");
                Console.WriteLine("1. Grade Calculator");
                Console.WriteLine("2. Ticket Price Calculator");
                Console.WriteLine("3. Triangle Type Identifier");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        GradeCalculator gradeCalc = new GradeCalculator();
                        gradeCalc.Run();
                        break;

                    case "2":
                        TicketPriceCalculator ticketCalc = new TicketPriceCalculator();
                        ticketCalc.Run();
                        break;

                    case "3":
                        TriangleTypeIdentifier triangle = new TriangleTypeIdentifier();
                        triangle.Run();
                        break;

                    case "4":
                        running = false;
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid selection. Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
