using System;

namespace PatternsLib.Patterns.Composite.Example
{
    /// <summary>
    /// Leaf - лист
    /// </summary>
    /// <remarks>
    /// <li>
    /// <lu>представляет листовой узел композиции и не имеет потомков;</lu>
    /// <lu>определяет поведение примитивных объектов в композиции;</lu>
    /// </li>
    /// </remarks>
    public class Leaf : Component
    {

        // Constructor
        public Leaf(string name)
            : base(name)
        {
        }
          
        public override string Display(int depth)
        {
            return new String('-', depth) + name + "\n";
        }

        public override bool ItsComposite()
        {
            return false;
        }
    }
}