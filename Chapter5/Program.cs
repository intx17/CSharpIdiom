using System;
using System.Globalization;

namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CompareIgnoreZenHanUpperLower("Ｃｏｍｐｕｔｅｒ", "COMPUTER");
        }

        static void CompareWithKana(string str1, string str2)
        {
            var cultureInfo = new CultureInfo("ja-JP");

            if (cultureInfo.CompareInfo.Compare(str1, str2, CompareOptions.IgnoreKanaType) == 0)
            {
                Console.WriteLine("一致しています");
            }
        }

        static void CompareIgnoreZenHanUpperLower(string str1, string str2)
        {
            var compareInfo = new CultureInfo("ja-JP").CompareInfo;

            if (compareInfo.Compare(str1, str2, CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase) == 0)
            {
                Console.WriteLine("一致しています");
            }
        }
    }
}
