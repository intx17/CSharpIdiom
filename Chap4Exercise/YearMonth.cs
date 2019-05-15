using System;
namespace Chap4Exercise
{
    public class YearMonth
    {
        public YearMonth(int year, int month)
        {
            this.Year = year;
            this.Month = month;
        }

        public int Year { get; private set; }
        public int Month { get; private set; }
        public bool Is21Century => this.Year >= 2001 && this.Year <= 2100;

        public YearMonth AddOneMoth ()
        {
            var newYear = this.Year;
            var newMonth = this.Month + 1;

            if (newMonth > 12)
            {
                newYear += 1;
                newMonth -= 12;
            }

            return new YearMonth(newYear, newMonth);
        }

        public override String ToString()
        {
            return $"{this.Year}年{this.Month}月";
        }
    }
}
