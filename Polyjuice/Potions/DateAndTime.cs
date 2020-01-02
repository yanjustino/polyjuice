using System;
using Polyjuice.Extension;

namespace Polyjuice.Potions
{
    public static class DateAndTime
    {
        public static DateTime DateTime => Date.Add(Time);
        public static int Day => 31.Randomize(1);
        public static int Month => 12.Randomize(1);
        public static int Year => DateTime.Now.Year.Randomize(1900);
        public static int ThisYear => DateTime.Now.Year;
        public static int ThisMonth => DateTime.Now.Month;
        public static int NextFiveYears => DateTime.Now.AddYears(5).Year.Randomize(DateTime.Now.Year);
        public static int NextTenYears => DateTime.Now.AddYears(10).Year.Randomize(DateTime.Now.Year);
        public static int NextFiftyYears => DateTime.Now.AddYears(50).Year.Randomize(DateTime.Now.Year);
        public static int NextOneHundredYears => DateTime.Now.AddYears(100).Year.Randomize(DateTime.Now.Year);
        public static int LastFiveYears => DateTime.Now.Year.Randomize(DateTime.Now.Year - 5);
        public static int LastTenYears => DateTime.Now.Year.Randomize(DateTime.Now.Year - 10);
        public static int LastFiftyYears => DateTime.Now.Year.Randomize(DateTime.Now.Year - 50);
        public static int LastOneHundredYears => DateTime.Now.Year.Randomize(DateTime.Now.Year - 100);
        public static TimeSpan Time => new TimeSpan(24.Randomize(), 60.Randomize(), 60.Randomize());
        public static DayOfWeek DayOfWeek => Date.DayOfWeek;        
        
        
        public static DateTime Date
        {
            get
            {
                var year = Year;
                var month = Month;
                var day = DateTime.DaysInMonth(year, month).Randomize(1);
                
                return new DateTime(year, month, day);
            }            
        }        
        
        public static DateTime Birthday
        {
            get
            {
                var year = LastOneHundredYears;
                var month = Month;
                var day = DateTime.DaysInMonth(year, month).Randomize(1);
                
                return new DateTime(year, month, day);
            }
        }        
    }
}