using System;
using System.IO;

class Excercise8ReplaceAnythingWithAnything
{
    static void Main()
    {
        Console.WriteLine("Replace what: ");
        string replace = Console.ReadLine();
        Console.WriteLine("Replace with what: ");
        string replaceWith = Console.ReadLine();
        Console.WriteLine("Input text to modify(type end to stop inputing): ");
        StreamWriter writeText = new StreamWriter("text.txt");
        using (writeText)
        {
            string input=Console.ReadLine();
            while (input != "end")
            {
                input = Console.ReadLine();
                writeText.Write(input);
            } 
        }
        Console.WriteLine("Reading...");
        Console.WriteLine("Writing result...");
        StreamReader readText = new StreamReader("text.txt");
        StreamWriter finalResult = new StreamWriter("finalResult.txt");
        string text = "";
        using (readText)
        {
            using (finalResult)
            {
                text = readText.ReadToEnd();
                while (text != null)
                {
                    text = text.Replace(replace, replaceWith);
                    finalResult.WriteLine(text);
                    text = readText.ReadToEnd();
                }
            }
        }
    }
}
