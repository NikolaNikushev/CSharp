using System;
using System.Collections.Generic;
using System.IO;

class Excercise6SortTextFile
{
    static void Main()
    {
        List<string> strings = new List<string>();
        Console.WriteLine("input strings to sort: (write 'end' to stop) :");
        StreamWriter writeStrings = new StreamWriter("strings.txt");
        int counter = 0;
        using (writeStrings)
        {
            do
            {
                strings.Add(Console.ReadLine());
                writeStrings.WriteLine(strings[counter]);
                counter++;
            } while (strings[counter - 1].ToLower() != "end");
        }
        counter = 0;
        Console.WriteLine("Reading...");
        StreamReader readStrings = new StreamReader("strings.txt");
        List<string> inportStrings = new List<string>();
        using (readStrings)
        {
            string line = readStrings.ReadLine();
            while (line != "end")
            {
                inportStrings.Add(line);
                counter++;
                line = readStrings.ReadLine();
            }
        }
        Console.WriteLine("Writing sorted...");
        StreamWriter finalResult = new StreamWriter("finalResult.txt");
        using (finalResult)
        {
            inportStrings.Sort();
            for (int i = 0; i < counter; i++)
            {
                finalResult.WriteLine(inportStrings[i]);
            }
        }
    }
}
