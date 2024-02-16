using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("210 W Main St", "Rexburg", "ID", "USA");
        Address address2 = new Address("584 N 200 E", "Logan", "UT", "USA");
        Address address3 = new Address("Public Access 27", "Wilmington", "NC", "USA");

        Event lectureEvent = new Lecture("Lecture: The Future of Technology", "A discussion on upcoming tech trends", new DateTime(2024, 2, 20, 15, 0, 0), address1, "John Williams", 50);
        Event receptionEvent = new Reception("Networking Reception", "A chance to network and socialize", new DateTime(2024, 3, 10, 18, 0, 0), address2, "officerelations@rsvp.com");
        Event outdoorEvent = new OutdoorGathering("Community Picnic", "Join us for a day of fun and games", new DateTime(2024, 4, 15, 12, 0, 0), address3, "Sunny skies, 70°F");

        Console.WriteLine("Lecture Event:");
        Console.WriteLine(lectureEvent.GenerateStandardMessage());
        Console.WriteLine(lectureEvent.GenerateFullMessage());
        Console.WriteLine(lectureEvent.GenerateShortDescription());

        Console.WriteLine("\nReception Event:");
        Console.WriteLine(receptionEvent.GenerateStandardMessage());
        Console.WriteLine(receptionEvent.GenerateFullMessage());
        Console.WriteLine(receptionEvent.GenerateShortDescription());

        Console.WriteLine("\nOutdoor Gathering Event:");
        Console.WriteLine(outdoorEvent.GenerateStandardMessage());
        Console.WriteLine(outdoorEvent.GenerateFullMessage());
        Console.WriteLine(outdoorEvent.GenerateShortDescription());
    }
}