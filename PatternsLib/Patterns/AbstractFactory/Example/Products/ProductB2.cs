using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLib.Patterns.AbstractFactory.Example.Products
{
    class ProductB2 : AbstractProductB
    {
        public override string GetInteract(AbstractProductA productA)
        {
            var result = this.GetType().Name + " interact with " + productA.GetType().Name;
            return result;
        }
    }
}
