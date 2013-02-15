using System;
using System.IO;

class Excercise3InsertNumberInfrontOfLine
{
    static void Main()
    {
        Console.WriteLine("Input text to modify(type end to stop inputing): ");
        StreamWriter writeText = new StreamWriter("test.txt");
        using (writeText)
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                input = Console.ReadLine();
                writeText.Write(input);
            }
        }
        StreamReader reader = new StreamReader("test.txt");
        StreamWriter writer = new StreamWriter("testResult.txt");
        using (reader)
        {
            using (writer)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine("{0}: {1}", lineNumber, line);
                    string result = lineNumber + ": " + line;
                    line = reader.ReadLine();
                    writer.WriteLine(result);
                }
            }
        } 
    }
}