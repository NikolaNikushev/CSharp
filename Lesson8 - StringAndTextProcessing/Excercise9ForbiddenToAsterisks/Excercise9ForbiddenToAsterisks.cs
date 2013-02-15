using System;
using System.Collections.Generic;

class Excercise9ForbiddenToAsterisks
{
    static void Main()
    {
        Console.WriteLine("Enter forbidden words(type \"endNow\" to stop): ");
        List<string> forbiddenWords = new List<string>();
        string input;
        do
        {
            input = Console.ReadLine();
            forbiddenWords.Add(input);
        } while (input != "endNow");
        Console.WriteLine("Enter text: ");
        input = Console.ReadLine();
        forbiddenWords.Remove("endNow");
        foreach (string word in forbiddenWords)
        {
            input = input.Replace(word,new string('*',word.Length));
        }
        Console.WriteLine("The new text looks like:");
        Console.WriteLine(input);
    }
}

