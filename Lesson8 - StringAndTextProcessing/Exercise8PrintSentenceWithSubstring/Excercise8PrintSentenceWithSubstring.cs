using System;
using System.Text.RegularExpressions;

class Excercise8PrintSentenceWithSubstring
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string text = Console.ReadLine();
        Console.Write("Enter the substring you will be looking for: ");
        string word = Console.ReadLine();

        foreach (Match sentence in Regex.Matches(text, @"\s*([^\.]*\b" + word + @"\b.*?\.)"))
        Console.WriteLine(sentence.Groups[1]);
    }
}

