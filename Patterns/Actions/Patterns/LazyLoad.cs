using System;
using PatternsLib.Patterns.LazyLoad.Example;

namespace Patterns.Actions.Patterns
{
    public class LazyLoad : PatternAction 
    {
        public override void Execute()
        { 
            Console.WriteLine("First call.Wait...");
            var bigObject = BigObject.Instance;
            Console.WriteLine("Get Instance : " + BigObject.Instance);
            
            Console.WriteLine("Second call.Already exists...");
            Console.WriteLine("Get Instance : " + BigObject.Instance);
             
            Console.WriteLine(BigObject.Instance + " - reloaded");
            BigObject.Reload();

            _again();
        }

    }
}