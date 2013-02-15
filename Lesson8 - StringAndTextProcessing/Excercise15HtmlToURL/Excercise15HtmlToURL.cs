using System;
using System.Text.RegularExpressions;

class Excercise15HtmlToURL
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string input = Console.ReadLine();
        Console.WriteLine(Regex.Replace(input, "<a href=\"(.*?)\">(.*?)</a>", "[URL=$1] $2 [/URL]"));
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ')')
            {
                Console.WriteLine();
            }
            if (input[i] >= '0' && input[i] <= '9' || input[i] == ',')
            {
                
                Console.Write(input[i]);
            }
        }
    }
}
