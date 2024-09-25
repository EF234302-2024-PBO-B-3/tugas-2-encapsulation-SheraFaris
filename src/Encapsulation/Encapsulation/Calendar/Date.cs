namespace Encapsulation.Calendar
{
    public class Date
    {
        // Public properties with private setters
        public int Month { get; private set; }
        public int Day { get; private set; }
        public int Year { get; private set; }

        // Constructor to initialize the properties with validation
        public Date(int month, int day, int year)
        {
            // Validate the inputs, setting them to default values if invalid
            if (month < 1 || month > 12 || day < 1 || day > 31)
            {
                Month = 1;
                Day = 1;
                Year = 1970;
            }
            else
            {
                Month = month;
                Day = day;
                Year = year;
            }
        }

        // Public method to display the date in the format Month/Day/Year
        public void DisplayDate()
        {
            Console.WriteLine($"{Month}/{Day}/{Year}");
        }
    }
}
