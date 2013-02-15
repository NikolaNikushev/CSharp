using System;

using System.Text;


class Excercise10StringToUnicode
{
    static void Main()
    {
        Console.WriteLine("Enter string: ");
        string input = Console.ReadLine();
        foreach (var chars in input)
        {
            Console.WriteLine("\\u{0:X4}", (int) chars);
        }

    }
}
