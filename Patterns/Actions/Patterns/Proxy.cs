using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternsLib.Patterns.Proxy.Example;

namespace Patterns.Actions.Patterns
{
    class Proxy : PatternAction
    {
        public override void Execute()
        {
            // Create math proxy
            IMath proxy = new MathProxy();

            // Do the math
            Console.WriteLine(proxy.GetState());
            Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
            Console.WriteLine(proxy.GetState());
            Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
            Console.WriteLine(proxy.GetState());
            Console.WriteLine("Create Real Object...");
            Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2)); 
            Console.WriteLine(proxy.GetState());
            Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));
            Console.WriteLine(proxy.GetState());

            _again();
        }
    }
}
