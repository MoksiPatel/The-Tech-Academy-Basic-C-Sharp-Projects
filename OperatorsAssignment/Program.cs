using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    internal class Program
    {
        // Create an Employee class
        class Employee
        {
            // Properties of the Employee class
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            // Constructor to initialize Employee object
            public Employee(int id, string firstName, string lastName)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
            }

            // Overload the "==" operator to compare Employee objects by their Id property
            public static bool operator ==(Employee employee1, Employee employee2)
            {
                if (ReferenceEquals(employee1, null) && ReferenceEquals(employee2, null))
                {
                    // Both objects are null, so they are equal
                    return true;
                }
                if (ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null))
                {
                    // One object is null while the other is not, so they are not equal
                    return false;
                }
                return employee1.Id == employee2.Id; // Compare by Id property
            }

            // Overload the "!=" operator to complement the "==" operator
            public static bool operator !=(Employee employee1, Employee employee2)
            {
                return !(employee1 == employee2);
            }
        }
        static void Main(string[] args)
        {
            // Instantiate two Employee objects
            Employee employee1 = new Employee(1, "John", "Doe");
            Employee employee2 = new Employee(2, "Jane", "Smith");
            Employee employee3 = null; // To demonstrate null comparison

            // Compare Employee objects using the overloaded operators
            bool areEqual1 = employee1 == employee2; // Compare by Id
            bool areEqual2 = employee1 != employee2; // Complement of ==
            bool areEqual3 = employee1 == employee3; // Compare with null object

            // Display the results of comparisons
            Console.WriteLine($"Are employee1 and employee2 equal by Id? {areEqual1}");
            Console.WriteLine($"Are employee1 and employee2 not equal by Id? {areEqual2}");
            Console.WriteLine($"Are employee1 and employee3 (null) equal? {areEqual3}");

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
