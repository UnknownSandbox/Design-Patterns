using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLib.Patterns.Prototype
{
    public abstract class Prototype<T>
    {
        public T Clone()
        {
            // Shallow copy
            return (T)this.MemberwiseClone();
        }
    }
}
