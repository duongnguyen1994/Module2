using System;

namespace NextDay.Service
{
    public class NextDayCalculator
    {
        public string NextDay(int day, int month, int year)
        {
            int nextMonth = month + 1;
            if (IsLastDayOfYear(day, month))
            {
                return $"1/1/{year + 1}";
            }
            else
            {
                if (IsLastDayOfFebuaryInLeapYear(day, month, year))
                {
                    return $"1/{nextMonth}/{year}";
                }
                else
                {
                    if (IsFebuary(month) && day == 28)
                    {
                        return $"1/{nextMonth}/{year}";
                    }
                    else
                    {
                        if (IsMonth31Days(month) && day == 31)
                        {
                            return $"1/{nextMonth}/{year}";
                        }
                        else if (day == 30)
                        {
                            return $"1/{nextMonth}/{year}";
                        }
                        return $"{day + 1}/{month}/{year}";
                    }
                }
            }
        }
        public bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                    else
                        return false;
                }
                else
                    return true;
            }
            else
                return false;
        }
        public bool IsMonth31Days(int month)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return true;
            }
            return false;
        }
        public bool IsFebuary(int month)
        {
            if (month == 2)
            {
                return true;
            }
            return false;
        }
        public bool IsLastDayOfYear(int day, int month)
        {
            if (day == 31 && month == 12)
            {
                return true;
            }
            return false;
        }
        public bool IsLastDayOfFebuaryInLeapYear(int day, int month, int year)
        {
            if (IsLeapYear(year) && day == 29 && month == 2)
            {
                return true;
            }
            return false;
        }
    }
}
