using System;
using System.Collections.Generic;
using System.Text;

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
            while(true) // loop to see if the user enters in format yyyy-MM-dd
            {
                Console.WriteLine("Vilken dag vill du började din vistelse? (yyyy-MM-dd)");
                string dateString = Console.ReadLine();

                if(dateString == )
                {

                }
                DateTime parsedDate = DateTime.ParseExact(dateString, "yyyy-MM-dd", null);
                // Set StartDate to user input
                StartDate = parsedDate;

                Console.WriteLine("Hur många dagar vill du stanna? Svara i heltal.");
            }
            
            while(true)
            {
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int daysToStay))
                {
                    // Calculate end date
                    EndDate = StartDate.AddDays(daysToStay);
                }
                else
                {
                    Console.WriteLine("Skriv in ett heltal.");
                }
            }
            
        }

        // Print info method

    }
}
