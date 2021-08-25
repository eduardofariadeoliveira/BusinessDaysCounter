using System;
using System.Collections.Generic;
using System.Linq;
using CodeAssesmentDates.Models;

namespace CodeAssesmentDates.Services
{
    public class DateService
    {

        public double CountWeekdaysBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
        {
            return CountWeekdaysBetweenTwoDates(dateFrom, dateTo, null);
        }

        public double CountWeekdaysBetweenTwoDates(DateTime dateFrom, DateTime dateTo, List<DateTime> holidayList)
        {
            int count = 0;
            DateTime localDate = dateFrom;

            do
            {
                localDate = localDate.AddDays(1);

                if (!(localDate.DayOfWeek >= DayOfWeek.Monday && localDate.DayOfWeek <= DayOfWeek.Friday))
                    continue;

                if (holidayList != null && holidayList.Contains(localDate))
                    continue;

                if (IsDynamicHoliday(localDate))
                    continue;

                count++;


            } while (localDate < dateTo.AddDays(-1));

            return count;
        }

        private bool IsDynamicHoliday(DateTime compareDate)
        {
            var interfaceType = typeof(IHoliday);
            var allClassesHolidays = AppDomain.CurrentDomain.GetAssemblies()
              .SelectMany(x => x.GetTypes())
              .Where(x => interfaceType.IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
              .Select(x => Activator.CreateInstance(x));

            DateTime holidayDate = DateTime.MinValue;
            bool found = false;
            foreach(var localClass in allClassesHolidays)
            {
                holidayDate = ((IHoliday)localClass).HolidayDate(compareDate.Year);
                if((compareDate == holidayDate))
                {
                    found = true;
                    break;
                }
            }

            return found;
        }
    }
}
