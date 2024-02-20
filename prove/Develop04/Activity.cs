class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public virtual void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}!");
        Console.WriteLine(_description);
        Console.Write("Please enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);
    }

    public virtual void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done! You've completed {_name} for {_duration} seconds.");
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("\b|");
            Thread.Sleep(250);
            Console.Write("\b/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
    }
}