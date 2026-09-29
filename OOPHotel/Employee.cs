namespace OOPHotel;

public class Employee: Person
{
    public string JobTitle { get; set; }
}

public override void Work()
{
    Console.WriteLine("I'm currently Working...");
}