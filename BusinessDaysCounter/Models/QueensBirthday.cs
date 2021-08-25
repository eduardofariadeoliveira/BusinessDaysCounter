using System;
using System.Collections.Generic;
using System.Text;

namespace CodeAssesmentDates.Models
{
    class QueensBirthday : IHoliday
    {
        public DateTime HolidayDate(int year)
        {
            int june = (int)Month.June;
            int daysInJun = DateTime.DaysInMonth(year, june);
            int timesFound = 0;

            for (var i = 1; i <= daysInJun; i++)
            {
                if ((new DateTime(year, june, i).DayOfWeek == DayOfWeek.Monday))
                    timesFound++;

                if (timesFound == 2)
                    return new DateTime(year, june, i);
            }

            return DateTime.MinValue;
        }
    }
}
