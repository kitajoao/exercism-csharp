using System;

public class Clock : IEquatable<Clock>
{
    public Clock(int hours, int minutes)
    {
        Hours = hours;
        Minutes = minutes;
        CheckTimeInInt(hours, minutes);
    }
    public int Hours
    {
        get; private set;
    }
    public int Minutes
    {
        get; private set;
    }
    public Clock Add(int minutesToAdd)
    {
        return new Clock(Hours, Minutes + minutesToAdd);
    }
    public Clock Subtract(int minutesToSubtract)
    {
        return new Clock(Hours, Minutes - minutesToSubtract);
    }
    public void CheckTimeInInt(int hours, int minutes)
    {
        if (minutes >= 60)
        {
            hours = hours + (int)decimal.Floor(minutes / 60);

            minutes = minutes - 60 * (int)decimal.Floor(minutes / 60);

            if (hours >= 24)
            {
                hours = hours - 24 * (int)decimal.Floor(hours / 24);
            }
            else if (hours >= 0 && hours < 24)
            {
                hours = hours - 24 * (int)decimal.Floor((minutes / 60) / 24);
            }
            else
            {
                hours = hours + (24 * (-1) * ((int)decimal.Floor(hours / 24) - 1));
            }
        }
        else if (minutes < 60)
        {
            if (minutes >= 0)
            {
                minutes.Equals(minutes);

                if (hours >= 24)
                {
                    hours = (hours - 24 * (int)decimal.Floor(hours / 24));
                }
                else if (hours < 24 && hours >= 0)
                {
                    hours.Equals(hours);
                }
                else
                {
                    hours = hours + (24 * (-1) * ((int)decimal.Floor(hours / 24) - 1));
                }
            }
            else if (minutes < 0 && minutes > -60)
            {
                hours = hours + ((int)decimal.Floor(minutes / 60) - 1);

                minutes = minutes + (60 * ((-1) * ((int)decimal.Floor(minutes / 60) - 1)));

                if (hours >= 24)
                {
                    hours = hours - (24 * ((int)decimal.Floor(hours / 24) - 1));
                }
                else if (hours < 24 && hours >= 0)
                {
                    hours.Equals(hours);
                }
                else
                {
                    hours = hours + (24 * (-1) * ((int)decimal.Floor(hours / 24) - 1));
                }
            }
            else if (minutes < -60)
            {
                hours = hours + ((int)decimal.Floor(minutes / 60) - 1);

                minutes = minutes + (60 * ((-1) * ((int)decimal.Floor(minutes / 60) - 1)));

                if (hours >= 24)
                {
                    hours = hours - (24 * ((int)decimal.Floor(hours / 24) - 1));
                }
                else if (hours < 24 && hours >= 0)
                {
                    hours.Equals(hours);
                }
                else if (hours % 24 != 0)
                {
                    hours = hours + (24 * (-1) * ((int)decimal.Floor(hours / 24) - 1));
                }
                else if (hours % 24 == 0)
                {
                    hours = hours + (24 * (-1) * ((int)decimal.Floor(hours / 24)));
                }
            }
            else if (minutes == -60)
            {
                hours = hours + (int)decimal.Floor(minutes / 60);

                minutes = minutes + (60 * ((-1) * (int)decimal.Floor(minutes / 60)));

                if (hours >= 24)
                {
                    hours = hours - (24 * ((int)decimal.Floor(hours / 24) - 1));
                }
                else if (hours < 24 && hours >= 0)
                {
                    hours.Equals(hours);
                }
                else
                {
                    hours = hours + (24 * (-1) * ((int)decimal.Floor(hours / 24) - 1));
                }
            }
        }
        Hours = hours;

        Minutes = minutes;
    }
    public Clock ReturnTimeInInt(int hours, int minutes)
    {
        hours = Hours;

        minutes = Minutes;

        CheckTimeInInt(Hours, Minutes);

        return this;
    }
    public override string ToString()
    {
        string hoursInString = Hours.ToString();

        string minutesInString = Minutes.ToString();

        if (Hours < 10)
        {
            hoursInString = hoursInString.PadLeft(2, '0');
        }
        if (Minutes < 10)
        {
            minutesInString = minutesInString.PadLeft(2, '0');
        }
        return hoursInString + ":" + minutesInString;
    }
    public bool Equals(Clock other)
    {
        return other.Hours == this.Hours &&
        other.Minutes == this.Minutes;
    }
}
