using System;
using PatternsLib.Patterns.Factory.Example.Products;

namespace PatternsLib.Patterns.Factory.Example
{
    public class Factory : PatternsLib.Patterns.Factory.Factory<ProductTypes, IProduct>
    {
        public override IProduct GetInstance(ProductTypes type)
        {
            switch (type)
            {
                case ProductTypes.ProductA:
                    return new ProductA();
                    break;
                case ProductTypes.ProductB:
                    return new ProductB();
                default:
                    throw (new Exception("Unknown Product"));
            }
        }
    }
}