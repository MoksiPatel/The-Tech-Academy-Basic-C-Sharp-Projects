using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    // Create a class named MathOperation
    class MathOperation
    {
        // Create a void method that takes two integers as parameters
        public void PerformMathOperation(int num1, int num2)
        {
            // Do a math operation on the first integer (num1)
            int result = num1 * 2;

            // Display the second integer (num2) to the screen
            Console.WriteLine($"The result of the math operation on {num1} is: {result}");
            Console.WriteLine($"The second integer is: {num2}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperation class
            MathOperation mathOperation = new MathOperation();

            // Call the method in the class, passing in two numbers
            mathOperation.PerformMathOperation(5, 10);

            // Call the method in the class, specifying the parameters by name
            mathOperation.PerformMathOperation(num1: 7, num2: 20);

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
