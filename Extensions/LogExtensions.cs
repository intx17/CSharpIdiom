using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace Extensions
{
    public static class LogExtensions
    {
        [Conditional("DEBUG")]
        public static void ConsoleLog<T>(this T obj, string name)
        {
            try
            {
                var json = JsonConvert.SerializeObject(obj, Formatting.Indented);
                Console.WriteLine($"{name} = {json}");
            }
            catch
            {
                Console.WriteLine("{0} : Debug Log Error!", name);
            }
        }
    }
}
