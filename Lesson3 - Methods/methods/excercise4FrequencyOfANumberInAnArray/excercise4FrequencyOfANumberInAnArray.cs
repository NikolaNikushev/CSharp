using System;

class Excercise4FrequencyOfANumberInAnArray
{
    static int frequencyOfANumber(double number, double numberToSearch)
    {
        if (number == numberToSearch)
        {
            return 1;
        }
        return 0;
    }
    static void Main()
    {
        double result = 0;
        Console.Write("Enter array length: ");
        int length = int.Parse(Console.ReadLine());
        Console.Write("The number to search = ");
        double numberToSearch = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the array's numbers:(double) ");
        double[] array = new double[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write("number {0} = ", i+1);
            array[i] = double.Parse(Console.ReadLine());
            result += frequencyOfANumber(array[i], numberToSearch);
        }
        string multiple=" " + numberToSearch;
        if (result > 1 || result==0)
        {
            multiple = "s " + numberToSearch;
        }
        Console.WriteLine(result+" time{0} is entered.", multiple);
    }
}
