using System;

class Excercise3BracketUsage
{
    static void Main()
    {
        Console.Write("Enter your expression: ");
        string expression = Console.ReadLine();
        int counter1 = 0, counter2 = 0;
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                counter1++;
            }
            if (expression[i] == ')')
            {
                counter2++;
            }
            if (counter2 > counter1)
            {
                break;
            }
        }
        if (counter1 == counter2)
        {
            Console.WriteLine("The brackets are put correctly.");
        }
        else
        {
            Console.WriteLine("The brackets are not put correctly");
        }
    }
}

