using System;
using System.Globalization;

class Excercise17Print6Hour30MinLater
{
    static void Main(string[] args)
    {
        Console.WriteLine(
@"Enter the information in this format:
dd.MM.yyyy HH:mm:ss");
        string date = Console.ReadLine();

        DateTime dateNow = DateTime.ParseExact(date, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

        dateNow = dateNow.AddHours(6.5);

        Console.WriteLine("{0} {1}", dateNow.ToString("dddd", new CultureInfo("bg-BG")), dateNow);
    }
}

