using System;
using System.Collections.Generic;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> {
                "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong"
            };


            var exists = list.Exists(s => s[0] == 'A');
            Console.WriteLine(exists);

            var name = list.Find(s => s.Length == 6);
            Console.WriteLine(name);

            var index = list.FindIndex(s => s == "Berlin");
            Console.WriteLine(index);

            var names = list.FindAll(s => s.Length <= 5);
            names.ForEach(n => Console.WriteLine(n));

            var removedCount = list.RemoveAll(s => s.Contains("on"));
            Console.WriteLine(removedCount);

            var lowerList = list.ConvertAll(s => int.Parse(s));
            lowerList.ForEach(s => Console.WriteLine(s));
        }
    }
}
