/* This code won't work in this file for some reason, but I've tested it in another file and it works fine. I think my program is bugging. */

using System;
using System.Collections.Generic;
using System.IO;


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