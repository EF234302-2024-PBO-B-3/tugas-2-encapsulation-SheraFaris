using System;
using Encapsulation.Banking;

namespace Encapsulation.Banking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a BankAccount object with initial values
            BankAccount myAccount = new BankAccount("12345", "John Doe", 500.0);

            // Display initial balance
            Console.WriteLine("Initial Balance: $" + myAccount.GetBalance());

            // Perform a deposit
            myAccount.Deposit(200.0);
            Console.WriteLine("After depositing $200: $" + myAccount.GetBalance());

            // Attempt to withdraw a valid amount
            myAccount.Withdraw(150.0);
            Console.WriteLine("After withdrawing $150: $" + myAccount.GetBalance());

            // Attempt to withdraw an invalid amount (more than the balance)
            myAccount.Withdraw(700.0);
            Console.WriteLine("After attempting to withdraw $700 (should not change): $" + myAccount.GetBalance());

            // Attempt to deposit a negative amount
            myAccount.Deposit(-50.0);
            Console.WriteLine("After attempting to deposit -$50 (should not change): $" + myAccount.GetBalance());
        }
    }
}
