using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternsLib.Patterns.Adapter.Example;

namespace Patterns.Actions.Patterns
{
    class Adapter : PatternAction
    {
        public override void Execute()
        {
            Target target = new PatternsLib.Patterns.Adapter.Example.Adapter();
            Console.WriteLine(target.Request());
             
            _again();
        }
    }
}
