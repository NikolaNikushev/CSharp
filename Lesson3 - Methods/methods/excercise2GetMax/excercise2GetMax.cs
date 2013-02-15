using System;

class Excercise2GetMax
{
    static string GetMax(int integerOne, int integerTwo, int integerThree)
    {
        if (integerOne > integerTwo)
        {
            if (integerOne > integerThree)
            {
                return "The 1-st one is the biggest, " + integerOne;
            }
        }
        if (integerTwo > integerThree)
        {
            if (integerTwo > integerOne)
            {
                return "The 2-nd one is the biggest, " + integerTwo;
            }
        }
        if (integerThree > integerTwo)
        {
            if (integerThree > integerOne)
            {
                return "The 3-rd one is the biggest, " + integerThree;
            }
        }
        if (integerOne == integerTwo && integerTwo == integerThree)
        {
            return "They are all equal, " + integerThree;
        }
        return "Error";
    }
    static void Main()
    {
        Console.Write("Enter 1-st integer: ");
        int integerOne = int.Parse(Console.ReadLine());
        Console.Write("Enter 2-nd integer: ");
        int integerTwo = int.Parse(Console.ReadLine());
        Console.Write("Enter 3-rd integer: ");
        int integerThree = int.Parse(Console.ReadLine());
        Console.WriteLine(GetMax(integerOne, integerTwo, integerThree));
    }
}