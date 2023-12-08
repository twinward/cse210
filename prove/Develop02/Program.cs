/* This code won't work in this file for some reason, but I've tested it in another file and it works fine. I think my program is bugging. */

using System;
using System.Collections.Generic;
using System.IO;

class Entry
{
    public DateTime Date { get; set; }
    public string EntryPrompt { get; set; }
    public string Response { get; set; }

    public void Display()
    {
        Console.WriteLine($"{Date}\t{EntryPrompt}");
        Console.WriteLine($"\t\t{Response}");
    }
}

class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(DateTime date, string entryPrompt, string response)
    {
        Entry entry = new Entry
        {
            Date = date,
            EntryPrompt = entryPrompt,
            Response = response
        };
        entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter file = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                file.WriteLine($"{entry.Date}");
                file.WriteLine($"{entry.EntryPrompt}");
                file.WriteLine($"{entry.Response}\n");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();

        string[] fileData = File.ReadAllText(filename).Split(new[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string data in fileData)
        {
            string[] lines = data.Split('\n');
            if (lines.Length >= 3)
            {
                DateTime date;
                if (DateTime.TryParse(lines[0].Trim(), out date))
                {
                    string entryPrompt = lines[1].Trim();
                    string response = lines[2].Trim();
                    AddEntry(date, entryPrompt, response);
                }
            }
        }
    }
}

class PromptGenerator
{
    private List<string> morningPrompts;
    private List<string> eveningPrompts;
    private List<string> thoughtfulPrompts;
    private Random random;

    public PromptGenerator()
    {
        random = new Random();

        morningPrompts = new List<string>
        {
            "What was the most memorable dream I had last night?",
            "What’s on my mind this morning?",
            "What am I looking forward to today?",
            // Add more morning prompts here
        };

        eveningPrompts = new List<string>
        {
            "Who did I interact with today? What were those interactions like?",
            "What were the most important events today?",
            "What was the best thing that happened today?",
            // Add more evening prompts here
        };

        thoughtfulPrompts = new List<string>
        {
            "What is a current problem or challenge I am facing? What do I need to do to overcome it?",
            "How can I creatively express gratitude, love, or appreciation for someone in my life?",
            "What goals can I set for myself this week? How can I achieve them?",
            // Add more thoughtful prompts here
        };
    }

    public string GetRandomPrompt(int category)
    {
        List<string> selectedPrompts = new List<string>();
        switch (category)
        {
            case 1:
                selectedPrompts = morningPrompts;
                break;
            case 2:
                selectedPrompts = eveningPrompts;
                break;
            case 3:
                selectedPrompts = thoughtfulPrompts;
                break;
            default:
                break;
        }

        return selectedPrompts.Count > 0 ? selectedPrompts[random.Next(selectedPrompts.Count)] : "";
    }
}

class Program
{
    static void Menu(Journal journal, PromptGenerator promptGenerator)
    {
        while (true)
        {
            Console.WriteLine("Journal Menu:\n  1. Write\n  2. Display\n  3. Load\n  4. Save\n  5. Quit");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Journal Categories:\n  1. Morning\n  2. Evening\n  3. Thoughtful");
                int category;
                if (int.TryParse(Console.ReadLine(), out category) && category >= 1 && category <= 3)
                {
                    string entryPrompt = promptGenerator.GetRandomPrompt(category);
                    Console.WriteLine(entryPrompt);
                    string response = Console.ReadLine();
                    DateTime date = DateTime.Today;
                    journal.AddEntry(date, entryPrompt, response);
                }
                else
                {
                    Console.WriteLine("Invalid category. Please choose between 1, 2, or 3.");
                }
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Enter the filename to load from: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.WriteLine("Enter the filename to save to: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
            }
        }
    }

    static void Main()
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        Menu(journal, promptGenerator);
    }
}