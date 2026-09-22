using System.Globalization;

namespace OOPHotel
{
    internal class HotelBooking
    {

        // Fields
        public string GuestName { get; set; } = "";
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Constructor
        public HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays)
        {
            GuestName = guestName;
            StartDate = startDate;
            // EndDate = startDate.AddDays(lengthOfStayInDays); // Calculate end date
        }

        // Greet guest
        public void GreetPerson()
        {
            Console.WriteLine("Welcome to the OOP Hotel!");
        }

        // Get guest name
        public void GetName()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            GuestName = name;
        }

        /* string dateString = "2023-09-25";
DateTime parsedDate = DateTime.ParseExact(dateString, "yyyy-MM-dd", null);
Console.WriteLine($"Parsed date: {parsedDate.ToShortDateString()}");
         */


        // Get dates method
        public void GetDates()
        {
            Console.WriteLine("Vilken dag vill du börja din vistelse? (yyyy-MM-dd)");

            // Check start date
            while (true) // loop to see if the user enters in format yyyy-MM-dd
            {
                string dateString = Console.ReadLine();

                // what to parse, what format to expect, which culture to use, special date/time rules, where to put result
                if (DateTime.TryParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                {
                    // Set StartDate to user input
                    StartDate = parsedDate;
                    break;
                }
                else
                {
                    Console.WriteLine("Skriv in i formatet yyyy-MM-dd");
                    continue;
                }

                // DateTime parsedDate = DateTime.ParseExact(dateString, "yyyy-MM-dd", null);

                
            }

            // How many days to stay?
            Console.WriteLine("Hur många dagar vill du stanna? Svara i heltal.");
            while (true)
            {
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int daysToStay))
                {
                    // Calculate end date
                    EndDate = StartDate.AddDays(daysToStay);
                    break;
                }
                else
                {
                    Console.WriteLine("Skriv in ett heltal.");
                    continue;
                }
            }
            
        }

        // Print info method
        public void PrintInfo()
        {
            Console.WriteLine($"The visitor {GuestName} will arrive {StartDate} and will stay until {EndDate}.");
        }


    }
}
