using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLib.Patterns.Decorator.Example
{
    public abstract class Decorator : Component
    {
        protected Component Component;

        public void SetComponent(Component component)
        {
            this.Component = component;
        }

        public override string Operation()
        {
            var str = "";
            if (Component != null)
            {
                 str = Component.Operation();
            }
            return str;
        }
    }
}
