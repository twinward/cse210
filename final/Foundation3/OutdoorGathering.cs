using System;

class OutdoorGathering : Event
{
    private string weatherForecast;

    public OutdoorGathering(string title, string description, DateTime dateTime, Address address, string weatherForecast)
        : base(title, description, dateTime, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string GenerateFullMessage()
    {
        return base.GenerateFullMessage() + $"\nType: Outdoor Gathering\nWeather Forecast: {weatherForecast}";
    }
}