﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternsLib.Patterns.AbstractFactory.Example.Products;

namespace PatternsLib.Patterns.AbstractFactory.Example.Factories
{
    public class ConcreteFactory3 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
