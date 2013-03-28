using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternsLib.Patterns.AbstractFactory.Example;
using PatternsLib.Patterns.AbstractFactory.Example.Factories;
using PatternsLib.Patterns.Factory.Example;

namespace Patterns.Actions.Patterns
{
    class AbstractFactory : PatternAction
    {
        public override void Execute()
        {
            Console.WriteLine("Choose Factory realisation:");
            Console.WriteLine("Key - {0} . Factory - {1} ", "1", "Factory1");
            Console.WriteLine("Key - {0} . Factory - {1} ", "2", "Factory2");
            Console.WriteLine("Key - {0} . Factory - {1} ", "3", "Factory3");
            Console.WriteLine("Key - {0} . Factory - {1} ", "4", "Factory4");

            Console.WriteLine("");
            Console.Write("Set key: "); var userKey = Console.ReadLine();

            var factory = _getFactoryByKey(userKey);
            var client = new Client(factory);
            var result = client.GetProductResult();
            Console.WriteLine("Result: {0}", result);
            _again();
        } 
 
        private PatternsLib.Patterns.AbstractFactory.Example.AbstractFactory _getFactoryByKey(string userKey)
        {
            switch (userKey)
            {
                case "1":
                    return new ConcreteFactory1();
                case "2":
                    return new ConcreteFactory2();
                case "3":
                    return new ConcreteFactory3();
                case "4":
                    return new ConcreteFactory4();
                default:
                    throw (new Exception("Unknown key for factory type"));
            }
        }
    }
}
