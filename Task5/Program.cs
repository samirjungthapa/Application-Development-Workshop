using System;

class Program
{
    static void Main()
    {
        
        DateTime birthDate = new DateTime(2003, 10, 10);

        DateTime currentDate = DateTime.Now;

        TimeSpan difference = currentDate - birthDate;

        int age = (int)(difference.TotalDays / 365.25);
        
        Console.WriteLine($"Birthdate: {birthDate:dd-MM-yyyy}");
        Console.WriteLine($"Current date and time: {currentDate}");
        Console.WriteLine($"Age: {age} years");

        DateTime newDate = birthDate.AddDays(10);

        Console.WriteLine($"Birthdate after 10 days: {newDate:dd-MM-yyyy}");
    }
}