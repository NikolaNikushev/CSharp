using System;
using System.Collections.Generic;

class Excercise5SortStringsByLength
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many strings do you want to input?");
        int n = int.Parse(Console.ReadLine());
        string[] strings = new string[n];
        int[] stringsLength = new int[n];
        int counter = 0;
        Console.WriteLine("Enter {0} strings: ", n);
        for (int i = 0; i < n; i++)
        {
            strings[i] = Console.ReadLine();
            for (int j = 0; j < strings[i].Length; j++)
            {
                counter++;
            }
            stringsLength[i] = counter;
            counter = 0;
        }
        Array.Sort(stringsLength, strings);
        foreach (string item in strings)
        {
            Console.WriteLine(item);
        }
    }
}
