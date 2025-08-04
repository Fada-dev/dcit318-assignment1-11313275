using System;

namespace DCIT318Assignment
{
	public class TicketPriceCalculator
	{
		public void Run()
		{
			Console.Write("Enter your age: ");
			string input = Console.ReadLine();
			int age;

			if (int.TryParse(input, out age) && age >= 0)
			{
				double ticketPrice;

				if (age <= 12 || age >= 65)
					ticketPrice = 7.00;
				else
					ticketPrice = 10.00;

				Console.WriteLine($"Your ticket price is: GHC {ticketPrice:0.00}");
			}
			else
			{
				Console.WriteLine("Invalid input! Please enter a valid age.");
			}

			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}
	}
}
