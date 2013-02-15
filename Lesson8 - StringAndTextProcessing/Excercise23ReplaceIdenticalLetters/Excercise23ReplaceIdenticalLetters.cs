using System;
using System.Collections.Generic;

class Excercise23ReplaceIdenticalLetters
{
    static void Main()
    {
        Console.WriteLine("Enter string:");
        string input = Console.ReadLine();
        int amount = 0;
        List<char> letters = new List<char>();
        for (int i = 0; i < input.Length-1; i++)
        {
            if (input[i] != input[i + 1])
            {
                letters.Add(input[i]);
                amount++;
            }
        }
        if (letters[amount-1] != input[input.Length - 1])
            letters.Add(input[input.Length - 1]);
        Console.WriteLine("The text without any repeating letters looks like:");
        foreach (char character in letters)
        {
            Console.Write(character);
        }
        Console.WriteLine();
    }
}
