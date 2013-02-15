using System;
using System.Collections.Generic;

class Excercise20ExtractPalindromes
{
    static void Main()
    {
        Console.WriteLine("Enter polindroms and/or text: ");
        string input = Console.ReadLine();
        string[] words = input.Split(' ');
        List<string> palindromes = new List<string>();
        foreach (string word in words)
        {
            int counter = 0;
            for (int i = 0; i < word.Length/2; i++)
            {
                if (word[i] == word[word.Length - 1 - i])
                {
                    counter++;
                    if (counter == word.Length / 2)
                    {
                        palindromes.Add(word);
                    }
                }
            }
        }
        foreach (string word in palindromes)
        {
            Console.WriteLine("\""+word+"\"");
        }
    }
}
