using System;
using Encapsulation.Employment;

namespace Encapsulation.Employment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create two Employee objects
            Employee employee1 = new Employee("John", "Doe", 3000.00);
            Employee employee2 = new Employee("Jane", "Smith", 3500.00);

            // Display their annual salaries
            Console.WriteLine("Annual salary of " + employee1.FirstName + " " + employee1.LastName + ": $" + employee1.GetYearlySalary());
            Console.WriteLine("Annual salary of " + employee2.FirstName + " " + employee2.LastName + ": $" + employee2.GetYearlySalary());

            // Give both employees a 10% raise
            employee1.RaiseSalary(10);
            employee2.RaiseSalary(10);

            // Display their annual salaries again after the raise
            Console.WriteLine("\nAfter 10% raise:");
            Console.WriteLine("Annual salary of " + employee1.FirstName + " " + employee1.LastName + ": $" + employee1.GetYearlySalary());
            Console.WriteLine("Annual salary of " + employee2.FirstName + " " + employee2.LastName + ": $" + employee2.GetYearlySalary());
        }
    }
}
