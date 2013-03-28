using System;

namespace PatternsLib.Patterns.Adapter.Example
{
    public class Target
    {
        public virtual string Request()
        {
            return  "Called Target Request()";
        }
    }
}