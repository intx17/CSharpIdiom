using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Chap4Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var yearMonthList = GetYearMonthList();

            foreach(var ym in yearMonthList)
            {
                Console.WriteLine(ym.ToString());
            }

            // 21世紀
            Console.WriteLine("21世紀");
            string first21CenturyYMData = YearMonthUtil.FindFirst21CenturyYearMonth(yearMonthList).ToString()
                ?? "21正規のデータはありません";
            Console.WriteLine(first21CenturyYMData);

            var oneMonthAddedYearMonths = yearMonthList
                .Select(ym => ym.AddOneMoth())
                .OrderBy(ym => ym.Year)
                .ThenBy(ym => ym.Month);

            foreach (var ym in oneMonthAddedYearMonths)
            {
                Console.WriteLine(ym.ToString());
            }
        }

        static IEnumerable<YearMonth> GetYearMonthList()
        {
            return new List<YearMonth>
            {
                new YearMonth(2015, 6),
                new YearMonth(2122, 3),
                new YearMonth(1900, 5),
                new YearMonth(2000, 12),
                new YearMonth(2101, 12)
            };
        }
    }
}
