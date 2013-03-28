using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLib.Patterns.Builder.Example
{
    public class Director
    { 
        public void Constructor(Builder builder)
        {
            builder.BuildPart1();
            builder.BuildPart2();
        }
    }
}
