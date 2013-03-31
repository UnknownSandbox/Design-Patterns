using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternsLib.Patterns.Bridge.Example;

namespace Patterns.Actions.Patterns
{
    public class Bridge : PatternAction
    {
        public override void Execute()
        {
            Abstraction ab = new RefinedAbstraction();

            // Set implementation and call
            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            // Change implementation and call
            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();

            _again();
        }
    }
}
