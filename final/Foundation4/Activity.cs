using System;

class Activity
{
    private DateTime date;
    private int durationInMinutes;

    public Activity(DateTime date, int durationInMinutes)
    {
        this.date = date;
        this.durationInMinutes = durationInMinutes;
    }

    public int DurationInMinutes
    {
        get { return durationInMinutes; }
    }

    public virtual double GetDistance() // overriden
    {
        return 0;
    }

    public virtual double GetSpeed() // overriden
    {
        return 0;
    }

    public virtual double GetPace() // overriden
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{date.ToShortDateString()} - {GetType().Name} ({durationInMinutes} min)";
    }
}