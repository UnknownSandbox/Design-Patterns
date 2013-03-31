using System;

namespace PatternsLib.Patterns.Decorator.Example
{
    public class ConcreteDecoratorA : Decorator
    {
        private string _addedState;

        public override string Operation()
        {
            var str = base.Operation();
            _addedState = "New State";
            str += "ConcreteDecoratorA.Operation()\n";
            return str;
        }
    }
}