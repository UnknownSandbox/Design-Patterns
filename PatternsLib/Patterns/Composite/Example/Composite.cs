using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLib.Patterns.Composite.Example
{
   

    /// <summary>
    /// Composite - составной объект
    /// </summary>
    /// <li>
    /// <lu>определяет поведеление компонентов, у которых есть потомки;</lu>
    /// <lu>хранит компоненты-потомоки;</lu>
    /// <lu>реализует относящиеся к управлению потомками операции и интерфейсе
    /// класса <see cref="Component"/></lu>
    /// </li>
    public class Composite : Component
    { 
        // Constructor
        public Composite(string name)
            : base(name)
        {
        }
         
        public override string Display(int depth)
        {
            var str = new String('-', depth) + name + "\n";

            // Recursively display child nodes
            return Children.Cast<Component>().Aggregate(str, (current, component) => current + component.Display(depth + 2));
        }

        public override bool ItsComposite()
        {
            return true;
        }
    }
}
