using System;

class Swimming : Activity
{
    private int laps;
    private const double LapDistanceMeters = 50;

    public Swimming(DateTime date, int durationInMinutes, int laps)
        : base(date, durationInMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * LapDistanceMeters / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (DurationInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return DurationInMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Laps: {laps}, Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}