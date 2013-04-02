using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternsLib.Patterns.Chain.Example;

namespace Patterns.Actions.Patterns
{
    class Chain : PatternAction
    {
        public override void Execute()
        {
            // Setup Chain of Responsibility
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();
            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            // Generate and process request
            int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

            foreach (var request in requests)
            {
                var result = h1.HandleRequest(request);
                if (result != String.Empty)
                {
                    Console.WriteLine(result);
                }
            }

            _again();
        }
    }
}
