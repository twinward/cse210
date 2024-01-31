using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture1 = new Scripture();

        foreach (Word word in scripture1._words)
        {
            Console.Write($"{word._text} ");
        }
    }
}