using System;
using System.Collections.Generic;

class Excercise22PrintDifferentWords
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();
        int amount = 0;
        input = input.ToLower();
        string[] words = input.Split(' ');
        int[] occurance = new int[words.Length];
        Array.Clear(occurance, 0, amount);
        foreach (string word in words)
        {
            for (int i = 0; i <= words.Length - 1; i++)
            {
                if (word == words[i])
                {
                    occurance[i]++;
                    break;
                }
            }
        }
        for (int i = 0; i < words.Length; i++)
        {
            if (occurance[i] != 0)
            {
                Console.WriteLine(words[i] + " - " + occurance[i]);
            }
           
        }
    }
}
