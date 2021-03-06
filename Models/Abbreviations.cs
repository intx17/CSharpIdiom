﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Models
{
    public class Abbreviations
    {
        protected Dictionary<string, string> _dict = new Dictionary<string, string>();

        public Abbreviations()
        {
            var lines = File.ReadLines("Abbreviations.txt");
            _dict = lines.Select(line => line.Split('='))
                .ToDictionary(x => x[0], x =>x[1]);
        }

        public void Add(string abbr, string japanese)
        {
            _dict[abbr] = japanese;
        }

        public string this[string abbr]
        {
            get
            {
                return _dict.ContainsKey(abbr)
                    ? _dict[abbr]
                    : null;
            }
        }

        public string ToAbbreviation(string japanese)
        {
            return _dict.FirstOrDefault(x => x.Value == japanese).Key;
        }

        public IEnumerable<KeyValuePair<string, string>> FindAll(string substring)
        {
            foreach (var item in _dict)
            {
                if (item.Value.Contains(substring))
                {
                    yield return item;
                }
            }
        }
    }
}
