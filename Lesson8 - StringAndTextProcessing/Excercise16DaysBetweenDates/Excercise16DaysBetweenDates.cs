using System;
using System.Globalization;

class Excercise16DaysBetweenDates
{
    static void Main()
    {
        Console.WriteLine(
@"Enter the first date information in this format:
dd.MM.yyyy");
        string date1 = Console.ReadLine();
        Console.WriteLine(
@"Enter the second date information in this format:
dd.MM.yyyy");
        string date2 = Console.ReadLine();

        DateTime dateNow = DateTime.ParseExact(date1, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime dateLater = DateTime.ParseExact(date2, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine( "The day diffarance is: {0} days", (dateLater - dateNow).TotalDays);

    }
}
