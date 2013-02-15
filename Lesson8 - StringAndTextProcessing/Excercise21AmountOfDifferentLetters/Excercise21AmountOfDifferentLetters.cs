using System;
using System.Collections.Generic;

class Excercise21AmountOfDifferentLetters
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();
        int amount=0;
        List<char> letters = new List<char>();
        input = input.ToLower();
        foreach (char character in input)
        {
            if (!(letters.Contains(character)))
            {
                letters.Add(character);
                amount++;
            }
        }
        int[] occurance = new int[amount];
        Array.Clear(occurance, 0, amount);
        foreach (char character in input)
        {
            for (int i = 0; i < amount; i++)
            {
                if(character==letters[i])
                {
                    occurance[i]++;
                    break;
                }
            }
        }
        for (int i = 0; i < amount; i++)
        {
            Console.WriteLine(letters[i] + " - "+ occurance[i]);
        }
        Console.WriteLine("Counting the spaces, and every other element that"+
        " there is. You might want to write in chineese, and limiting the "+
        "search for ONLY english letters would be slightly discriminating :x");
    }
}
