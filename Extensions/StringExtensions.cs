using System;
namespace Extensions
{
    public static class StringExtensions
    {
        public static string Reverse(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return string.Empty;
            }

            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
