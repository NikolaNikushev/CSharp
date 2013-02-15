using System;
using System.IO;
using System.Collections.Generic;

class Excercise13OccurencesOfWords
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input words(phrases) to look for: ");
        StreamWriter writeWords = new StreamWriter("words.txt");
        List<string> lines = new List<string>();
        List<string> linesCopy = new List<string>();
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
                linesCopy.Add(line);
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
                countWords++;
                line = readerWords.ReadLine();
            }
        }
        string[] wordsToSearch = new string[countWords];
        int[] wordsToSearchCount = new int[countWords];
        countWords = 0;
        StreamReader readerWords1 = new StreamReader("words.txt");
        using (readerWords1)
        {
            string line = readerWords1.ReadLine();
            while (line != "end ")
            {
                wordsToSearch[countWords] = line;
                countWords++;
                line = readerWords1.ReadLine();
            }
        }
        Console.WriteLine("Writing...");
        StreamWriter writer = new StreamWriter("textResult.txt");
        int counter = 0;
        using (writer)
        {
            for (int j = 0; j < countWords; j++)
            {
                string word=wordsToSearch[j];
                try
                {
                    counter = 0;
                    for (int i = 0; i < count; i++)
                    {
                        lines[i] = linesCopy[i];
                        while (lines[i].LastIndexOf(word) > -1)
                        {
                            // DONT ASK ME HOW I GOT TO THIS CODE!
                            // JUST DONT ASK! xD
                            // I hope you can udnderstand Something of my code :D
                            // Time is preventing me from descriptions :/
                            counter++;
                            lines[i] =
                            lines[i].Substring(lines[i].IndexOf(word), word.Length)
                            .Replace(word, "") + lines[i].Substring(lines[i].IndexOf(word) + word.Length);
                        }
                        wordsToSearchCount[j] = counter;
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Indexing problem. Out of bounds.");
                }
            }
            Array.Sort(wordsToSearchCount, wordsToSearch);
            for (int j = countWords-1; j >= 0; j--)
            {
                writer.WriteLine(wordsToSearch[j] + " - " + wordsToSearchCount[j]);
                Console.WriteLine(wordsToSearch[j] + " - " + wordsToSearchCount[j]);
            }
        }
    }
}
