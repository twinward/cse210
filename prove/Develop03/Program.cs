using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture1 = new Scripture(ref1, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
 
        Console.WriteLine(scripture1.GetDisplayText());
        scripture1.HideRandomWords(5);
    }
}

// Proverbs 3:5-6
// Trust in the Lord with all thine heart; and lean not unto thine own understanding.
// In all thy ways acknowledge him, and he shall direct thy paths.