using System;

class Excercise2ReverseString
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string input = Console.ReadLine();
        string result = "";
        for (int i = input.Length-1; i >= 0; i--)
        {
            result += input[i];
        }
        Console.WriteLine("Reverse = {0}", result);
    }
}
