using System;
using System.Collections;
using System.Linq;
using PatternsLib.Patterns.Factory.Example;

namespace Patterns.Actions.Patterns
{
    public class Factory : PatternAction
    {
        public override void Execute()
        {
            var factory = new PatternsLib.Patterns.Factory.Example.Factory();

            Console.WriteLine("Choose product type:");
            Console.WriteLine("Key - {0} . Type - {1} ", "1", "ProductA");
            Console.WriteLine("Key - {0} . Type - {1} ", "2", "ProductB");

            Console.WriteLine("");
            Console.Write("Set key: "); var userKey = Console.ReadLine();

            var type = _getTypeByKey(userKey);
            var product = factory.GetInstance(type);

            Console.WriteLine("Price of this product: {0}", product.GetPrice());
            _again();
        }
 
        private ProductTypes _getTypeByKey(string userKey)
        {
            switch (userKey)
            {
                case "1":
                    return ProductTypes.ProductA;
                case "2":
                    return ProductTypes.ProductB;
                default:
                    throw (new Exception("Unknown key for product type"));
            }
        }
    }
}