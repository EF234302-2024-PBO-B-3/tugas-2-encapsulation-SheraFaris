namespace Encapsulation.Employment
{
    public class Employee
    {
        // Private attributes
        private string _firstName;
        private string _lastName;
        private double _monthlySalary;

        // Constructor
        public Employee(string firstName, string lastName, double monthlySalary)
        {
            // Validate firstName and lastName to not be null or empty
            _firstName = string.IsNullOrWhiteSpace(firstName) ? "Unknown" : firstName;
            _lastName = string.IsNullOrWhiteSpace(lastName) ? "Unknown" : lastName;

            // Validate monthlySalary to not be negative
            _monthlySalary = monthlySalary > 0 ? monthlySalary : 0.0;
        }

        // Public property for FirstName
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _firstName = value;
            }
        }

        // Public property for LastName
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _lastName = value;
            }
        }

        // Public property for MonthlySalary with validation
        public double MonthlySalary
        {
            get { return _monthlySalary; }
            set
            {
                if (value > 0)
                    _monthlySalary = value;
            }
        }

        // Method to raise salary with a cap of 20%
        public void RaiseSalary(int raisePercentage)
        {
            if (raisePercentage > 0 && raisePercentage <= 20)
            {
                _monthlySalary += (_monthlySalary * raisePercentage / 100);
            }
        }

        // Method to calculate the yearly salary
        public double GetYearlySalary()
        {
            return _monthlySalary * 12;
        }
    }
}
