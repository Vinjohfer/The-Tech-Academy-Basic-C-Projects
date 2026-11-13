
using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the welcome message.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Ask the user to enter the package weight.
            Console.WriteLine("Please enter the package weight:");
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // Check if the package is too heavy.
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            // Ask the user to enter the package width.
            Console.WriteLine("Please enter the package width:");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            // Ask the user to enter the package height.
            Console.WriteLine("Please enter the package height:");
            decimal height = Convert.ToDecimal(Console.ReadLine());

            // Ask the user to enter the package length.
            Console.WriteLine("Please enter the package length:");
            decimal length = Convert.ToDecimal(Console.ReadLine());

            // Check if the total dimensions are greater than 50.
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // Calculate the shipping quote using the given formula.
            decimal quote = (width * height * length * weight) / 100;

            // Display the shipping quote with two decimal places.
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));

            // Display the thank-you message.
            Console.WriteLine("Thank you!");

            // Keep the console window open until the user presses a key.
            Console.ReadLine();
        }
    }
}

