using System;
using System.Collections.Generic;
using System.IO;
using Models;

namespace Chapter7
{
    class Program
    {
        private Dictionary<string, int> flowerDict = new Dictionary<string, int>()
        {
            ["sunflower"] = 400,
            ["pansy"] = 300,
            ["tulip"] = 350,
            ["rose"] = 500,
            ["dahlia"] = 450,
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List7_16();
        }

        static int? GetPrice(string key, Dictionary<string, int> dic)
        {
            if(dic.ContainsKey(key))
            {
                return dic[key];
            }

            return null;
        }

        static void List7_13()
        {
            var dict = new Dictionary<MonthDay, string>
            {
                [new MonthDay(3, 5)] = "珊瑚の日",
                [new MonthDay(8, 4)] = "箸の日",
                [new MonthDay(10, 3)] = "登山の日",
            };

            var md = new MonthDay(8, 4);
            var s = dict[md];
            Console.WriteLine(s);
        }

        static void List7_16()
        {
            var lines = File.ReadAllLines($"./sample.txt");
            var we = new WordsExtractor(lines);

            foreach (var word in we.Extract())
            {
                Console.WriteLine(word);
            }
        }
    }
}
