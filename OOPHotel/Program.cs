namespace OOPHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var hotelBooking1 = new HotelBooking("", DateTime.Now, 0);

            hotelBooking1.GreetPerson();
            hotelBooking1.GetName();
            hotelBooking1.GetDates();
            hotelBooking1.PrintInfo();

        }
    }
}
