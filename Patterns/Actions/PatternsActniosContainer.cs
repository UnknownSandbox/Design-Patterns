using System;
using System.Collections.Generic;

namespace Patterns.Actions
{
    public class PatternsActniosContainer : List<PatternStruct>
    {
        public List<string> Keys = new List<string>();
        public List<PatternStruct> List = new List<PatternStruct>();

        public void Add(PatternStruct pattern)
        {
            if (_is_exists(pattern.Key))
            {
                throw new Exception("Pattern with key " + pattern.Key + " already exists");
            }
            Keys.Add(pattern.Key);
            List.Add(pattern);
        }

        private bool _is_exists(string key)
        {
            return Keys.Contains(key);
        }
    }
}