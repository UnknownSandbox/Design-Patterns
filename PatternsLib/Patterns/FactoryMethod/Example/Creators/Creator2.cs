using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternsLib.Patterns.FactoryMethod.Example.Products;

namespace PatternsLib.Patterns.FactoryMethod.Example.Creators
{
    public class Creator2 : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
