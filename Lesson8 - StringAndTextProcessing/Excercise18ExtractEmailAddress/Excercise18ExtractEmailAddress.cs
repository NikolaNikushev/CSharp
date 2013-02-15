using System;
using System.Text.RegularExpressions;

class Excercise18ExtractEmailAddress
{
    static void Main()
    {
        Console.Write("Enter the email addresses: ");
        string emails = Console.ReadLine();

        foreach (var item in Regex.Matches(emails, @"\w+@\w+\.\w+"))
            Console.WriteLine(item);
    }
}
