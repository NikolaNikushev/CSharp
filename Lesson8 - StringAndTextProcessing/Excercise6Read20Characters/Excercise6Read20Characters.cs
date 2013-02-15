using System;

class Excercise6Read20Characters
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string input = Console.ReadLine();
        if (input.Length > 20)
        {
            Console.WriteLine("Length of string should be no more than 20 characters, Retry: ");
            do
            {
                input = Console.ReadLine();
            } while (input.Length > 20);
        }
        if (input.Length < 20)
        {
            for (int i = input.Length; i < 20; i++)
            {
                input += "*";
            }
            Console.WriteLine(input);
        }
        else
        {
            Console.WriteLine(input);
        }
    }
}
