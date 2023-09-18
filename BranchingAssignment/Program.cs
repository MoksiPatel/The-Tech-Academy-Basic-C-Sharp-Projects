using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BranchingAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt for package weight
            Console.Write("Please enter the package weight: ");
            double weight = double.Parse(Console.ReadLine());

            // Check if weight exceeds 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                // Prompt for package dimensions
                Console.Write("Please enter the package width: ");
                double width = double.Parse(Console.ReadLine());
                Console.Write("Please enter the package height: ");
                double height = double.Parse(Console.ReadLine());
                Console.Write("Please enter the package length: ");
                double length = double.Parse(Console.ReadLine());

                // Calculate the sum of dimensions
                double dimensionsTotal = width + height + length;

                // Check if dimensions total exceeds 50
                if (dimensionsTotal > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    // Calculate the quote
                    double quote = (width * height * length * weight) / 100;

                    // Display the quote to the user
                    string message = "Your estimated total for shipping this package is: " + quote;
                    Console.WriteLine(message);
                }
            }
            Console.WriteLine("Thank you!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
