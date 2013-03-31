using System;

namespace PatternsLib.Patterns.Bridge.Example
{
    /// <summary>
    /// ConcreteImplementor - конкретный реализатор
    /// </summary>
    /// <remarks>
    /// <li>
    /// <lu>содержит конкретную реализацию интерфейса <see cref="Implementor"/></lu>
    /// </li>
    /// </remarks>
    public class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorA Operation");
        }
    }
}