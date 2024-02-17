using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("1234 Main Street", "Salt Lake City", "UT", "12345");
        Address receptionAddress = new Address("7921 Tatehara", "Yori", "Saitama", "54321");
        Address outdoorAddress = new Address("5678 Local Street", "Salt Lake City", "UT", "67890");

        Lecture lectureEvent = new Lecture("A", "Lecture A", "2024/03/01", "1 PM", lectureAddress, "Dr. Smith", 30);
        Reception receptionEvent = new Reception("B", "Reception B", "2024/03/08", "2PM", receptionAddress, "rsvp@example.com");
        OutdoorGathering ourdoorEvent = new OutdoorGathering("C", "Outdoor Event C", "2024/03/15", "3 PM", outdoorAddress, "clowdy");

        Console.WriteLine("Standard Details:");
        Console.WriteLine(lectureEvent.GetStandardDetails() + "\n");

        Console.WriteLine("Full Details:");
        Console.WriteLine(lectureEvent.GetFullDetails() + "\n");

        Console.WriteLine("Short Description:");
        Console.WriteLine(lectureEvent.GetShortDescription() + "\n");

        Console.WriteLine("Standard Details:");
        Console.WriteLine(receptionEvent.GetStandardDetails() + "\n");

        Console.WriteLine("Full Details:");
        Console.WriteLine(receptionEvent.GetFullDetails() + "\n");

        Console.WriteLine("Short Description:");
        Console.WriteLine(receptionEvent.GetShortDescription() + "\n");

        Console.WriteLine("Standard Details:");
        Console.WriteLine(ourdoorEvent.GetStandardDetails() + "\n");

        Console.WriteLine("Full Details:");
        Console.WriteLine(ourdoorEvent.GetFullDetails() + "\n");

        Console.WriteLine("Short Description:");
        Console.WriteLine(ourdoorEvent.GetShortDescription() + "\n");
    }
}