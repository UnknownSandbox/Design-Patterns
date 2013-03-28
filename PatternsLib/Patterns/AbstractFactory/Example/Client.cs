using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLib.Patterns.AbstractFactory.Example
{
    public class Client
    {
        private  AbstractProductA _productA;
        private  AbstractProductB _productB;

        public Client(AbstractFactory factory)
        {
            _productA = factory.CreateProductA();
            _productB = factory.CreateProductB();
        }

        public string GetProductResult()
        {
            return _productB.GetInteract(_productA);
        }
    }
}
