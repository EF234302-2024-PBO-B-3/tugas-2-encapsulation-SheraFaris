using System;
using Encapsulation.Calendar;

namespace Encapsulation.Calendar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create two Date objects: one with valid input and one with invalid input
            Date validDate = new Date(12, 25, 2023);
            Date invalidDate = new Date(15, 40, 2023);  // Invalid month and day

            // Display both dates using DisplayDate method
            Console.WriteLine("Valid date:");
            validDate.DisplayDate();  // Should display: 12/25/2023

            Console.WriteLine("\nInvalid date (set to default):");
            invalidDate.DisplayDate();  // Should display: 1/1/1970
        }
    }
}
