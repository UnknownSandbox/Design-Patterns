using System;

namespace PatternsLib.Patterns.Decorator.Example
{
    public class ConcreteComponent : Component
    {
        public override string Operation()
        {
            return  "ConcreteComponent.Operation()\n";
        }
    }
}