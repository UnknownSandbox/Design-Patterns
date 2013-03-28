using System;
using System.Collections;
using System.Linq;
using PatternsLib.Patterns.Builder.Example;
using PatternsLib.Patterns.Builder.Example.Builders;
using PatternsLib.Patterns.Factory.Example;

namespace Patterns.Actions.Patterns
{
    public class Builder : PatternAction
    {
        public override void Execute()
        {
            var factory = new PatternsLib.Patterns.Factory.Example.Factory();

            Console.WriteLine("Choose builder type:");
            Console.WriteLine("Key - {0} . Type - {1} ", "1", "Builder1");
            Console.WriteLine("Key - {0} . Type - {1} ", "2", "Builder2");

            Console.WriteLine("");
            Console.Write("Set key: "); var userKey = Console.ReadLine();

            var builder = _getBuilderByKey(userKey);
            var director = new Director();

            director.Constructor(builder);
            var product = builder.GetResult();
            var result = product.GetParts();
            Console.WriteLine("\n");
            for (int index = 0; index < result.Count; index++)
            {
                var resultItem = result[index]; 
                Console.WriteLine("Part[{0}] - {1}",index,resultItem);
            }
            Console.WriteLine("\n");
     
            _again();
        }

        private PatternsLib.Patterns.Builder.Example.Builder _getBuilderByKey(string userKey)
        {
            switch (userKey)
            {
                case "1":
                    return new ConcreteBuilder1();
                case "2":
                    return new ConcreteBuilder2();
                default:
                    throw (new Exception("Unknown key for product type"));
            }
        }
    }
}