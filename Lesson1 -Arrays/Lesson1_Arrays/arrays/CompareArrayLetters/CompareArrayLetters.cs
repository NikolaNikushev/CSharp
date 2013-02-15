//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareArrayLetters
{
    static void Main()
    {
        Console.WriteLine("Amount = ");
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];
        string[] array2 = new string[n];
        for (int i = 0; i < 5; i++)
        {
            array[i] = Console.ReadLine();
            array[i] = array[i];
        }
        for (int i = 0; i < 5; i++)
        {
            array2[i] = Console.ReadLine();
        }
        for (int i = 0; i < n; i++)
        {
            if (array[i] == array2[i])
            {
                Console.WriteLine("The element {0} is the same in both arrays at {1} position", array[i], i);
            }
        }
    }
}

