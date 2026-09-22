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
        // Removed DateTime startDate, because it is always today
        public HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays)
        {
            GuestName = guestName;
            StartDate = startDate;
            EndDate = startDate.AddDays(lengthOfStayInDays); // Calculate end date
        }

        // Methods
        /*GreetPerson() = Metoden ska hälsa personen välkommen
        AddPerson() = Metoden ska ta emot användaruppgifter, namn, ålder, kön. 
        GetDates() = Metoden ska ta emot vilka datum gästen vill boka. 
         */

        // Greet guest
        public void GreetPerson()
        {
            Console.WriteLine($"Welcome to the OOP Hotel!");
        }

        // Add guest
        public void AddPerson()
        {
            Console.WriteLine();
        }

        /* string dateString = "2023-09-25";
DateTime parsedDate = DateTime.ParseExact(dateString, "yyyy-MM-dd", null);
Console.WriteLine($"Parsed date: {parsedDate.ToShortDateString()}");
         */


        // Get dates
        public void GetDates()
        {
            Console.WriteLine("Vilken dag vill du börja din vistelse? (yyyy-MM-dd)");
            string dateString = Console.ReadLine();
            DateTime parsedDate = DateTime.ParseExact(dateString, "yyyy-MM-dd", null);
            // Set StartDate to user input
            StartDate = parsedDate;

            Console.WriteLine("Hur många dagar vill du stanna? Svara i heltal.");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int daysToStay))
            {
                End
            }    
        }

        // Print booking information

    }
}
