using System;

class Excercise7ReverseDigits
{
    static string reverseNumbers(string number)
    {
        string result="";
        for (int i =  number.Length-1; i > 0; i--)
        {
            result += number[i];
        }
        return result;
    }
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        decimal number = decimal.Parse(Console.ReadLine());
        string stringNumber=Convert.ToString(number);
        Console.WriteLine(reverseNumbers(stringNumber));
    }
}
