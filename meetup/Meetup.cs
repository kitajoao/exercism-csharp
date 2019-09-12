using System;

public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    private int _year, _month;

    public Meetup(int month, int year)
    {
        this._year = year;
        this._month = month;
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        switch (schedule)
        {
            case Schedule.Teenth:
                return DayTeenth(dayOfWeek, schedule);
            case Schedule.First:
                return DayFirst(dayOfWeek, schedule);
            case Schedule.Second:
                return DaySecond(dayOfWeek, schedule);
            case Schedule.Third:
                return DayThird(dayOfWeek, schedule);
             case Schedule.Fourth:
                return DayFourth(dayOfWeek, schedule);
            case Schedule.Last:            
                return DayLast(dayOfWeek, schedule);
            default:
                return DateTime.MinValue;
        }
    }

    private DateTime DayTeenth(DayOfWeek dayOfWeek, Schedule schedule)
    {
        var firstDayOfInteraction =
            new DateTime(this._year, this._month, 19);

        for (var i = 0; i <= 9; i++)
        {
            var currentDay = firstDayOfInteraction.AddDays(i * -1);
            if (currentDay.DayOfWeek == dayOfWeek)
                return currentDay;
        }

        return DateTime.MinValue;
    }

    private DateTime DayFirst(DayOfWeek dayOfWeek, Schedule schedule)
    {
        var firstDayOfInteraction =
            new DateTime(this._year, this._month, 1);

        for (var i = 0; i <= 30; i++)
        {
            var currentDay = firstDayOfInteraction.AddDays(i);
            if (currentDay.DayOfWeek == dayOfWeek)
                return currentDay;
        }

        return DateTime.MinValue;
    }
    private DateTime DaySecond(DayOfWeek dayOfWeek, Schedule schedule)
    {
        var firstDayOfInteraction =
            new DateTime(this._year, this._month, 14);

        for (var i = 0; i <= 7; i++)
        {
            var currentDay = firstDayOfInteraction.AddDays(i * -1);
            if (currentDay.DayOfWeek == dayOfWeek)
                return currentDay;
        }

        return DateTime.MinValue;
    }
    private DateTime DayThird(DayOfWeek dayOfWeek, Schedule schedule)
    {
        var firstDayOfInteraction =
            new DateTime(this._year, this._month, 21);

        for (var i = 0; i <= 7; i++)
        {
            var currentDay = firstDayOfInteraction.AddDays(i * -1);
            if (currentDay.DayOfWeek == dayOfWeek)
                return currentDay;
        }

        return DateTime.MinValue;
    }
    private DateTime DayFourth(DayOfWeek dayOfWeek, Schedule schedule)
    {
        var firstDayOfInteraction =
            new DateTime(this._year, this._month, 28);

        for (var i = 0; i <= 7; i++)
        {
            var currentDay = firstDayOfInteraction.AddDays(i * -1);
            if (currentDay.DayOfWeek == dayOfWeek)
                return currentDay;
        }

        return DateTime.MinValue;
    }
    private DateTime DayLast(DayOfWeek dayOfWeek, Schedule schedule)
    {
        var firstDayOfInteraction =
            new DateTime(this._year, this._month, 1);

        for (var i = 1; i <= 7; i++)
        {
            var currentDay = firstDayOfInteraction.AddMonths(1).AddDays(-i);
            if (currentDay.DayOfWeek == dayOfWeek)
                return currentDay;
        }
        return DateTime.MinValue;
    }
}