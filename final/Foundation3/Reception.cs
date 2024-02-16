using System;

class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, DateTime dateTime, Address address, string rsvpEmail)
        : base(title, description, dateTime, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GenerateFullMessage()
    {
        return base.GenerateFullMessage() + $"\nType: Reception\nRSVP Email: {rsvpEmail}";
    }
}