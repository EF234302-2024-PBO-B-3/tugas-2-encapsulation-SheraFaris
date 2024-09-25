namespace Encapsulation.Banking
{
    public class BankAccount
    {
        // Private attributes
        private string _accountNumber;
        private string _accountHolder;
        private double _balance;

        // Public property for AccountNumber with validation
        public string AccountNumber
        {
            get { return _accountNumber; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _accountNumber = value;
                else
                    _accountNumber = "Unknown";
            }
        }

        // Public property for AccountHolder with validation
        public string AccountHolder
        {
            get { return _accountHolder; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _accountHolder = value;
                else
                    _accountHolder = "Unknown";
            }
        }

        // Public property for Balance
        public double Balance
        {
            get { return _balance; }
            private set
            {
                if (value >= 0)
                    _balance = value;
            }
        }

        // Constructor to initialize attributes
        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            AccountNumber = accountNumber;  // Validate via the property
            AccountHolder = accountHolder;  // Validate via the property
            Balance = balance >= 0 ? balance : 0.0;  // Initialize balance, setting to 0 if negative
        }

        // Method to deposit money into the account
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
            }
        }

        // Method to withdraw money from the account
        public void Withdraw(double amount)
        {
            if (amount > 0 && _balance >= amount)
            {
                _balance -= amount;
            }
        }

        // Method to get the current balance
        public double GetBalance()
        {
            return _balance;
        }
    }
}
