using System;

class Excercise2ReadNumberFromToRange
{
    static int ReadNumber(int start, int end)
    {
        Console.Write("Enter number: ");
        string number = Console.ReadLine();
        try
        {
            int.Parse(number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number entered.");
        }
        if (int.Parse(number) < start || int.Parse(number) > end)
        {
            throw new ArgumentException("test");
        }
        return int.Parse(number);
    }
    static void Main(string[] args)
    {
        Console.Write("Start of range = ");
        string start = Console.ReadLine();
        Console.Write("End of range = ");
        string end = Console.ReadLine();
        try
        {
            int.Parse(start);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid start range!");
        }
        try
        {
            while (int.Parse(end) < int.Parse(start))
            {
                int.Parse(end);
                Console.Write("End range must be < start, : ");
                end = Console.ReadLine();
            }
            for (int i = 0; i < 10; i++)
                Console.Write("Number {0} = {1}\n", i + 1, ReadNumber(int.Parse(start), int.Parse(end)));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid end range!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Number is not withing the ranges!");
        }
    }
}
