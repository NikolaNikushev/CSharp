using System;
using System.Collections.Generic;

class Excercise24SortWordsFrom1Line
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter words:");
        string input = Console.ReadLine();
        input = input.ToLower();
        string[] words = input.Split(' ');
        List<string> singleWords = new List<string>();
        foreach (string word in words)
        {
            if(!(singleWords.Contains(word)))
            {
                singleWords.Add(word);
            }
        }
        singleWords.Sort();
        foreach (string word in singleWords)
        {
            Console.WriteLine(word);
        }
    }
}
