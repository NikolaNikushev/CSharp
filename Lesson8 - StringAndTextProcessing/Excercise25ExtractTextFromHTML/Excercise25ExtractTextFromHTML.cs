using System;
using System.IO;
using System.Collections.Generic;

class Excercise25ExtractFromHTML
{
    static void Main()
    {
        Console.WriteLine("Input text to modify(type end to stop inputing): ");
        StreamWriter writeText = new StreamWriter("text.xml");
        List<string> lines = new List<string>();
        List<string> linesResult = new List<string>();
        using (writeText)
        {
            string input = "";
            writeText.Write(input);
            while (input != "end")
            {
                input = Console.ReadLine();
                writeText.WriteLine(input);
            }
        }
        Console.WriteLine("Reading...");
        StreamReader reader = new StreamReader("text.xml");
        int count = 0;
        using (reader)
        {
            string line = reader.ReadLine();
            while (line != "end")
            {
                lines.Add(line);
                count++;
                line = reader.ReadLine();
            }
        }
        Console.WriteLine("Writing...");
        StreamWriter writer = new StreamWriter("textResult.xml");
        using (writer)
        {
            for (int j = 0; j < count; j++)
            {
                linesResult.Add("");
                for (int i = 0; i < lines[j].Length; i++)
                {
                    if (lines[j][i] == '>')
                    {
                        while (lines[j][i] != null && lines[j][i] != '<' && i + 1  < lines[j].Length)
                        {
                            if (lines[j][i] != '>')
                                linesResult[j] += lines[j][i];
                            i++;
                        }
                    }
                }
                writer.WriteLine(linesResult[j]);
            }
        }
    }
}
