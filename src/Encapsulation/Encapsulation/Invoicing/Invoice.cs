namespace Encapsulation.Invoicing
{
    public class Invoice
    {
        // Private attributes
        private string _partNumber;
        private string _partDescription;
        private int _quantity;
        private double _price;

        // Constructor
        public Invoice(string partNumber, string partDescription, int quantity, double price)
        {
            _partNumber = partNumber;
            _partDescription = partDescription;
            Quantity = quantity; // Using property for validation
            Price = price;       // Using property for validation
        }

        // Public property for PartNumber
        public string PartNumber
        {
            get { return _partNumber; }
            set { _partNumber = value; }
        }

        // Public property for PartDescription
        public string PartDescription
        {
            get { return _partDescription; }
            set { _partDescription = value; }
        }

        // Public property for Quantity with validation
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value > 0)
                    _quantity = value;
                else
                    _quantity = 0; // Set to 0 if negative or zero
            }
        }

        // Public property for Price with validation
        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 0.0)
                    _price = value;
                else
                    _price = 0.0; // Set to 0.0 if negative or zero
            }
        }

        // Method to calculate the invoice amount
        public double GetInvoiceAmount()
        {
            return _quantity * _price;
        }
    }
}
