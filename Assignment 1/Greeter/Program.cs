using System;

namespace Greeter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 6: Get fullName from user input
            Console.Write("Enter your full name: ");
            string? fullName = Console.ReadLine(); // Nullable string type

            if (fullName != null)
            {
                // Step 7: Get Date of Birth (DOB) from user input
                Console.Write("Enter your Date of Birth (YYYY/MM/DD): ");
                string? dobString = Console.ReadLine(); // Nullable string type

                if (!string.IsNullOrEmpty(dobString))
                {
                    // Step 8: Parse DOB input to DateTime
                    if (DateTime.TryParse(dobString, out DateTime dob))
                    {
                        // Step 4: Define cFullName and initialize it with fullName in uppercase
                        string cFullName = fullName.ToUpper();

                        // Step 5: Print value of cFullName in the specified format
                        Console.WriteLine($"Hello, {cFullName} Ji!");

                        // Step 9: Display user-friendly DOB format
                        Console.WriteLine($"Your DOB: {dob:dddd, dd MMMM yyyy}");

                        // Step 10: Calculate and display age
                        TimeSpan ageTimeSpan = DateTime.Now - dob;
                        int ageInYears = (int)(ageTimeSpan.TotalDays / 365.25); // Approximate number of days in a year
                        Console.WriteLine($"Your age: {ageInYears} years");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Date of Birth format. Please enter in YYYY/MM/DD format.");
                    }
                }
                else
                {
                    Console.WriteLine("Date of Birth cannot be empty. Please enter a valid date.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Full name cannot be null.");
            }

            // Keep console window open until key press
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(); // Store key press to prevent immediate closure
        }
    }
}
