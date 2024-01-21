using System;

public class Journal
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