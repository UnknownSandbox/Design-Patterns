using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadePattern = PatternsLib.Patterns.Facade.Example.Facade;
namespace Patterns.Actions.Patterns
{
    class Facade : PatternAction
    {
        public override void Execute()
        {
            Console.WriteLine(FacadePattern.Operation1());
            Console.WriteLine(FacadePattern.Operation2());

            _again();
        }
    }
}
