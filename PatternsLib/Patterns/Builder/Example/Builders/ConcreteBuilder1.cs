using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLib.Patterns.Builder.Example.Builders
{
    public class ConcreteBuilder1 :Builder
    {
        private Product _product = new Product();
         
        public override void BuildPart1()
        {
           _product.Add("PartA");
        }

        public override void BuildPart2()
        {
            _product.Add("PartB");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}
