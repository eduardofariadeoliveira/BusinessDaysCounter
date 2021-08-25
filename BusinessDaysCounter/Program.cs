using System;
using CodeAssesmentDates.Services;

namespace CodeAssesmentDates
{
    class Program
    {
        static void Main(string[] args)
        {

            DateService dateService = new DateService();

            Console.WriteLine("*******************************");
            Console.WriteLine("WELCOME TO BUSINESS DAY COUNTER");
            Console.WriteLine("*******************************");

            do
            {
                Console.WriteLine("Type Exit to leave");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("");

                Console.WriteLine("Date From (dd/mm/yyy):");
                string dateFromStr = ReadKey();
                DateTime dateFrom;

                if (!DateTime.TryParse(dateFromStr, out dateFrom))
                {
                    Console.WriteLine("Invalid date. Let's start from the beggining");
                    Console.WriteLine("-------------------------------");
                    continue;
                }

                Console.WriteLine("Date To (dd/mm/yyy):");
                string dateToStr = ReadKey();
                DateTime dateTo;

                if (!DateTime.TryParse(dateToStr, out dateTo))
                {
                    Console.WriteLine("Invalid date. Let's start from the beggining");
                    Console.WriteLine("-------------------------------");
                    continue;
                }

                if (dateFrom > dateTo)
                {
                    Console.WriteLine("Date To must be after date From");
                }

                double days = dateService.CountWeekdaysBetweenTwoDates(dateFrom, dateTo);
                Console.WriteLine(string.Format("There are {0} business day(s)",days));
                Console.WriteLine("-------------------------------");

            } while (true);
        }

        private static string ReadKey()
        {
            string input = Console.ReadLine();
            if (input.ToLower().Equals("exit"))
                Environment.Exit(0);

            return input;
        }
    }
}
