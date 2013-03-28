using System;
using System.Collections.Generic;

namespace PatternsLib.Patterns.Builder.Example
{
    public class Product
    {
        private readonly List<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public List<string> GetParts()
        {
            return parts;
        }
    }
}