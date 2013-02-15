using System;

class Excercise5CalculateWorkdaysToDate
{
    static DateTime[] holidays = { new DateTime(2012, 01, 01), new DateTime(2012, 05, 06), new DateTime(2012, 05, 24), new DateTime(2012, 09, 22), new DateTime(2012, 12, 24), new DateTime(2012, 12, 25), new DateTime(2012, 12, 30), new DateTime(2012, 12, 31),
                                  new DateTime(2013, 01, 01), new DateTime(2013, 05, 06), new DateTime(2013, 05, 24), new DateTime(2013, 09, 22), new DateTime(2012, 12, 24), new DateTime(2013, 12, 25), new DateTime(2013, 12, 30), new DateTime(2013, 12, 31)
                              };
    static int RemoveDays(DateTime start, DateTime end, int result)
    {
        foreach (DateTime holiday in holidays)
        {
            if (start <= holiday && holiday <= end && !(holiday.DayOfWeek == DayOfWeek.Saturday || holiday.DayOfWeek == DayOfWeek.Sunday))
            {
                result--;
            }
        }
        return result;
    }

    static void RemoveWeekendDays(ref DateTime start, ref DateTime end)
    {
        if (start.DayOfWeek == DayOfWeek.Saturday) start = start.AddDays(2);
        if (start.DayOfWeek == DayOfWeek.Sunday) start = start.AddDays(1);
        if (end.DayOfWeek == DayOfWeek.Saturday) end = end.AddDays(-1);
        if (end.DayOfWeek == DayOfWeek.Sunday) end = end.AddDays(-2);
    }

    static int GetWorkDays(DateTime start, DateTime end)
    {
        if (end < start) return GetWorkDays(end, start);
        RemoveWeekendDays(ref start, ref end);
        int offset = (int)(end - start).TotalDays + 1;
        int result = offset / 7 * 5 + offset % 7; 
        return RemoveDays(start, end, Math.Max(result, 0));
    }

    static void Main()
    {
        
        Console.Write("Enter Day: ");
        int day = int.Parse(Console.ReadLine());
        while (day > 31) day = int.Parse(Console.ReadLine());
        Console.Write("Enter Month: ");
        int month = int.Parse(Console.ReadLine());
        while (month > 12) month = int.Parse(Console.ReadLine());
        Console.Write("Enter Year: ");
        int year = int.Parse(Console.ReadLine());
        while (month == 2 && day > 27 && year % 4 == 0) day = int.Parse(Console.ReadLine());
        while (month % 2 == 0 && month != 8 && day > 30) day = int.Parse(Console.ReadLine());
        if (new DateTime(year, month, day) > DateTime.Now)
        {
            Console.WriteLine(GetWorkDays(DateTime.Now, new DateTime(year, month, day)));
        }
        else
        {
            Console.WriteLine(GetWorkDays(new DateTime(year, month, day), DateTime.Now));
        }
    }
}