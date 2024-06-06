using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Elm Street", "New York City", "NY", "USA");
        Lecture lecture = new Lecture("Object Oriented Programming", "Inheritance", "1/1/2023", "9:00 am", address1, "Bob the Builder", 100);
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDetails());

        Reception reception = new Reception("Graduation", "MSD 321 Graduation Party", "6/1/2023", "7:00 pm", address1, "grad@msd321.com");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDetails());

        Address address2 = new Address("246 Oak Circl", "London", "England", "UK");
        Outdoor outdoor = new Outdoor("Bridge Tour", "Tour the London Bridge", "10/13/2023", "11:30 am", address2, "Chance of Rain and Wind");
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine(outdoor.GetShortDetails());
    }
}