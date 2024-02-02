using System;
using System.Collections.Generic;
using System.Globalization;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Constructor
    public Scripture(Reference reference, string text)
    {
         _reference = reference;
        _words = new List<Word>();
        string[] wordsArray = text.Split(new char[] {' ', '\n'}, StringSplitOptions.RemoveEmptyEntries);

        foreach(string wordInArray in wordsArray)
        {
            _words.Add(new Word(wordInArray));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        bool _competelyHidden = IsCompletelyHidden();

        while (_competelyHidden != true)
        {
            Console.WriteLine("Press ENTER to hide more words.");
            Console.ReadLine();

            for (int i = 0; i<5; i++)
            {
                int index = random.Next(_words.Count);
                _words[index].Hide();
            }

            Console.WriteLine(GetDisplayText());
        }
    }

    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayText()}";
        foreach (Word word in _words)
        {
            displayText = $"{displayText} {word.GetDisplayText()}";
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        return _words.TrueForAll(word => word.GetIsHidden());
    }
}