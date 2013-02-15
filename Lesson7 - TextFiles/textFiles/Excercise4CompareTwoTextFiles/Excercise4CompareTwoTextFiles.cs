using System;
using System.IO;

class Excercise4CompareTwoTextFiles
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
        StreamReader reader1 = new StreamReader("testResult.txt");
        using (reader)
        {
            using (reader1)
            {
                int lineNumber = 0;
                string line1 = reader.ReadLine();
                string line2 = reader1.ReadLine();
                while (line1 != null)
                {
                    lineNumber++;
                    if (line1 == line2) Console.WriteLine(lineNumber);
                    line1 = reader.ReadLine();
                    line2 = reader1.ReadLine();
                }
            }
        } 
    }
}
