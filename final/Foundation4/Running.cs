using System;

class Running : Activity
{
    private double distance;

    public Running(DateTime date, int durationInMinutes, double distance)
        : base(date, durationInMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / (DurationInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return DurationInMinutes / distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}