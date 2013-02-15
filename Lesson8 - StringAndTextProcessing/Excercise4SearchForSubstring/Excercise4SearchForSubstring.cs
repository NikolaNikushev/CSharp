using System;

class Excercise4SearchForSubstring
{
    static void Main()
    {
        Console.Write("Enter your text please: ");
        string text = Console.ReadLine();
        Console.Write("The substring is: ");
        string substring = Console.ReadLine();
        int counter, wordCounter = 0;

        text = text.ToLower();
        substring = substring.ToLower();

        for (int i = 0; i <= text.Length - 1; i++)
        {
            if (i == text.Length - substring.Length - 1)
            {
                break;
            }
            if (text[i] == substring[0])
            {
                counter = 0;
                for (int j = 0; j <= substring.Length - 1; j++)
                {
                    if (text[i + j] == substring[j])
                    {
                        counter++;
                    }
                    if (counter == substring.Length)
                    {
                        wordCounter++;
                    }
                }
            }
        }
        Console.WriteLine("The substring {0} was found {1} times.", substring, wordCounter);
    }
}

