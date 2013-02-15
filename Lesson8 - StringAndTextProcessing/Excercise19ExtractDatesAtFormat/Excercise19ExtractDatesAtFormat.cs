using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Excercise19ExtractDatesAtFormat
{
    class Excercise19ExtractDatesAtFormat
    {
        static void Main()
        {
            Console.Write("Enter the dates: ");
            string dates = Console.ReadLine();
            DateTime date;
            foreach (Match item in Regex.Matches(dates, @"\d{2}.\d{2}.\d{4}"))
            {
                if (DateTime.TryParseExact(item.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
                }
            }
        }
    }
}

