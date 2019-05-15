using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Extensions;

namespace Exersice7
{
    class Program
    {
        static void Main(string[] args)
        {
            Answer7_1();
        }

        static void Answer7_1()
        {
            var str = "Cozy lummox gives smart squid who asks for job pen";
            var dic = new Dictionary<char, int>();

            foreach (var c in str)
            {
                var upperC = char.ToUpper(c);

                if (upperC < 'A' || upperC > 'Z')
                {
                    continue;
                }

                if (dic.ContainsKey(key: upperC))
                {
                    dic[upperC] += 1;
                    continue;
                }

                dic[upperC] = 1;
            }

            dic = dic.OrderBy(p => p.Key)
                .ToDictionary(p => p.Key, p => p.Value);
            dic.ConsoleLog("Answer7_1 dic");
        }

        static 
    }
}
