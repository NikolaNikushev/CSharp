using System;
using System.IO;

namespace Excercise1PrintOddLines
{
    class Excercise1PrintOddLines
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
            StreamReader reader = new StreamReader("text.txt");
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = reader.ReadLine();
                }
            }
        }
    }
}
