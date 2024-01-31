using System;
using System.Collections.Generic;

class Scripture
{
    // public Reference _reference;
    public List<Word> _words;

    public Scripture()
    {
        _words = new List<Word>();
            
        string vsText = "Hello World C#!";
        string[] wordsArray = vsText.Split(new char[] {' ', '\n'}, StringSplitOptions.RemoveEmptyEntries);

        foreach(string wordInArray in wordsArray)
        {
            Word word = new Word(wordInArray);
            _words.Add(word);
        }

    // foreach (Word _word in _words)
    // {
    //     Console.Write($"{_word._text} ");
    // }
    }
}