using System;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class WordsExtractor
    {
        private string[] _lines;
        private char[] _separators = @" !?"",.".ToCharArray();

        public WordsExtractor(string[] lines)
        {
            _lines = lines;
        }

        public IEnumerable<string> Extract()
        {
            var hash = new HashSet<string>();

            foreach (var line in _lines)
            {
                var words = GetWords(line);

                foreach(var word in words)
                {
                    if (word.Length >= 10)
                    {
                        hash.Add(word);
                    }
                }
            }
            return hash.OrderBy(s => s);
        }

        private IEnumerable<string> GetWords(string line)
        {
            var items = line.Split(_separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in items)
            {
                // remove after apostrophe
                var index = item.IndexOf('\'');
                var word = index <= 0
                    ? item
                    : item.Substring(0, index);

                if (word.ToLower().All(c => 'a' <= c && c <= 'z'))
                {
                    yield return word.ToLower();
                }
            }
        }
    }
}
