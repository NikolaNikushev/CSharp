using System;

class Excercise13ReverseWords
{
    static void Main()
    {
        Console.WriteLine("Enter sentence:");
        string input = Console.ReadLine();
        string manipulate="" ;
        for (int i = 0; i <= input.Length-1; i++)
        {
            manipulate+= input[i];
        }
        string[] words = manipulate.Split(' ');
        Array.Reverse(words);
        manipulate = "";
        foreach (string word in words)
        {
            manipulate += word +" ";
        }
        while (manipulate[0] == ' ')
        {
            manipulate = manipulate.Substring(1);
        }
        while (manipulate[manipulate.Length-1] == ' ')
        {
            manipulate = manipulate.Substring(0,manipulate.Length-1);
        }
        char end=input[input.Length-1];
        char[] endSymbols = { '!', '.', '?', ':', ';' };
        for (int i = 0; i < endSymbols.Length; i++)
        {
            if (end == endSymbols[i]) break;
            else end = '.';
        }
        Console.WriteLine(manipulate+end);
    }
}
