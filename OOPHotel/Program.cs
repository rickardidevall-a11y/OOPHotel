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
            hotelBooking1.PrintInfo();


            Employee employee = new Employee
            {
                Name = "Elvis Presley",
                Age = 35,
                EmployeeId = "E001",
                StartDate = new DateTime(2022, 3, 15),
                Salary = 30000m,
                JobTitle = "Receptionist",
                Department = "Front Desk"
            }; 
            
            Console.WriteLine("\nEmployee:");
            employee.PrintInfo();
            employee.Introduce();
            employee.Work();


        }
    }
}
