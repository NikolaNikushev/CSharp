using System;
using System.IO;
using System.Collections.Generic;

class Excercise11RemoveWordsWithTextPrefix
{
    static void Main()
    {
        Console.WriteLine("Input text to modify(type end to stop inputing): ");
        StreamWriter writeText = new StreamWriter("text.txt");
        List<string> lines = new List<string>();
        List<string> linesResult = new List<string>();
        using (writeText)
        {
            string input = "";
            writeText.Write(input);
            while (input != "end ")
            {
                input = Console.ReadLine();
                input += " ";
                writeText.WriteLine(input+ "");
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
        Console.WriteLine("Writing...");
        StreamWriter writer = new StreamWriter("textResult.txt");
        using (writer)
        {
            for (int j = 0; j < count; j++)
            {
                linesResult.Add("");
                int find = lines[j].IndexOf("text");
                int end = lines[j].IndexOf(" ", find);
                if (end > -1 && find>-1)
                {
                    string delete = "";
                    for (int i = find; i < end; i++)
                    {
                        delete += lines[j][i];
                    }
                    lines[j] = lines[j].Replace(delete, "");
                    linesResult[j] = lines[j];
                    while (find > -1)
                    {
                        find = lines[j].IndexOf("text");
                        if (find > -1)
                        {
                            end = lines[j].IndexOf(" ", find);
                        }
                        if (end > -1 && find >-1)
                        {
                            delete = "";
                            for (int i = find; i < end; i++)
                            {
                                delete += lines[j][i];
                            }
                            lines[j] = lines[j].Replace(delete, "");
                            linesResult[j] = lines[j];
                        }
                    }
                }
                writer.WriteLine(linesResult[j]);
            }
        }
    }
}
