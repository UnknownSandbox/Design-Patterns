using System;

namespace PatternsLib.Patterns.Decorator.Example
{
    public class ConcreteDecoratorB : Decorator
    {
        public override string Operation()
        {
            var str = base.Operation();
            AddedBehavior();
            str += "ConcreteDecoratorB.Operation()\n";
            return str;
        }

        void AddedBehavior()
        {
        }
    }
}