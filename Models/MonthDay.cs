using System;
namespace Chapter7
{
    public class MonthDay
    {
        public int Day { get; private set; }
        public int Month { get; private set; }
        public MonthDay(int month, int day)
        {
            this.Month = month;
            this.Day = day;
        }
    }
}
