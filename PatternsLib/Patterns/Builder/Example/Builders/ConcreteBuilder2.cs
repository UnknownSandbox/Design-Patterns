using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLib.Patterns.Builder.Example.Builders
{
    public class ConcreteBuilder2 :Builder
    {
        private Product _product = new Product();
         
        public override void BuildPart1()
        {
           _product.Add("PartX");
        }

        public override void BuildPart2()
        {
            _product.Add("PartY");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}
