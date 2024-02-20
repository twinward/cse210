class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void DisplayStartingMessage()
    {
        base.DisplayStartingMessage();
        Console.WriteLine("Begin breathing...");
    }

    public void Run()
    {
        DisplayStartingMessage();
        int timeElapsed = 0;
        while (timeElapsed < _duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
            timeElapsed += 6; // Each breath takes 6 seconds
        }
        DisplayEndingMessage();
    }
}