using System;

class Excercise1printHelloUser
{
    static string printUserName(string user)
    {
        string result="Hello, " + user + "!";
        return result;
    }
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Clear();
        Console.WriteLine(printUserName(name));
    }
}
