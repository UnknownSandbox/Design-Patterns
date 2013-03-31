using System;
using PatternsLib.Patterns.Decorator.Example;

namespace Patterns.Actions.Patterns
{
    internal class Decorator : PatternAction
    {
        public override void Execute()
        {
            // Create ConcreteComponent and two Decorators
            var c = new ConcreteComponent();
            var d1 = new ConcreteDecoratorA();
            var d2 = new ConcreteDecoratorB();

            // Link decorators
            d1.SetComponent(c);
            d2.SetComponent(d1);

            Console.Write(d2.Operation());

            _again();
        }
    }
}