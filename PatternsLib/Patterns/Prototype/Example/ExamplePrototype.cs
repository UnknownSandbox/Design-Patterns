using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLib.Patterns.Prototype.Example
{
    public abstract class ExamplePrototype : Prototype<ExamplePrototype>
    {
        private string id;

        // Constructor
        protected ExamplePrototype(string id)
        {
            this.id = id;
        }

        // Property
        public string Id
        {
            get { return id; }
        }
         
    } 
    
}
