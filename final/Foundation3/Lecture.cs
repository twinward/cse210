using System;

class Lecture : Event
{
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, DateTime dateTime, Address address, string speaker, int capacity)
        : base(title, description, dateTime, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string GenerateFullMessage()
    {
        return base.GenerateFullMessage() + $"\nType: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
    }
}