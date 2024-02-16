using System;

class StationaryBicycle : Activity
{
    private double speed;

    public StationaryBicycle(DateTime date, int durationInMinutes, double speed)
        : base(date, durationInMinutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {speed} mph, Pace: {GetPace()} min per mile";
    }
}