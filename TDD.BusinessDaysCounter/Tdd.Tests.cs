using NUnit.Framework;
using CodeAssesmentDates.Services;
using System;
using System.Collections.Generic;

namespace TDD.CodeAssesmentDates
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_Return1_When_DatesFromWed4August2021ToFri6August2021()
        {
            DateService dateService = new DateService();

            DateTime dateFrom = new DateTime(2021, 8, 4);
            DateTime dateTo = new DateTime(2021, 8, 6);

            double count = dateService.CountWeekdaysBetweenTwoDates(dateFrom, dateTo);
            Assert.AreEqual(1, count);
        }

        [Test]
        public void Should_Return7_When_DatesFromMon2August2021toThu12August2021()
        {
            DateService dateService = new DateService();

            DateTime dateFrom = new DateTime(2021, 8, 2);
            DateTime dateTo = new DateTime(2021, 8, 12);

            double count = dateService.CountWeekdaysBetweenTwoDates(dateFrom, dateTo);
            Assert.AreEqual(7, count);
        }

        [Test]
        public void Should_Return2_When_DatesFromThu1April2021toWed7AprilExceptHolidays()
        {
            DateService dateService = new DateService();

            List<DateTime> holidayList = new List<DateTime>();
            holidayList.Add(new DateTime(2021, 4, 4));
            holidayList.Add(new DateTime(2021, 4, 5));
            holidayList.Add(new DateTime(2021, 4, 25));

            DateTime dateFrom = new DateTime(2021, 4, 1);
            DateTime dateTo = new DateTime(2021, 4, 7);

            double count = dateService.CountWeekdaysBetweenTwoDates(dateFrom, dateTo, holidayList);
            Assert.AreEqual(2, count);
        }

        [Test]
        public void Should_Return2_When_DatesFrom10Jun2021To16Jun2021QueensBirthDay()
        {
            DateService dateService = new DateService();

            DateTime dateFrom = new DateTime(2021, 6, 10);
            DateTime dateTo = new DateTime(2021, 6, 16);

            double count = dateService.CountWeekdaysBetweenTwoDates(dateFrom, dateTo);
            Assert.AreEqual(2, count);
        }
    }
}