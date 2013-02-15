using System;
using System.IO;

class Excercise7ReplaceStartWithFinish
{
    static void Main()
    {
        Console.WriteLine("Input text to modify(type end to stop inputing): ");
        StreamWriter writeText = new StreamWriter("text.txt");
        using (writeText)
        {
            string input = Console.ReadLine();
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
                text = readText.ReadLine();
                while (text != null)
                {
                    text=text.Replace("start", "finish");
                    finalResult.WriteLine(text);
                    text = readText.ReadLine();
                }
            }
                
        }
    }
}