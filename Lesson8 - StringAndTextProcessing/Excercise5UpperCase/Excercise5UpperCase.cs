using System;
using System.Text.RegularExpressions;

class Excercise5UpperCase
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string input = Console.ReadLine();
        Console.WriteLine(Regex.Replace(input, "<upcase>(.*?)</upcase>", m => m.Groups[1].Value.ToUpper()));
    }
}
