namespace OOPHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Default values. Doesn't matter. Only to put something there
            var hotelBooking1 = new HotelBooking("", DateTime.Now);

            hotelBooking1.GreetPerson();
            hotelBooking1.GetName();
            hotelBooking1.GetDates();
            hotelBooking1.ChangeBooking();
            hotelBooking1.PrintInfo();

        }
    }
}
