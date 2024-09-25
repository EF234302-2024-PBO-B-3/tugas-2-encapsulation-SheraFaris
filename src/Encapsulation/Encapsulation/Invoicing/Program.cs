using System;
using Encapsulation.Invoicing;

namespace Encapsulation.Invoicing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create an Invoice object
            Invoice invoice = new Invoice("A123", "Laptop", 3, 1500.00);

            // Display the part details and calculate the invoice amount
            Console.WriteLine("Part Number: " + invoice.PartNumber);
            Console.WriteLine("Part Description: " + invoice.PartDescription);
            Console.WriteLine("Quantity: " + invoice.Quantity);
            Console.WriteLine("Price per item: $" + invoice.Price);

            // Calculate and display the invoice amount
            Console.WriteLine("Invoice Amount: $" + invoice.GetInvoiceAmount());

            // Demonstrate validation: set invalid quantity and price
            invoice.Quantity = -5;
            invoice.Price = -1000;

            // Display updated details
            Console.WriteLine("\nAfter setting invalid values:");
            Console.WriteLine("Quantity: " + invoice.Quantity); // Should be 0
            Console.WriteLine("Price per item: $" + invoice.Price); // Should be 0.0
            Console.WriteLine("Invoice Amount: $" + invoice.GetInvoiceAmount()); // Should be 0.0
        }
    }
}
