using System;

class Excercise1RootOfNumber
{
    static void Main(string[] args)
    {
        Console.Write("int = ");
        string input = Console.ReadLine();
        try
        {
            int.Parse(input);
            if (int.Parse(input) < 0) throw new FormatException();
            Console.WriteLine("It's root = {0}", Math.Sqrt(int.Parse(input)));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid integer number!");
        }
        finally
        {
            Console.WriteLine("Good bye.");
        }
    }
}