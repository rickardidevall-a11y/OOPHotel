using System.Globalization;
using System.Xml.Linq;

namespace OOPHotel
{
    internal class HotelBooking
    {

        // Properties
        public string GuestName { get; set; } = "";
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Constructor
        public HotelBooking(string guestName, DateTime startDate)
        {
            GuestName = guestName;
            StartDate = startDate;
            // EndDate = startDate.AddDays(lengthOfStayInDays); // Calculate end date
        }

        // Greet guest
        public void GreetPerson()
        {
            Console.WriteLine("Välkommen till OOP-Hotellet!");
        }

        // Get guest name
        public void GetName()
        {
            Console.WriteLine("Skriv in ditt namn");
            while (true)
            {
                string userInput = Console.ReadLine();

                if(int.TryParse(userInput, out int number))
                {
                    Console.WriteLine("Namn kan inte vara en siffra.");
                    continue;
                }
                else
                {
                    GuestName = userInput;
                    break;
                }
            }
        }

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
            Console.WriteLine($"Besökaren {GuestName} bor på hotellet mellan {StartDate.ToShortDateString()} och {EndDate.ToShortDateString()}.");
        }


    }
}
