using System;

namespace PatternsLib.Patterns.Adapter.Example
{
    public class Adaptee
    {
        public string SpecificRequest()
        {
            return  "Called SpecificRequest()";
        }
    }
}