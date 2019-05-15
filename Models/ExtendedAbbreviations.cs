using System;
using System.Linq;

namespace Models
{
    public class ExtendedAbbreviations : Abbreviations
    {
        public int Count
        {
            get
            {
                return _dict.Keys.Count;
            }
        }

        public bool Remove(string abbr)
        {
            if (_dict.ContainsKey(abbr))
            {
                _dict.Remove(abbr);
                return true;
            }

            return false;
        }

        public void PrintThreeCharsAbbr()
        {
            var targets = _dict
                .Where(p => p.Key.Length == 3);

            foreach (var t in targets)
            {
                Console.WriteLine("{0}={1}", t.Key, t.Value);
            }
        }
    }
}
