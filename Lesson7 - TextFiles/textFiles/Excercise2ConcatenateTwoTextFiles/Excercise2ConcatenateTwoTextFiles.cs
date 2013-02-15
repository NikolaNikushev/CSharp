using System;
using System.IO;

class Excercise2ConcatenateTwoTextFiles
{
    static void Main()
    {
        Console.WriteLine("Input text to modify(type end to stop inputing): ");
        StreamWriter writeText1 = new StreamWriter("text1.txt");
        using (writeText1)
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                input = Console.ReadLine();
                writeText1.Write(input);
            }
        }
        Console.WriteLine("Input text to modify(type end to stop inputing): ");
        StreamWriter writeText2 = new StreamWriter("text2.txt");
        using (writeText2)
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                input = Console.ReadLine();
                writeText2.Write(input);
            }
        }
        StreamReader text1 = new StreamReader("text1.txt");
        StreamReader text2 = new StreamReader("text2.txt");
        StreamWriter text3 = new StreamWriter("text3.txt");
        string line1 = " ", line2 = " ";
        while (line1 != null && line2 !=null)
        {
            using (text1)
            {
                line1 = text1.ReadLine();
                string result1 = text1.ReadLine();
                using (text2)
                {
                    line2 = text2.ReadLine();
                    string result2 = text2.ReadLine();
                    using (text3)
                    {
                        text3.WriteLine(result1 + result2);
                    }
                }
            }
        }
        StreamReader text3Read = new StreamReader("text3.txt");
        using(text3Read)
        {
            Console.WriteLine(text3Read.ReadLine());
        }
    }
}