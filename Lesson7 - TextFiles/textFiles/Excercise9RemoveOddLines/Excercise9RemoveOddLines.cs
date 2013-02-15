using System;
using System.IO;
using System.Collections.Generic;

class Excercise9RemoveOddLines
{
    static void Main()
    {
        Console.WriteLine("Input text to modify(type end to stop inputing): ");
        StreamWriter writeText = new StreamWriter("DeleteME.txt");
        using (writeText)
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                input = Console.ReadLine();
                writeText.Write(input);
            }
        }
        StreamReader textFile = new StreamReader("DeleteME.txt");
        List<string> strings = new List<string>();
        using (textFile)
        {
            string line = textFile.ReadLine();
            while (line != null)
            {
                strings.Add(line);
                line = textFile.ReadLine();
            }
        }
        StreamWriter writeFile = new StreamWriter("DeleteME.txt");
        using (writeFile)
        {
            int counter = 0;
            foreach (string item in strings)
            {
                if (counter % 2 == 1)
                {
                    writeFile.WriteLine(item);
                }
                counter++;
            }
        }
    }
}