using System;
using System.IO;
using System.Collections.Generic;

class Excercise12RemoveForbiddenWords
{
    static void Main()
    {
        Console.WriteLine("Input words(phrases) to remove: ");
        StreamWriter writeWords = new StreamWriter("words.txt");
        List<string> lines = new List<string>();
        List<string> linesResult = new List<string>();
        List<string> forbiddenWords = new List<string>();
        using (writeWords)
        {
            string input = "";
            writeWords.Write(input);
            while (input != "end ")
            {
                input = Console.ReadLine();
                input += " ";
                writeWords.WriteLine(input + "");
            }
        }
        Console.WriteLine("Input text to modify(type end to stop inputing): ");
        StreamWriter writeText = new StreamWriter("text.txt");
        using (writeText)
        {
            string input = "";
            writeText.Write(input);
            while (input != "end ")
            {
                input = Console.ReadLine();
                input += " ";
                writeText.WriteLine(input + "");
            }
        }
        Console.WriteLine("Reading...");
        StreamReader reader = new StreamReader("text.txt");
        int count = 0;
        using (reader)
        {
            string line = reader.ReadLine();
            while (line != "end ")
            {
                lines.Add(line);
                count++;
                line = reader.ReadLine();
            }
        }
        StreamReader readerWords = new StreamReader("words.txt");
        int countWords = 0;
        using (readerWords)
        {
            string line = readerWords.ReadLine();
            while (line != "end ")
            {
                forbiddenWords.Add(line);
                countWords++;
                line = readerWords.ReadLine();
            }
        }
        Console.WriteLine("Writing...");
        StreamWriter writer = new StreamWriter("textResult.txt");
        using (writer)
        {
            for (int j = 0; j < count; j++)
            {
                linesResult.Add("");
                try
                {
                    foreach (string forbidden in forbiddenWords)
                    {
                        lines[j]=lines[j].Replace(forbidden, "");
                    }
                }
                catch(ArgumentException)
                {
                    Console.WriteLine("No words found to delete.");
                }
                linesResult[j] = lines[j];
                writer.WriteLine(linesResult[j]);
            }
        }
    }
}