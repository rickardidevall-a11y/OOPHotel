using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHotel
{
    internal class HotelBooking
    {

        // Fields
        public string GuestName { get; set; } = "";
        public DateTime StartDate { get; set; } = DateTime.Today;
        public DateTime EndDate { get; set; }

        // Constructor
        public HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays)
        {
            GuestName = guestName;
            StartDate = startDate;
            // Calculate end date
            EndDate = startDate.AddDays(lengthOfStayInDays);
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

        // Print booking information

    }
}
