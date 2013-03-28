using System;
using System.Collections;
using System.Linq;
using PatternsLib.Patterns.Builder.Example;
using PatternsLib.Patterns.Builder.Example.Builders;
using PatternsLib.Patterns.Factory.Example;
using PatternsLib.Patterns.FactoryMethod.Example;
using PatternsLib.Patterns.FactoryMethod.Example.Creators;
using Product = PatternsLib.Patterns.FactoryMethod.Example.Product;

namespace Patterns.Actions.Patterns
{
    public class FactoryMethod : PatternAction
    {
        public override void Execute()
        {
            var factory = new PatternsLib.Patterns.Factory.Example.Factory();

            Creator[] creators =  { new Creator1() , new Creator2() };

            foreach (var creator in creators)
            {
                var product = creator.FactoryMethod();
                Console.WriteLine("Created {0}", product.GetType().Name);
            }
             
            _again();
        }
 
    }
}