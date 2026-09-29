using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHotel
{
    public abstract class Person
    {
        // Fields
        public string Name;
        public int Age;
        public string Department;
        public string EmployeeId;
        public decimal Salary;
        public DateTime StartDate;

        // Abstract method work
        public abstract void Work();

        // Print info
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}\nAge: {Age}\nEmployee ID: {EmployeeId}\nStart date: {StartDate}\nSalary: {Salary}\nDepartment: {Department}");
        }

        // Introduction
        public void Introduction()
        {
            Console.WriteLine($"Hej, jag heter {Name} och jobbar på avdelningen {Department}.");
        }

    }
}
