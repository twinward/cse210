using System;

class Event
{
    private string title;
    private string description;
    private DateTime dateTime;
    private Address address;

    public Event(string title, string description, DateTime dateTime, Address address)
    {
        this.title = title;
        this.description = description;
        this.dateTime = dateTime;
        this.address = address;
    }

    public virtual string GenerateStandardMessage()
    {
        return $"Standard details:\n\tTitle: {title}\nDescription: {description}\n\tDate: {dateTime.ToShortDateString()}\n\tTime: {dateTime.ToShortTimeString()}\n\tAddress: {address.ToString()}";
    }

    public virtual string GenerateFullMessage()
    {
        return GenerateStandardMessage();
    }

    public virtual string GenerateShortDescription()
    {
        return $"{GetType().Name}: {title}, {dateTime.ToShortDateString()}";
    }
}