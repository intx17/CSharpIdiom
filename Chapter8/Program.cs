using System;
using Extensions;

namespace Chapter8
{
    class Program
    {
        static void Main(string[] args)
        {
            L8_7();
        }

        static void L8_7()
        {
            DateTime dt1;
            if (DateTime.TryParse("2017/6/21", out dt1))
            {
                dt1.ConsoleLog("dt1");
            }

            DateTime dt2;
            if (DateTime.TryParse("2017/6/21 10:41:38", out dt2))
            {
                dt2.ConsoleLog("dt1");
            }
        }
    }
}
