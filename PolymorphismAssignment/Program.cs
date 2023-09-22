using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{

    // Create an interface called IQuittable with a Quit() method
    interface IQuittable
    {
        void Quit();
    }

    // Create an Employee class that inherits from IQuittable
    class Employee : IQuittable
    {
        // Properties of the Employee class
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor to initialize Employee object
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Implement the Quit() method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} has quit their job.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object
            Employee employee = new Employee("John", "Doe");

            // Create an object of type IQuittable using polymorphism
            IQuittable quittableEmployee = employee;

            // Call the Quit() method on the IQuittable object
            quittableEmployee.Quit();

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
