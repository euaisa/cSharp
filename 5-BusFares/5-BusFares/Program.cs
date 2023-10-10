using System;

namespace _5_BusFares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask user's age
            Console.WriteLine("Enter your age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());

            // Check which day of the week it is
            Console.WriteLine("Enter the day of your trip: ");
            string tripDay = Console.ReadLine();

            // Initialize fare variable
            double fare = 0.0;

            // Check the day of the week and calculate fare accordingly
            if (tripDay.ToLower() == "monday" || tripDay.ToLower() == "tuesday" || tripDay.ToLower() == "wednesday" || tripDay.ToLower() == "thursday" || tripDay.ToLower() == "friday")
            {
                // Weekday
                if (userAge < 16 || userAge > 65)
                {
                    fare = 5.00;
                }
                else
                {
                    fare = 6.00;
                }
            }
            else if (tripDay.ToLower() == "saturday")
            {
                // Saturday
                if (userAge < 16 || userAge > 65)
                {
                    fare = 4.00;
                }
                else
                {
                    fare = 5.00;
                }
            }
            else if (tripDay.ToLower() == "sunday")
            {
                // Sunday
                if (userAge < 16 || userAge > 65)
                {
                    fare = 3.00;
                }
                else
                {
                    fare = 4.00;
                }
            }
            else
            {
                Console.WriteLine("Invalid day input. Please enter a valid day.");
                return; // exit the program if the day is invalid
            }

            // Display the calculated fare
            Console.WriteLine($"Your bus fare for {tripDay} is: ${fare}");
        }
    }
}
