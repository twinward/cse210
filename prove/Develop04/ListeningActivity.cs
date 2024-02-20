class ListeningActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListeningActivity() : base("Listening Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public override void DisplayStartingMessage()
    {
        base.DisplayStartingMessage();
        GetRandomPrompt();
    }

    public override void DisplayEndingMessage()
    {
        base.DisplayEndingMessage();
        Console.WriteLine($"You listed {_count} items.");
    }

    public void Run()
    {
        DisplayStartingMessage();
        List<string> itemList = GetListFromUser();
        _count = itemList.Count;
        DisplayEndingMessage();
    }

    private void GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        Console.WriteLine($"Prompt: {_prompts[index]}");
        Console.WriteLine("Get ready to list...");
        ShowCountdown(5);
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        Console.WriteLine("Start listing items:");
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
                items.Add(item);
        }
        return items;
    }
}