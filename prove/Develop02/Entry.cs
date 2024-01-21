using System;

public class Entry
{
    public DateTime Date { get; set; }
    public string EntryPrompt { get; set; }
    public string Response { get; set; }

    public void Display()
    {
        Console.WriteLine($"{Date}\t{EntryPrompt}");
        Console.WriteLine($"\t\t{Response}");
    }
}