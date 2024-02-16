using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Activities
        Activity runningActivity = new Running(new DateTime(2024, 2, 13), 45, 4.5);
        Activity cyclingActivity = new StationaryBicycle(new DateTime(2024, 2, 14), 90, 15);
        Activity swimmingActivity = new Swimming(new DateTime(2024, 2, 15), 30, 25);

        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        // Display
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}