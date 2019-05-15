using System;
using System.Collections.Generic;

namespace Chap4Exercise
{
    public static class YearMonthUtil
    {
        public static YearMonth FindFirst21CenturyYearMonth(IEnumerable<YearMonth> yearMonths)
        {
            foreach (var ym in yearMonths)
            {
                if (Is21stCenturyYear(ym))
                {
                    return ym;
                }
            }

            return null;
        }

        private static bool Is21stCenturyYear(YearMonth yearMonth)
        {
            if (yearMonth.Year >= 2001 && yearMonth.Year<= 2100)
            {
                return true;
            }

            return false;
        }
    }
}
