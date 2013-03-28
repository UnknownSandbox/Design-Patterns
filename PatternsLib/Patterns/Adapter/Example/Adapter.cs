using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLib.Patterns.Adapter.Example
{ 

    public class Adapter : Target
    {
        private readonly Adaptee _adaptee = new Adaptee();

        public override string Request()
        {
            // Possibly do some other work
            // and then call SpecificRequest
            return _adaptee.SpecificRequest();
        }
    }

   
}
