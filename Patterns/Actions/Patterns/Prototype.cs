using System;
using System.Collections;
using System.Linq;
using PatternsLib.Patterns.Factory.Example;
using PatternsLib.Patterns.Prototype.Example;

namespace Patterns.Actions.Patterns
{
    public class Prototype : PatternAction
    {
        public override void Execute()
        {
            var prototype1 = new ConcretePrototype1("Hello");
            var prototype2 = new ConcretePrototype2("World"); 
           
            Console.WriteLine("Result by 1 prototype: "+prototype1.Id);
            Console.WriteLine("Result by 2 prototype: " + prototype2.Id);

            _again();
        }

    }
}