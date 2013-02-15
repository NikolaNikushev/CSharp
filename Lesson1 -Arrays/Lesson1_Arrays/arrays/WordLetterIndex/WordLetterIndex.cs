using System;

class WordLetterIndex
{
    static void Main()
    {
        Console.WriteLine("All Sizes / Capital / Lower?");
        string answer = Console.ReadLine();
        answer.ToLower();
        if (answer == "all sizes")
        {
            Letters('z', 'A');
        }
        else if (answer == "capital")
        {
            Letters('Z', 'A');
        }
        else if (answer == "lower")
        {
            Letters('z', 'a');
        }
        else
        {
            Console.WriteLine("Not a valid format");
        }
    }
    static void Letters(char n, char k)
    {
        char last = n;
        char start = k;
        char[] array = new char[last - start + 1];

        for (int i = 0; i <= array.Length - 1; i++)
        {
            array[i] = (char)(start + i);
        }

        for (int i = 0; i <= array.Length - 1; i++)
        {
            Console.Write(array[i] + "\t");
        }
        Console.WriteLine();

        string word = Console.ReadLine();
        for (int i = 0; i <= word.Length - 1; i++)
        {
            for (int j = 0; j <= array.Length - 1; j++)
            {
                if (word[i] == array[j])
                {
                    Console.WriteLine("The letter {0} was found at {1} position.", array[j], j);
                }
            }
        }
    }
}

