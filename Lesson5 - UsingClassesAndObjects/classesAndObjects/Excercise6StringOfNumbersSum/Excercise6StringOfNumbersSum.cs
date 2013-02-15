using System;
using System.Collections.Generic;

class Excercise6StringOfNumbersSum
{
    static void Main()
    {
    enterSequence:
        Console.Write("Enter sequence: ");
        int counter = 0;
        List<string> numbers = new List<string>();
        string sequence = Console.ReadLine();
        sequence += " ";
        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] == ' ' || (sequence[i] <= '9' && sequence[i] >= '0'))
            {
                if (sequence[i] == ' ')
                {
                    numbers.Add(sequence.Substring(i - counter, counter));
                    counter = 0;
                }
            }
            else
            {
                Console.WriteLine("You have entered a sequence, containing invalid symbols. It should contain spaces and numbers");
                goto enterSequence;
            }
            counter++;
        }
        int result = 0;
        foreach (string number in numbers)
        {
            result += int.Parse(number);
        }
        Console.WriteLine("Sum of these integers = {0}",result);
    }
}
