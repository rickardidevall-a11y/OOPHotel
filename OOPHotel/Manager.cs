using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHotel
{
    public class Manager : Person
    {
        // No unique Fields for Manager, we put Department in Person class. 
       

        public Manager(string name, int age, int employeeId, string department, int startDate, int salaryId)
        {
            
        }

        public void HoldMeeting()
        {
            Console.WriteLine("The manager is holding a meeting at the hotel now");
        }

        public override void Work()
        {
            Console.WriteLine($"The Manager is working");
        }
    }
}
